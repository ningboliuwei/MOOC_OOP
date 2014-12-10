using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1_Wizard
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			List<CommonForm> steps = new List<CommonForm>(){new Step1(), new Step2(), new Step3(), new Step4(), new Step5()};
			WizardController controller = new WizardController(steps);
			Application.Run(new CommonForm(controller));
		}
	}
}
