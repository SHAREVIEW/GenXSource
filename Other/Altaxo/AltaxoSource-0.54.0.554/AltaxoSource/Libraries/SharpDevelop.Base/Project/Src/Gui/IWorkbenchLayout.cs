﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 1965 $</version>
// </file>

using System;

namespace ICSharpCode.SharpDevelop.Gui
{
	/// <summary>
	/// The IWorkbenchLayout object is responsible for the layout of
	/// the workspace, it shows the contents, chooses the IWorkbenchWindow
	/// implementation etc. it could be attached/detached at the runtime
	/// to a workbench.
	/// </summary>
	public interface IWorkbenchLayout
	{
		IWorkbenchWindow ActiveWorkbenchwindow {
			get;
		}
		object ActiveContent {
			get;
		}
		
		/// <summary>
		/// Attaches this layout manager to a workbench object.
		/// </summary>
		void Attach(IWorkbench workbench);
		
		/// <summary>
		/// Detaches this layout manager from the current workspace.
		/// </summary>
		void Detach();
		
		/// <summary>
		/// Shows a new <see cref="IPadContent"/>.
		/// </summary>
		void ShowPad(PadDescriptor content);
		
		/// <summary>
		/// Activates a pad (Show only makes it visible but Activate does
		/// bring it to foreground)
		/// </summary>
		void ActivatePad(PadDescriptor content);
		void ActivatePad(string fullyQualifiedTypeName);
		
		/// <summary>
		/// Hides a <see cref="IPadContent"/>.
		/// </summary>
		void HidePad(PadDescriptor content);
		
		/// <summary>
		/// Closes and disposes a <see cref="IPadContent"/>.
		/// </summary>
		void UnloadPad(PadDescriptor content);
		
		/// <summary>
		/// returns true, if padContent is visible;
		/// </summary>
		bool IsVisible(PadDescriptor padContent);
		
		/// <summary>
		/// Re-initializes all components of the layout manager.
		/// </summary>
		void RedrawAllComponents();
		
		/// <summary>
		/// Shows a new <see cref="IViewContent"/>.
		/// </summary>
		IWorkbenchWindow ShowView(IViewContent content);
		
		
		void LoadConfiguration();
		void StoreConfiguration();
		
		/// <summary>
		/// Is called, when the workbench window which the user has into
		/// the foreground (e.g. editable) changed to a new one.
		/// </summary>
		event EventHandler ActiveWorkbenchWindowChanged;
		
		// only needed in the workspace window when the 'secondary view content' changed
		// it is somewhat like 'active workbench window changed'
		void OnActiveWorkbenchWindowChanged(EventArgs e);
	}
}
