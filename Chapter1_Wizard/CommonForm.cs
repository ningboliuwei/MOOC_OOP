using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1_Wizard
{
	public partial class CommonForm : Form
	{
		private static WizardController _controller;

		public CommonForm()
		{
			InitializeComponent();
		}

		public CommonForm(WizardController controller)
		{
			InitializeComponent();
			_controller = controller;
		}

		private void btnPrevious_Click(object sender, EventArgs e)
		{
			
			_controller.GoPreviousStep();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			_controller.GoNextStep();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			_controller.Cancel();
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			_controller.Finish();
		}

		private void CommonForm_Load(object sender, EventArgs e)
		{
			_controller.ShowFirstStep();
			ValidateButtons();
			
		}

		/// <summary>
		/// 设置各按钮的可用性
		/// </summary>
		private void ValidateButtons()
		{
			if (_controller.CurrentIndex == 0)
			{
				btnPrevious.Enabled = false;
			}
			else
			{
				btnPrevious.Enabled = true;
			}

			if (_controller.CurrentIndex == _controller.StepCount - 1)
			{
				btnNext.Enabled = false;
			}
			else
			{
				btnNext.Enabled = true;
			}
		}
	}
}
