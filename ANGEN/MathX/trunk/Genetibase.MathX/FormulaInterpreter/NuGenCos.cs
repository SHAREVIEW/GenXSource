/* -----------------------------------------------
 * NuGenCos.cs
 * Copyright � 2007 Alex Nesterov
 * mailto:a.nesterov@genetibase.com
 * --------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace Genetibase.MathX.FormulaInterpreter
{
	/// <summary>
	/// cos()
	/// </summary>
	public class NuGenCos : NuGenFunction
	{
		/// <summary>
		/// Gets the value of the element, including all calculations required.
		/// </summary>
		/// <value></value>
		public override double Value
		{
			get
			{
				return Math.Cos(NuGenInterpreter.AngleToRadians(this.Element.Value));
			}
		}

		/// <summary>
		/// Measures the element and its subitems with the speicifed <see cref="NuGenMeasureElementArgs"/>.
		/// </summary>
		/// <param name="e"></param>
		public override void MeasureElement(NuGenMeasureElementArgs e)
		{
			//measure child
			this.Element.MeasureElement(e);
			//calculate "sin" size
			Size funcsize = Size.Round(e.Graphics.MeasureString("cos", e.Font));
			//set own size
			this.RenderBounds = new NuGenCenteredSize(
				this.Element.RenderBounds.Width + 6 + funcsize.Width,
				Math.Max(this.Element.RenderBounds.Height, funcsize.Height));
		}

		/// <summary>
		/// Measures the element and its subitems with the specified <see cref="NuGenRenderElementArgs"/>
		/// on the specified location.
		/// </summary>
		/// <param name="e"></param>
		/// <param name="location"></param>
		public override void RenderElement(NuGenRenderElementArgs e, Point location)
		{
			//measure "cos" size
			Size funcsize = Size.Round(e.Graphics.MeasureString("cos", e.Font));
			//draw "cos"
			e.Graphics.DrawString("cos", e.Font, e.Brush,
				location.X,
				location.Y + this.RenderBounds.TopPart - funcsize.Height / 2);
			//draw opening bracket
			e.Graphics.DrawArc(e.Pen,
				location.X + funcsize.Width, location.Y,
				3, this.RenderBounds.Height, 90, 180);
			//draw subelement
			this.Element.RenderElement(e, new Point(
				location.X + funcsize.Width + 3,
				location.Y + this.RenderBounds.TopPart - this.Element.RenderBounds.TopPart));
			//draw closing bracket
			e.Graphics.DrawArc(e.Pen,
				location.X + this.RenderBounds.Width - 3,
				location.Y,
				3, this.RenderBounds.Height, 270, 180);
		}

		/// <summary>
		/// Returns a <see cref="T:System.String"></see> that represents the current <see cref="T:System.Object"></see>.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.String"></see> that represents the current <see cref="T:System.Object"></see>.
		/// </returns>
		public override string ToString()
		{
			return "cos(" + this.Element.ToString() + ")";
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="NuGenCos"/> class.
		/// </summary>
		/// <param name="element"></param>
		/// <exception cref="ArgumentNullException"><paramref name="element"/> is <see langword="null"/>.</exception>
		public NuGenCos(NuGenFormulaElement element)
			: base(element)
		{
		}
	}
}
