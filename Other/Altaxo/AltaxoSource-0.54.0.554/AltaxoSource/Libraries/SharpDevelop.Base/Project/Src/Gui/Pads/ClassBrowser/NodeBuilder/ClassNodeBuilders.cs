// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Robert Zaunere" email=""/>
//     <version>$Revision: 1965 $</version>
// </file>

using System;
using System.Windows.Forms;
using ICSharpCode.Core;
using ICSharpCode.SharpDevelop.Dom;
using ICSharpCode.SharpDevelop.Project;

namespace ICSharpCode.SharpDevelop.Gui.ClassBrowser
{
	public static class ClassNodeBuilders
	{
		/// <summary>
		/// This method builds a ClassBrowserNode Tree out of a given combine.
		/// </summary>
		public static TreeNode AddClassNode(ExtTreeView classBrowser, IProject project, IClass c)
		{
			IClassNodeBuilder classNodeBuilder = null;
			foreach (IClassNodeBuilder nodeBuilder in AddInTree.BuildItems("/SharpDevelop/Views/ClassBrowser/ClassNodeBuilders", null, true))
			{
				if (nodeBuilder.CanBuildClassTree(c))
				{
					classNodeBuilder = nodeBuilder;
					break;
				}
			}
			if (classNodeBuilder != null)
			{
				return classNodeBuilder.AddClassNode(classBrowser, project, c);
			}

			throw new NotImplementedException("Can't create node builder for class " + c.Name);
		}
	}
}
