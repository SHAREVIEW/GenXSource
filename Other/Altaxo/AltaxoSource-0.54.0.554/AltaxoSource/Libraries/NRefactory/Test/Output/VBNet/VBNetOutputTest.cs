// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald" email="daniel@danielgrunwald.de"/>
//     <version>$Revision: 1671 $</version>
// </file>

using System;
using System.IO;
using NUnit.Framework;
using ICSharpCode.NRefactory.Parser;
using ICSharpCode.NRefactory.Ast;
using ICSharpCode.NRefactory.PrettyPrinter;

namespace ICSharpCode.NRefactory.Tests.PrettyPrinter
{
	[TestFixture]
	public class VBNetOutputTest
	{
		void TestProgram(string program)
		{
			IParser parser = ParserFactory.CreateParser(SupportedLanguage.VBNet, new StringReader(program));
			parser.Parse();
			Assert.AreEqual("", parser.Errors.ErrorOutput);
			VBNetOutputVisitor outputVisitor = new VBNetOutputVisitor();
			outputVisitor.VisitCompilationUnit(parser.CompilationUnit, null);
			Assert.AreEqual("", outputVisitor.Errors.ErrorOutput);
			Assert.AreEqual(StripWhitespace(program), StripWhitespace(outputVisitor.Text));
		}
		
		string StripWhitespace(string text)
		{
			return text.Trim().Replace("\t", "").Replace("\r", "").Replace("\n", " ").Replace("  ", " ");
		}
		
		void TestTypeMember(string program)
		{
			TestProgram("Class A\n" + program + "\nEnd Class");
		}
		
		void TestStatement(string statement)
		{
			TestTypeMember("Sub Method()\n" + statement + "\nEnd Sub");
		}
		
		void TestExpression(string expression)
		{
			IParser parser = ParserFactory.CreateParser(SupportedLanguage.VBNet, new StringReader(expression));
			Expression e = parser.ParseExpression();
			Assert.AreEqual("", parser.Errors.ErrorOutput);
			VBNetOutputVisitor outputVisitor = new VBNetOutputVisitor();
			e.AcceptVisitor(outputVisitor, null);
			Assert.AreEqual("", outputVisitor.Errors.ErrorOutput);
			Assert.AreEqual(StripWhitespace(expression), StripWhitespace(outputVisitor.Text));
		}
		
		[Test]
		public void Field()
		{
			TestTypeMember("Private a As Integer");
		}
		
		[Test]
		public void Method()
		{
			TestTypeMember("Sub Method()\nEnd Sub");
		}
		
		[Test]
		public void EnumWithBaseType()
		{
			TestProgram("Public Enum Foo As UShort\nEnd Enum");
		}
		
		[Test]
		public void PartialModifier()
		{
			TestProgram("Public Partial Class Foo\nEnd Class");
		}
		
		[Test]
		public void MustInheritClass()
		{
			TestProgram("Public MustInherit Class Foo\nEnd Class");
		}
		
		[Test]
		public void GenericClassDefinition()
		{
			TestProgram("Public Class Foo(Of T As {IDisposable, ICloneable})\nEnd Class");
		}
		
		[Test]
		public void GenericClassDefinitionWithBaseType()
		{
			TestProgram("Public Class Foo(Of T As IDisposable)\nInherits BaseType\nEnd Class");
		}
		
		[Test]
		public void GenericMethodDefinition()
		{
			TestTypeMember("Public Sub Foo(Of T As {IDisposable, ICloneable})(ByVal arg As T)\nEnd Sub");
		}
		
		[Test]
		public void ArrayRank()
		{
			TestStatement("Dim a As Object(,,)");
		}
		
		[Test]
		public void ArrayInitialization()
		{
			TestStatement("Dim a As Object() = New Object(10) {}");
			TestTypeMember("Private MultiDim As Integer(,) = {{1, 2}, {1, 3}}");
			TestExpression("New Integer(, ) {{1, 1}, {1, 1}}");
		}
		
		[Test]
		public void MethodCallWithOptionalArguments()
		{
			TestExpression("M(, )");
		}
		
		[Test]
		public void IfStatement()
		{
			TestStatement("If a Then\n" +
			              "\tm1()\n" +
			              "ElseIf b Then\n" +
			              "\tm2()\n" +
			              "Else\n" +
			              "\tm3()\n" +
			              "End If");
		}
		
		[Test]
		public void ForNextLoop()
		{
			TestStatement("For i = 0 To 10\n" +
			              "Next");
			TestStatement("For i As Long = 10 To 0 Step -1\n" +
			              "Next");
		}
		
		[Test]
		public void DoLoop()
		{
			TestStatement("Do\n" +
			              "Loop");
			TestStatement("Do\n" +
			              "Loop While Not (i = 10)");
		}
		
