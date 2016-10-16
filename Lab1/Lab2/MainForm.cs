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
using Lab1.Generator.Interface;
using Lab2.Generator;
using Lab2.SequenceModel;

namespace Lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private IGenerator<double> randomGenerator = new LemerGenerator(100000031, 1000000011, 10101017);
        private const int SequenceLength = 1000000;

        private void ShowValues(Sequence sequence, double? minValue, double? maxValue)
        {
            var drawer = new HinstogramDrawer();
            pictureBox.Image = drawer.DrawHistogram(pictureBox.Size, sequence.Values, 20, minValue, maxValue);
            resultTextBox.Text = $"Мат. ожидание = {sequence.ExpectedValue:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Дисперсия = {sequence.Dispersion:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Среднее кв. отклонение = {sequence.StandartDeviation:0.00000}" + Environment.NewLine;
        }

        private void uniformMagicButton_Click(object sender, EventArgs e)
        {
            var A = (double) uniformANumericUpDown.Value;
            var B = (double) uniformBNumericUpDown.Value;
            var generator = new UniformGenerator(randomGenerator, A, B);
            var sequence = new Sequence(generator, SequenceLength);
            ShowValues(sequence, A, B);
        }

        private void gaussMagicButton_Click(object sender, EventArgs e)
        {
            var M = (double)gaussMNumericUpDown.Value;
            var Q = (double)gaussQNumericUpDown.Value;
            var generator = new GaussGenerator(randomGenerator, M, Q);
            var sequence = new Sequence(generator, SequenceLength);
            ShowValues(sequence, null, null);
        }

        private void expMagicButton_Click(object sender, EventArgs e)
        {
            var L = (double) expLnumericUpDown.Value;
            var generator = new ExponentialGenerator(randomGenerator, L);
            var sequence = new Sequence(generator, SequenceLength);
            ShowValues(sequence, null, null);
        }

        private void gammaMagicButton_Click(object sender, EventArgs e)
        {
            var N = (int)gammaNNumericUpDown.Value;
            var L = (double)gammaLNumericUpDown.Value;
            var generator = new GammaGenerator(randomGenerator, L, N);
            var sequence = new Sequence(generator, SequenceLength);
            ShowValues(sequence, null, null);
        }

        private void trinagleMagicButton_Click(object sender, EventArgs e)
        {
            var A = (double)triangleANumericUpDown.Value;
            var B = (double)triangleBNumericUpDown.Value;
            var generator = triangleMinRadioButton.Checked
                ? new TriangleGenerator(randomGenerator, A, B, true)
                : new TriangleGenerator(randomGenerator, A, B, false);
            var sequence = new Sequence(generator, SequenceLength);
            ShowValues(sequence, A, B);
        }

        private void simpsonMagicbutton_Click(object sender, EventArgs e)
        {
            var A = (double)simpsonANumericUpDown.Value;
            var B = (double)simpsonBNumericUpDown.Value;
            var generator = new SimpsonGenerator(randomGenerator, A, B);
            var sequence = new Sequence(generator, SequenceLength);
            ShowValues(sequence, A, B);
        }
    }
}
