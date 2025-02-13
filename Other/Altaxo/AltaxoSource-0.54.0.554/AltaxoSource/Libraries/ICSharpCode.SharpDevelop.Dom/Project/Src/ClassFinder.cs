// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision: 2066 $</version>
// </file>

using System;

namespace ICSharpCode.SharpDevelop.Dom
{
	/// <summary>
	/// Class that stores a source code context and can resolve type names
	/// in that context.
	/// </summary>
	public sealed class ClassFinder
	{
		int caretLine, caretColumn;
		ICompilationUnit cu;
		IClass callingClass;
		IProjectContent projectContent;
		
		public IClass CallingClass {
			get {
				return callingClass;
			}
		}
		
		public IProjectContent ProjectContent {
			get {
				return projectContent;
			}
		}
		
		public LanguageProperties Language {
			get {
				return projectContent.Language;
			}
		}
		
		public ClassFinder(string fileName, string fileContent, int offset)
		{
			caretLine = 0;
			caretColumn = 0;
			for (int i = 0; i < offset; i++) {
				if (fileContent[i] == '\n') {
					caretLine++;
					caretColumn = 0;
				} else {
					caretColumn++;
				}
			}
			Init(fileName);
		}
		
		public ClassFinder(string fileName, int caretLineNumber, int caretColumn)
		{
			this.caretLine   = caretLineNumber;
			this.caretColumn = caretColumn;
			
			Init(fileName);
		}
		
		public ClassFinder(IMember classMember)
			: this(classMember.DeclaringType, classMember.Region.BeginLine, classMember.Region.BeginColumn)
		{
		}
		
		public ClassFinder(IClass callingClass, int caretLine, int caretColumn)
		{
			this.caretLine = caretLine;
			this.caretColumn = caretColumn;
			this.callingClass = callingClass;
			this.cu = callingClass.CompilationUnit;
			this.projectContent = cu.ProjectContent;
			if (projectContent == null)
				throw new ArgumentException("callingClass must have a project content!");
		}
		
		// currently callingMember is not required
		public ClassFinder(IClass callingClass, IMember callingMember, int caretLine, int caretColumn)
			: this(callingClass, caretLine, caretColumn)
		{
		}
		
		void Init(string fileName)
		{
			ParseInformation parseInfo = HostCallback.GetParseInformation(fileName);
			if (parseInfo != null) {
				cu = parseInfo.MostRecentCompilationUnit;
			}
			
			if (cu != null) {
				callingClass = cu.GetInnermostClass(caretLine, caretColumn);
				projectContent = cu.ProjectContent;
			} else {
				projectContent = HostCallback.GetCurrentProjectContent();
			}
			if (projectContent == null)
				throw new ArgumentException("projectContent not found!");
		}
		
		public IClass GetClass(string fullName, int typeParameterCount)
		{
			return projectContent.GetClass(fullName, typeParameterCount);
		}
		
		public IReturnType SearchType(string name, int typeParameterCount)
		{
			return projectContent.SearchType(new SearchTypeRequest(name, typeParameterCount, callingClass, cu, caretLine, caretColumn)).Result;
		}
		
		public string SearchNamespace(string name)
		{
			return projectContent.SearchNamespace(name, callingClass, cu, caretLine, caretColumn);
		}
	}
}