		[Test]
		public void SelectCase()
		{
			TestStatement(@"Select Case i
	Case 0
	Case 1 To 4
	Case Else
End Select");
		}
		
		[Test]
		public void UsingStatement()
		{
			TestStatement(@"Using nf As New Font(), nf2 As New List(Of Font)(), nf3 = Nothing
	Bla(nf)
End Using");
		}
		
		[Test]
		public void UntypedVariable()
		{
			TestStatement("Dim x = 0");
		}
		
		[Test]
		public void UntypedField()
		{
			TestTypeMember("Dim x = 0");
		}
		
		[Test]
		public void Assignment()
		{
			TestExpression("a = b");
		}
		
		[Test]
		public void SpecialIdentifiers()
		{
			// Assembly, Ansi and Until are contextual keywords
			// Custom is valid inside methods, but not valid for field names
			TestExpression("Assembly = Ansi * [For] + Until - [Custom]");
		}
		
		[Test]
		public void Integer()
		{
			TestExpression("12");
		}
		
		[Test]
		public void GenericMethodInvocation()
		{
			TestExpression("GenericMethod(Of T)(arg)");
		}
		
		[Test]
		public void SpecialIdentifierName()
		{
			TestExpression("[Class]");
		}
		
		[Test]
		public void GenericDelegate()
		{
			TestProgram("Public Delegate Function Predicate(Of T)(ByVal item As T) As String");
		}
		
		[Test]
		public void Enum()
		{
			TestProgram("Enum MyTest\nRed\n Green\n Blue\nYellow\n End Enum");
		}
		
		[Test]
		public void EnumWithInitializers()
		{
			TestProgram("Enum MyTest\nRed = 1\n Green = 2\n Blue = 4\n Yellow = 8\n End Enum");
		}
		
		[Test]
		public void SyncLock()
		{
			TestStatement("SyncLock a\nWork()\nEnd SyncLock");
		}
		
		[Test]
		public void Using()
		{
			TestStatement("Using a As New A()\na.Work()\nEnd Using");
		}
		
		[Test]
		public void Cast()
		{
			TestExpression("CType(a, T)");
		}
		
		[Test]
		public void DirectCast()
		{
			TestExpression("DirectCast(a, T)");
		}
		
		[Test]
		public void TryCast()
		{
			TestExpression("TryCast(a, T)");
		}
		
		[Test]
		public void PrimitiveCast()
		{
			TestExpression("CStr(a)");
		}
		
		[Test]
		public void TypeOfIs()
		{
			TestExpression("TypeOf a Is String");
		}
		
		[Test]
		public void PropertyWithAccessorAccessModifiers()
		{
			TestTypeMember("Public Property ExpectsValue() As Boolean\n" +
			               "\tPublic Get\n" +
			               "\tEnd Get\n" +
			               "\tProtected Set\n" +
			               "\tEnd Set\n" +
			               "End Property");
		}
		
		[Test]
		public void AbstractProperty()
		{
			TestTypeMember("Public MustOverride Property ExpectsValue() As Boolean");
			TestTypeMember("Public MustOverride ReadOnly Property ExpectsValue() As Boolean");
			TestTypeMember("Public MustOverride WriteOnly Property ExpectsValue() As Boolean");
		}
		
		[Test]
		public void AbstractMethod()
		{
			TestTypeMember("Public MustOverride Sub Run()");
			TestTypeMember("Public MustOverride Function Run() As Boolean");
		}
		
		[Test]
		public void InterfaceImplementingMethod()
		{
			TestTypeMember("Public Sub Run() Implements SomeInterface.Run\nEnd Sub");
			TestTypeMember("Public Function Run() As Boolean Implements SomeInterface.Bla\nEnd Function");
		}
		
		[Test]
		public void NamedAttributeArgument()
		{
			TestProgram("<Attribute(ArgName := \"value\")> _\n" +
			            "Class Test\n" +
			            "End Class");
		}
		
		[Test]
		public void Interface()
		{
			TestProgram("Interface ITest\n" +
			            "Property GetterAndSetter() As Boolean\n" +
			            "ReadOnly Property GetterOnly() As Boolean\n" +
			            "WriteOnly Property SetterOnly() As Boolean\n" +
			            "Sub InterfaceMethod()\n" +
			            "Function InterfaceMethod2() As String\n" +
			            "End Interface");
		}
		
		[Test]
		public void OnErrorStatement()
		{
			TestStatement("On Error Resume Next");
		}
		
		[Test]
		public void OverloadedConversionOperators()
		{
			TestTypeMember("Public Shared Narrowing Operator CType(ByVal xmlNode As XmlNode) As TheBug\nEnd Operator");
			TestTypeMember("Public Shared Widening Operator CType(ByVal bugNode As TheBug) As XmlNode\nEnd Operator");
		}
		
		[Test]
		public void OverloadedTrueFalseOperators()
		{
			TestTypeMember("Public Shared Operator IsTrue(ByVal a As TheBug) As Boolean\nEnd Operator");
			TestTypeMember("Public Shared Operator IsFalse(ByVal a As TheBug) As Boolean\nEnd Operator");
		}
		
		[Test]
		public void OverloadedOperators()
		{
			TestTypeMember("Public Shared Operator +(ByVal bugNode As TheBug, ByVal bugNode2 As TheBug) As TheBug\nEnd Operator");
			TestTypeMember("Public Shared Operator >>(ByVal bugNode As TheBug, ByVal b As Integer) As TheBug\nEnd Operator");
		}
		
		[Test]
		public void UsingStatementForExistingVariable()
		{
			TestStatement("Using obj\nEnd Using");
		}
		
		[Test]
		public void ContinueFor()
		{
			TestStatement("Continue For");
		}
		
		[Test]
		public void WithStatement()
		{
			TestStatement("With Ejes\n" +
			              "\t.AddLine(New Point(Me.ClientSize.Width / 2, 0), (New Point(Me.ClientSize.Width / 2, Me.ClientSize.Height)))\n" +
			              "End With");
		}
		
		[Test]
		public void NewConstraint()
		{
			TestProgram("Public Class Rational(Of T, O As {IRationalMath(Of T), New})\nEnd Class");
		}
		
		[Test]
		public void StructConstraint()
		{
			TestProgram("Public Class Rational(Of T, O As {IRationalMath(Of T), Structure})\nEnd Class");
		}
		
		[Test]
		public void ClassConstraint()
		{
			TestProgram("Public Class Rational(Of T, O As {IRationalMath(Of T), Class})\nEnd Class");
		}
	}
}
