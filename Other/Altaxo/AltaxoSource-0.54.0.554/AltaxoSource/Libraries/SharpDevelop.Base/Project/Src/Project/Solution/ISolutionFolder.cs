﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 2067 $</version>
// </file>

using System;

namespace ICSharpCode.SharpDevelop.Project
{
	/// <summary>
	/// An project-like entry in a solution, for example a solution folder or a project.
	/// Implementing classes are required to implement this interface in a thread-safe manner.
	/// Thread-safe members lock on the SyncRoot. Non-thread-safe members may only be called from the main thread.
	/// </summary>
	public interface ISolutionFolder
	{
		/// <summary>
		/// Gets the object used for thread-safe synchronization.
		/// Thread-safe members lock on this object, but if you manipulate underlying structures
		/// (such as the MSBuild project for MSBuildBasedProjects) directly, you will have to lock on this object.
		/// </summary>
		object SyncRoot {
			get;
		}
		
		/// <summary>
		/// Gets/Sets the container that contains this folder. This member is thread-safe.
		/// </summary>
		ISolutionFolderContainer Parent {
			get;
			set;
		}
		
		/// <summary>
		/// Gets the solution the solution folder/project belongs to. This member is thread-safe.
		/// </summary>
		Solution ParentSolution {
			get;
		}
		
		string TypeGuid {
			get;
			set;
		}
		
		string IdGuid {
			get;
			set;
		}
		
		string Location {
			get;
			set;
		}
		
		string Name {
			get;
			set;
		}
	}
}
