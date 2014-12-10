using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter1_Wizard
{
	public class WizardController
	{

		//当前步骤序号
		private static int _currentIndex = 0;
		//用于保存所有的步骤窗体
		private List<CommonForm> _steps;

		/// <summary>
		/// 当前步骤序号
		/// </summary>
		public int CurrentIndex
		{
			get { return _currentIndex; }
		}

		/// <summary>
		/// 步骤总数
		/// </summary>
		public int StepCount
		{
			get { return _steps.Count; }
		}
		/// <summary>
		/// 构造函数
		/// </summary>
		public WizardController(List<CommonForm> steps)
		{
			_steps = steps;
		}

		/// <summary>
		/// 添加一个新的步骤到末尾
		/// </summary>
		/// <param name="step">新的步骤</param>
		public void AddStep(CommonForm step)
		{

		}

		/// <summary>
		/// 在指定位置插入一个新的步骤
		/// </summary>
		/// <param name="index">要插入的位置</param>
		/// <param name="step">要插入的步骤</param>
		public void InsertStep(int index, CommonForm step)
		{
			_steps.Insert(index, step);
		}

		/// <summary>
		/// 删除指定位置的步骤
		/// </summary>
		/// <param name="index"></param>
		public void RemoveStepAt(int index)
		{
			_steps.RemoveAt(index);
		}

		/// <summary>
		/// 删除指定的步骤
		/// </summary>
		/// <param name="step">要删除的步骤</param>
		public void RemoveStep(CommonForm step)
		{
			_steps.Remove(step);
		}

		/// <summary>
		/// 交换两个步骤
		/// </summary>
		/// <param name="step">要交换的其中一个步骤</param>
		/// <param name="anotherStep">要交换的其中另一个步骤</param>
		public void SwapStep(CommonForm step, CommonForm anotherStep)
		{
			CommonForm temp = step;

			step = anotherStep;
			anotherStep = temp;
		}

		/// <summary>
		/// 交换两个步骤（参数为步骤的序号）
		/// </summary>
		/// <param name="index">其中一个步骤的序号</param>
		/// <param name="anotherIndex">另一个步骤的序号</param>
		public void SwapStep(int index, int anotherIndex)
		{
			CommonForm temp = _steps[index];

			_steps[index] = _steps[anotherIndex];
			_steps[anotherIndex] = temp;
		}

		/// <summary>
		/// 跳转到下一个步骤
		/// </summary>
		public void GoNextStep()
		{
			_steps[_currentIndex].Hide();
			_steps[++_currentIndex].Show();
		}

		/// <summary>
		/// 跳转到上一个步骤
		/// </summary>
		public void GoPreviousStep()
		{
			_steps[_currentIndex].Hide();
			_steps[--_currentIndex].Show();

		}

		/// <summary>
		/// 取消
		/// </summary>
		public void Cancel()
		{
			_steps[_currentIndex].Close();
		}

		/// <summary>
		/// 完成
		/// </summary>
		public void Finish()
		{
			_steps[_currentIndex].Hide();
		}

		/// <summary>
		/// 显示第一个步骤
		/// </summary>
		public void ShowFirstStep()
		{
			_steps[0].Show();
		}

		/// <summary>
		/// 显示最后一个步骤
		/// </summary>
		public void ShowLastStep()
		{
			_steps[_currentIndex].Hide();
			_steps[_steps.Count - 1].Show();
		}

	}
}
