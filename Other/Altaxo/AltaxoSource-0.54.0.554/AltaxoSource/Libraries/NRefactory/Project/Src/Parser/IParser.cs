﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision: 1609 $</version>
// </file>

using System;
using ICSharpCode.NRefactory.Ast;

namespace ICSharpCode.NRefactory
{
	/// <summary>
	/// Parser interface.
	/// </summary>
	public interface IParser : IDisposable
	{
		Parser.Errors Errors {
			get;
		}
		
		Parser.ILexer Lexer {
			get;
		}
		
		CompilationUnit CompilationUnit {
			get;
		}
		
		bool ParseMethodBodies {
			get; set;
		}
		
		void Parse();
		
		Expression ParseExpression();
	}
}
