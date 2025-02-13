using System;
using System.Drawing;
using System.ComponentModel;
using Netron.Neon.WinFormsUI;
namespace Netron.Neon.WinFormsUI.Netron
{
	[ToolboxItem(false)]
	internal class DockPaneTabFromBase : DockPaneTab
	{
		internal DockPaneTabFromBase(IDockContent content) : base(content)
		{
		}

		private int m_tabX;
		protected internal int TabX
		{
			get	{	return m_tabX;	}
			set	{	m_tabX = value;	}
		}

		private int m_tabWidth;
		protected internal int TabWidth
		{
			get	{	return m_tabWidth;	}
			set	{	m_tabWidth = value;	}
		}

		private int m_maxWidth;
		protected internal int MaxWidth
		{
			get	{	return m_maxWidth;	}
			set	{	m_maxWidth = value;	}
		}

		private bool m_flag;
		protected internal bool Flag
		{
			get	{	return m_flag;	}
			set	{	m_flag = value;	}
		}

		
	}
}
