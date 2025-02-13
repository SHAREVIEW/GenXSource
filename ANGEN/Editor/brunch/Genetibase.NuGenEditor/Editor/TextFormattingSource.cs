/* -----------------------------------------------
 * TextFormattingSource.cs
 * Copyright © 2007 Alex Nesterov
 * mailto:a.nesterov@genetibase.com
 * --------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using Genetibase.Windows.Controls.Data.Text;
using Genetibase.Windows.Controls.Editor.Text.Classification;
using Genetibase.Windows.Controls.Logic.Text.Classification;
using System.Windows.Media.TextFormatting;
using System.Globalization;

namespace Genetibase.Windows.Controls.Editor
{
	internal class TextFormattingSource : TextSource
	{
		private NormalizedSpanManager _normalizedSpanManager;

		public TextFormattingSource(
			TextBuffer textBuffer
			, IClassificationFormatMap classificationFormatMap
			, Int32 startIndex
			, Int32 length
			, IList<ClassificationSpan> classificationSpans
			, IList<SpaceNegotiation> spaceNegotiations
			)
		{
			List<SpaceNegotiation> list = null;
			if (spaceNegotiations != null)
			{
				list = new List<SpaceNegotiation>(spaceNegotiations);
				list.Sort(new Comparison<SpaceNegotiation>(this.Comparison));
			}
			String text = textBuffer.GetText(startIndex, length);
			_normalizedSpanManager = new NormalizedSpanManager(text, startIndex, classificationSpans, list, classificationFormatMap);
		}

		private Int32 Comparison(SpaceNegotiation x, SpaceNegotiation y)
		{
			return (x.TextPosition.Position - y.TextPosition.Position);
		}

		public static Boolean ContainsBiDiCharacters(String text)
		{
			foreach (Char ch in text)
			{
				if ((((ch >= '֐') && (ch <= 'ࣿ')) || ((ch >= '‏') && (ch <= '‮'))) || (ch >= 0xfb1d))
				{
					return true;
				}
			}
			return false;
		}

		public override TextSpan<CultureSpecificCharacterBufferRange> GetPrecedingText(Int32 textSourceCharacterIndexLimit)
		{
			return new TextSpan<CultureSpecificCharacterBufferRange>(0, new CultureSpecificCharacterBufferRange(CultureInfo.CurrentUICulture, new CharacterBufferRange("", 0, 0)));
		}

		public override Int32 GetTextEffectCharacterIndexFromTextSourceCharacterIndex(Int32 textSourceCharacterIndex)
		{
			return 0;
		}

		public override TextRun GetTextRun(Int32 textSourceCharacterIndex)
		{
			return _normalizedSpanManager.GetTextRun(textSourceCharacterIndex);
		}

		public static Boolean IsBidiCharacter(Char c)
		{
			if (c < '֐')
			{
				return false;
			}
			if ((((c < '֐') || (c > 'ࣿ')) && ((c < '‏') || (c > '‮'))) && (c < 0xfb1d))
			{
				return false;
			}
			return true;
		}

		public Boolean LineContainsBiDi
		{
			get
			{
				return _normalizedSpanManager.ContainsBiDiCharacters;
			}
		}

		public IList<Int32> VirtualCharacterPositions
		{
			get
			{
				return _normalizedSpanManager.VirtualCharacterPositions;
			}
		}
	}
}
