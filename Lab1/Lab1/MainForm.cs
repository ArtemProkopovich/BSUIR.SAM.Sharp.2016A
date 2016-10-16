using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Drawing;
using Lab1.Generator;
using Lab1.Model;

namespace Lab1
{
    public partial class MainForm : Form
    {
        private readonly LemerGeneratorInitialModel model = new LemerGeneratorInitialModel();
        private LemerGenerator generator;
        private const int Length = 1000000;
        private const int RowCount = 20;
        public MainForm()
        {
            InitializeComponent();
            UpdateView();
        }

        private void magicButton_Click(object sender, EventArgs e)
        {
            generator = new LemerGenerator(model.ParamA.Value, model.ParamM.Value, model.ParamR0.Value);
            LemerSequenceModel sequence = new LemerSequenceModel(generator, Length);
            pictureBox.Image = new HinstogramDrawer().DrawHistogram(new Size(pictureBox.Width, pictureBox.Height),
                sequence.Array, RowCount, 0, 1);
            ShowResult(sequence);
        }

        private void ShowResult(LemerSequenceModel sequence)
        {
            resultTextBox.Text = $"Мат. ожидание = {sequence.ExpectedValue:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Дисперсия = {sequence.Dispersion:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Среднее кв. отклонение = {sequence.StandardDeviation:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Длина периода = {sequence.PeriodLength}" + Environment.NewLine;
            resultTextBox.Text += $"Длина апериодичности = {sequence.AperiodicLength}" + Environment.NewLine;
        }

        private void paramATextBox_TextChanged(object sender, EventArgs e)
        {
            long result;
            if (long.TryParse(paramATextBox.Text, out result))
                model.ParamA = result;
            else
                model.ParamA = null;
            UpdateView();
        }

        private void paramMTextBox_TextChanged(object sender, EventArgs e)
      {
            long result;
            if (long.TryParse(paramMTextBox.Text, out result))
                model.ParamM = result;
            else
                model.ParamM = null;
            UpdateView();
        }

        private void paramRTextBox_TextChanged(object sender, EventArgs e)
        {
            long result;
            if (long.TryParse(paramRTextBox.Text, out result))
                model.ParamR0 = result;
            else
                model.ParamR0 = null;
            UpdateView();
        }


        private void UpdateView()
        {
            if (model.IsValid)
            {
                magicButton.Enabled = true;
                magicButton.BackColor = model.IsRecomended ? Color.Green : Color.Yellow;
            }
            else
            {
                magicButton.BackColor = Color.Red;
                magicButton.Enabled = false;
            }
            paramAErrorLabel.ForeColor = model.ParamAState.State == View.ModelState.Good
                ? Color.Green
                : model.ParamAState.State == View.ModelState.Warning ? Color.YellowGreen : Color.Red;
            paramMErrorLabel.ForeColor = model.ParamMState.State == View.ModelState.Good
                ? Color.Green
                : model.ParamMState.State == View.ModelState.Warning ? Color.YellowGreen : Color.Red;
            paramR0ErrorLabel.ForeColor = model.ParamR0State.State == View.ModelState.Good
                ? Color.Green
                : model.ParamR0State.State == View.ModelState.Warning ? Color.YellowGreen : Color.Red;
            paramAErrorLabel.Text = model.ParamAState.Text;
            paramMErrorLabel.Text = model.ParamMState.Text;
            paramR0ErrorLabel.Text = model.ParamR0State.Text;
        }
    }
}
