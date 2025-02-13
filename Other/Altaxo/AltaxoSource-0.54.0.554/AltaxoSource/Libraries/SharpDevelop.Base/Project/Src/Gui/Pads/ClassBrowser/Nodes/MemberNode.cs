﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 2039 $</version>
// </file>

using System;
using ICSharpCode.SharpDevelop.Dom;

namespace ICSharpCode.SharpDevelop.Gui.ClassBrowser
{
	public class MemberNode : ExtTreeNode
	{
		int    line;
		int    column;
		ModifierEnum modifiers;
		IClass declaringType;
		
		string FileName {
			get {
				if (declaringType == null || declaringType.CompilationUnit == null) {
					return null;
				}
				return declaringType.CompilationUnit.FileName;
			}
		}
		public override bool Visible {
			get {
				ClassBrowserFilter filter = ClassBrowserPad.Instance.Filter;
				if ((modifiers & ModifierEnum.Public) != 0) {
					return (filter & ClassBrowserFilter.ShowPublic) != 0;
				}
				if ((modifiers & ModifierEnum.Protected) != 0) {
					return (filter & ClassBrowserFilter.ShowProtected) != 0;
				}
				if ((modifiers & ModifierEnum.Private) != 0) {
					return (filter & ClassBrowserFilter.ShowPrivate) != 0;
				}
				return (filter & ClassBrowserFilter.ShowOther) != 0;
			}
		}
		
		IMember member;
		
		public IMember Member {
			get {
				return member;
			}
		}
		
		void InitMemberNode(IMember member)
		{
			this.member = member;
			this.ContextmenuAddinTreePath = "/SharpDevelop/Pads/ClassBrowser/MemberContextMenu";
			declaringType = member.DeclaringType;
			modifiers = member.Modifiers;
			line   = member.Region.BeginLine;
			column = member.Region.BeginColumn;
		}
		
		public static string GetText(IMember member)
		{
			return Create(member).Text;
		}
		
		public static MemberNode Create(IMember member)
		{
			if (member is IMethod)
				return new MemberNode(member as IMethod);
			else if (member is IProperty)
				return new MemberNode(member as IProperty);
			else if (member is IField)
				return new MemberNode(member as IField);
			else if (member is IEvent)
				return new MemberNode(member as IEvent);
			else
				throw new ArgumentException("unknown member type");
		}
		
		public MemberNode(IMethod method)
		{
			InitMemberNode(method);
			sortOrder = 10;
			Text = AppendReturnType(GetAmbience().Convert(method), method.ReturnType);
			SelectedImageIndex = ImageIndex = ClassBrowserIconService.GetIcon(method);
		}
		
		
		public MemberNode(IProperty property)
		{
			InitMemberNode(property);
			sortOrder = 12;
			Text = AppendReturnType(GetAmbience().Convert(property), property.ReturnType);
			SelectedImageIndex = ImageIndex = ClassBrowserIconService.GetIcon(property);
		}
		
		
		public MemberNode(IField field)
		{
			InitMemberNode(field);
			sortOrder = 11;
			Text = AppendReturnType(GetAmbience().Convert(field), field.ReturnType);
			SelectedImageIndex = ImageIndex = ClassBrowserIconService.GetIcon(field);
		}
		
		public MemberNode(IEvent e)
		{
			InitMemberNode(e);
			sortOrder = 14;
			Text = AppendReturnType(GetAmbience().Convert(e), e.ReturnType);
			SelectedImageIndex = ImageIndex = ClassBrowserIconService.GetIcon(e);
		}
		
		protected virtual IAmbience GetAmbience()
		{
			IAmbience ambience = AmbienceService.CurrentAmbience;
			ambience.ConversionFlags = ConversionFlags.None;
			return ambience;
		}
		
		string AppendReturnType(string text, IReturnType rt)
		{
			// TODO: Give user the possibility to turn off visibility of the return type
			return text + " : " + GetAmbience().Convert(rt);
		}
		
		public override void ActivateItem()
		{
			if (FileName != null) {
				FileService.JumpToFilePosition(FileName, line - 1, column - 1);
			}
		}
	}
}
