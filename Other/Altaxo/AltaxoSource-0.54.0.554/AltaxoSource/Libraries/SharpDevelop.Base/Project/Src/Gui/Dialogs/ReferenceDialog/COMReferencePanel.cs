// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Poul Staugaard" email="poul@staugaard.dk"/>
//     <version>$Revision: 1965 $</version>
// </file>

using System;
using System.Windows.Forms;
using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Project;

namespace ICSharpCode.SharpDevelop.Gui
{
	public class COMReferencePanel : ListView, IReferencePanel
	{
		ISelectReferenceDialog selectDialog;
		
		public COMReferencePanel(ISelectReferenceDialog selectDialog)
		{
			this.selectDialog = selectDialog;
			
			this.Sorting = SortOrder.Ascending;
			
			
			ColumnHeader nameHeader = new ColumnHeader();
			nameHeader.Text  = ResourceService.GetString("Global.Name");
			nameHeader.Width = 240;
			Columns.Add(nameHeader);
			
			ColumnHeader directoryHeader = new ColumnHeader();
			directoryHeader.Text  = ResourceService.GetString("Global.Path");
			directoryHeader.Width =200;
			Columns.Add(directoryHeader);
			
			View = View.Details;
			Dock = DockStyle.Fill;
			FullRowSelect = true;
			
			ItemActivate += delegate { AddReference(); };
		}
		
		public void AddReference()
		{
			foreach (ListViewItem item in SelectedItems) {
				TypeLibrary library = (TypeLibrary)item.Tag;
				selectDialog.AddReference(ReferenceType.Typelib,
				                          library.Name,
				                          library.Path,
				                          library);
			}
		}
		
		bool populated;
		
		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (populated == false && Visible) {
				populated = true;
				PopulateListView();
			}
		}
		
		void PopulateListView()
		{
			foreach (TypeLibrary typeLib in TypeLibrary.Libraries) {
				ListViewItem newItem = new ListViewItem(new string[] { typeLib.Description, typeLib.Path });
				newItem.Tag = typeLib;
				Items.Add(newItem);
			}
		}
	}
}
