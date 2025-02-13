/* -----------------------------------------------
 * NuGenToolTipInfoEditorUI.cs
 * Copyright � 2007 Anthony Nystrom
 * mailto:a.nystrom@genetibase.com
 * --------------------------------------------- */

using Genetibase.Shared.ComponentModel;
using Genetibase.Shared.Controls.Design.Properties;
using Genetibase.Shared.Controls.ToolTipInternals;
using Genetibase.Shared.Design;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Genetibase.Shared.Controls.Design
{
	/// <summary>
	/// </summary>
	[System.ComponentModel.DesignerCategory("Code")]
	internal sealed partial class NuGenToolTipInfoEditorUI : Form
	{
		#region Declarations.Fields

		private DialogFlowLayoutPanel _dialogLayoutPanel;
		private MainBlock _mainBlock;
		private RemarksBlock _remarksBlock;
		private SizeBlock _sizeBlock;
		private Button _okButton;
		private Button _cancelButton;
		private Button _previewButton;
		private NuGenToolTip _tooltip;

		#endregion

		#region Methods.Public

		public NuGenToolTipInfo GetTooltipInfoFromState()
		{
			return new NuGenToolTipInfo(
				_mainBlock.Header,
				_mainBlock.Image,
				_mainBlock.Text,
				_remarksBlock.RemarksHeader,
				_remarksBlock.RemarksImage,
				_remarksBlock.Remarks,
				_sizeBlock.CustomSize
			);
		}

		public void SetStateFromTooltipInfo(NuGenToolTipInfo tooltipInfo)
		{
			if (tooltipInfo != null)
			{
				_mainBlock.Header = tooltipInfo.Header;
				_mainBlock.Image = tooltipInfo.Image;
				_mainBlock.Text = tooltipInfo.Text;

				_remarksBlock.RemarksHeader = tooltipInfo.RemarksHeader;
				_remarksBlock.RemarksImage = tooltipInfo.RemarksImage;
				_remarksBlock.Remarks = tooltipInfo.Remarks;

				_sizeBlock.CustomSize = tooltipInfo.CustomSize;
			}
		}

		#endregion

		#region EventHandlers.DialogButtons

		private void _previewButton_MouseEnter(object sender, EventArgs e)
		{
			_tooltip.Show(_previewButton, this.GetTooltipInfoFromState());
		}

		private void _previewButton_MouseLeave(object sender, EventArgs e)
		{
			_tooltip.Hide();
		}

		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="NuGenToolTipInfoEditorUI"/> class.
		/// </summary>
		/// <param name="serviceContext"></param>
		/// <param name="serviceProvider">
		/// <para>Requires:</para>
		/// <para><see cref="INuGenToolTipLayoutManager"/></para>
		/// <para><see cref="INuGenToolTipRenderer"/></para>
		/// </param>
		/// <param name="initialTooltipInfo"></param>
		/// <exception cref="ArgumentNullException">
		/// <para>
		///		<paramref name="serviceProvider"/> is <see langword="null"/>.
		/// </para>
		/// -or-
		/// <para>
		///		<paramref name="serviceContext"/> is <see langword="null"/>.
		/// </para>
		/// </exception>
		public NuGenToolTipInfoEditorUI(
			INuGenServiceProvider serviceProvider,
			NuGenToolTipInfo initialTooltipInfo,
			NuGenCustomTypeEditorServiceContext serviceContext
			)
		{
			if (serviceProvider == null)
			{
				throw new ArgumentNullException("serviceProvider");
			}

			if (serviceContext == null)
			{
				throw new ArgumentNullException("serviceContext");
			}

			this.SuspendLayout();

			_tooltip = new NuGenToolTip(serviceProvider);

			_mainBlock = new MainBlock(serviceContext);
			_mainBlock.Parent = this;

			_remarksBlock = new RemarksBlock(serviceContext);
			_remarksBlock.Height = 100;
			_remarksBlock.Parent = this;

			_previewButton = new Button();
			_previewButton.TabStop = false;
			_previewButton.Text = Resources.Text_ToolTipInfoEditor_previewButton;
			_previewButton.MouseEnter += _previewButton_MouseEnter;
			_previewButton.MouseLeave += _previewButton_MouseLeave;

			_okButton = new Button();
			_okButton.DialogResult = DialogResult.OK;
			_okButton.TabIndex = 0;
			_okButton.Text = Resources.Text_ToolTipInfoEditor_okButton;

			_cancelButton = new Button();
			_cancelButton.DialogResult = DialogResult.Cancel;
			_cancelButton.TabIndex = 1;
			_cancelButton.Text = Resources.Text_ToolTipInfoEditor_cancelButton;

			_sizeBlock = new SizeBlock();
			_sizeBlock.Parent = this;

			_dialogLayoutPanel = new DialogFlowLayoutPanel();
			_dialogLayoutPanel.Controls.Add(_cancelButton);
			_dialogLayoutPanel.Controls.Add(_okButton);
			_dialogLayoutPanel.Controls.Add(_previewButton);
			_dialogLayoutPanel.Parent = this;

			this.CancelButton = _cancelButton;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Padding = new Padding(3);
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Size = new Size(350, 400);
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = Resources.Text_ToolTipInfoEditor_EditorForm;
			
			this.SetStateFromTooltipInfo(initialTooltipInfo);
			this.ResumeLayout(false);
		}
	}
}
