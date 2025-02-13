﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision: 2120 $</version>
// </file>

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Project;

namespace ICSharpCode.SharpDevelop.Gui
{
	public partial class EditAvailableConfigurationsDialog
	{
		Solution solution;
		IProject project;
		bool editPlatforms;
		
		private EditAvailableConfigurationsDialog()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			foreach (Control ctl in this.Controls) {
				ctl.Text = StringParser.Parse(ctl.Text);
			}
		}
		
		public EditAvailableConfigurationsDialog(Solution solution, bool editPlatforms)
			: this()
		{
			this.solution = solution;
			this.editPlatforms = editPlatforms;
			InitList();
			
			if (editPlatforms)
				this.Text = "Edit Solution Platforms";
			else
				this.Text = "Edit Solution Configurations";
		}
		
		public EditAvailableConfigurationsDialog(IProject project, bool editPlatforms)
			: this()
		{
			this.project = project;
			this.solution = project.ParentSolution;
			this.editPlatforms = editPlatforms;
			InitList();
			
			if (editPlatforms)
				this.Text = "Edit Project Platforms";
			else
				this.Text = "Edit Project Configurations";
		}
		
		void InitList()
		{
			if (project != null) {
				if (editPlatforms) {
					ShowEntries(project.PlatformNames, project.ActivePlatform);
				} else {
					ShowEntries(project.ConfigurationNames, project.ActiveConfiguration);
				}
			} else {
				if (editPlatforms) {
					ShowEntries(solution.GetPlatformNames(), solution.Preferences.ActivePlatform);
				} else {
					ShowEntries(solution.GetConfigurationNames(), solution.Preferences.ActiveConfiguration);
				}
			}
		}
		
		void ShowEntries(IEnumerable<string> list, string activeItem)
		{
			string[] array = Linq.ToArray(list);
			listBox.Items.Clear();
			listBox.Items.AddRange(array);
			if (listBox.Items.Count == 0) {
				throw new Exception("There must be at least one configuration/platform");
			}
			listBox.SelectedIndex = Math.Max(Array.IndexOf(array, activeItem), 0);
		}
		
		void RemoveButtonClick(object sender, EventArgs e)
		{
			if (listBox.Items.Count == 1) {
				MessageService.ShowMessage("You cannot delete all configurations/platforms.");
			}
			string name = listBox.SelectedItem.ToString();
			if (MessageService.AskQuestionFormatted("Do you really want to remove '{0}'?",
			                                        new string[] { name }))
			{
				if (project != null) {
					Remove(project, name, editPlatforms);
				} else {
					Remove(solution, name, editPlatforms);
				}
				InitList();
			}
		}
		
		static void Remove(IProject project, string name, bool isPlatform)
		{
			if (isPlatform) {
				project.ParentSolution.RemoveProjectPlatform(project, name);
			} else {
				project.ParentSolution.RemoveProjectConfiguration(project, name);
			}
		}
		
		static void Remove(Solution solution, string name, bool isPlatform)
		{
			if (isPlatform) {
				solution.RemoveSolutionPlatform(name);
			} else {
				solution.RemoveSolutionConfiguration(name);
			}
		}
		
		void RenameButtonClick(object sender, EventArgs e)
		{
			string oldName = listBox.SelectedItem.ToString();
			string newName = MessageService.ShowInputBox("${res:SharpDevelop.Refactoring.Rename}",
			                                             "Enter the new name:", oldName);
			if (string.IsNullOrEmpty(newName) || newName == oldName)
				return;
			if (!EnsureCorrectName(ref newName))
				return;
			if (project != null) {
				Rename(project, oldName, newName);
			} else {
				if (editPlatforms) {
					solution.RenameSolutionPlatform(oldName, newName);
					if (solution.Preferences.ActivePlatform == oldName) {
						solution.Preferences.ActivePlatform = newName;
					}
				} else {
					solution.RenameSolutionConfiguration(oldName, newName);
					if (solution.Preferences.ActiveConfiguration == oldName) {
						solution.Preferences.ActiveConfiguration = newName;
					}
				}
				// Solution platform name => project platform name
				foreach (IProject p in solution.Projects) {
					Rename(p, oldName, newName);
				}
			}
			InitList();
		}
		
		void Rename(IProject project, string oldName, string newName)
		{
			if (editPlatforms) {
				if (project.PlatformNames.Contains(newName))
					return;
				solution.RenameProjectPlatform(project, oldName, newName);
			} else {
				if (project.ConfigurationNames.Contains(newName))
					return;
				solution.RenameProjectConfiguration(project, oldName, newName);
			}
		}
		
		bool EnsureCorrectName(ref string newName)
		{
			newName = newName.Trim();
			if (editPlatforms && string.Equals(newName, "AnyCPU", StringComparison.InvariantCultureIgnoreCase))
				newName = "Any CPU";
			foreach (string item in listBox.Items) {
				if (string.Equals(item, newName, StringComparison.InvariantCultureIgnoreCase)) {
					MessageService.ShowMessage("Duplicate name.");
					return false;
				}
			}
			if (MSBuildInternals.Escape(newName) != newName
			    || !FileUtility.IsValidDirectoryName(newName)
			    || newName.Contains("'"))
			{
				MessageService.ShowMessage("The name was invalid.");
				return false;
			}
			return true;
		}
		
		void AddButtonClick(object sender, EventArgs e)
		{
			IEnumerable<string> availableSourceItems;
			if (project != null) {
				if (editPlatforms) {
					availableSourceItems = project.PlatformNames;
				} else {
					availableSourceItems = project.ConfigurationNames;
				}
			} else {
				if (editPlatforms) {
					availableSourceItems = solution.GetPlatformNames();
				} else {
					availableSourceItems = solution.GetConfigurationNames();
				}
			}
			
			using (AddNewConfigurationDialog dlg = new AddNewConfigurationDialog
			       (project == null, editPlatforms,
			        availableSourceItems,
			        delegate (string name) { return EnsureCorrectName(ref name); }
			       ))
			{
				if (dlg.ShowDialog(this) == DialogResult.OK) {
					string newName = dlg.NewName;
					// fix up the new name
					if (!EnsureCorrectName(ref newName))
						return;
					
					if (project != null) {
						IProjectAllowChangeConfigurations pacc = project as IProjectAllowChangeConfigurations;
						if (pacc != null) {
							if (editPlatforms) {
								pacc.AddProjectPlatform(newName, dlg.CopyFrom);
							} else {
								pacc.AddProjectConfiguration(newName, dlg.CopyFrom);
							}
						}
					} else {
						if (editPlatforms) {
							solution.AddSolutionPlatform(newName, dlg.CopyFrom, dlg.CreateInAllProjects);
						} else {
							solution.AddSolutionConfiguration(newName, dlg.CopyFrom, dlg.CreateInAllProjects);
						}
					}
					InitList();
				}
			}
		}
	}
}
