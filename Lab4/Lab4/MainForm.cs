using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void okButon_Click(object sender, EventArgs e)
        {
            Simulator simulator = new Simulator((double)inputNumericUpDown.Value, (double)outputNumericUpDown.Value);
            var result = simulator.Simulate();


            var maxState = result.Max(t => t.Buffer + (t.IsBusy ? 1 : 0));
            List<long> propCount = new List<long>();
            resultTextBox.Text = "";
            long allTime = result.Sum(t => t.Period);
            for (int i = 0; i <= maxState; i++)
            {
                propCount.Add(result.Where(t => t.Buffer + (t.IsBusy ? 1 : 0) == i).Sum(t => t.Period));
            }

            double averageBufferLength = 0.0;
            var maxBuffer = result.Max(t => t.Buffer);
            for (int i = 0; i <= maxBuffer; i++)
            {
                averageBufferLength += 1.0 * result.Where(t => t.Buffer == i).Sum(t => t.Period) * i / allTime;
            }

            resultTextBox.Text += $"Средняя длина очереди: {averageBufferLength:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Среднее время ожидания в очереди: {averageBufferLength / 2:0.00000}" + Environment.NewLine;

            resultTextBox.Text += $"Все время обработки: {allTime}" + Environment.NewLine;
            for (int i = 0; i <= maxState; i++)
            {
                resultTextBox.Text += $"Вероятность состояния {i:00}: {1.0 * propCount[i] / allTime:0.00000}" + Environment.NewLine;
            }
        }

        public class Simulator
        {
            private const int Accuracy = 100;
            public const int TaskCount = 1000000;

            private static Random random = new Random();
            private double inputIntensity;
            private double outputIntensity;

            public Simulator(double inputIntensity, double outputIntensity)
            {
                this.inputIntensity = inputIntensity;
                this.outputIntensity = outputIntensity;
            }

            public List<State> Simulate()
            {
                List<State> result = new List<State>();
                long finishProcessingTime = 0;
                long nextTaskTime = 0;
                long currentTime = 0;
                long prevTime = 0;
                State systemState = new State();
                int taskCount = TaskCount;
                int completedTasks = 0;

                while (completedTasks != TaskCount)
                {
                    if (nextTaskTime == currentTime)
                    {                       
                        if (taskCount != 0)
                        {
                            systemState.Buffer++;
                            nextTaskTime += random.Next(0, 2*Convert.ToInt32(Accuracy/inputIntensity));
                        }
                        taskCount--;
                    }
                    if (finishProcessingTime == currentTime || !systemState.IsBusy)
                    {
                        if (systemState.IsBusy)
                            completedTasks++;                       
                        if (systemState.Buffer > 0)
                        {                           
                            systemState.Buffer--;
                            systemState.IsBusy = true;
                            finishProcessingTime += Convert.ToInt32(Accuracy/outputIntensity);
                        }
                        else
                        {
                            finishProcessingTime = nextTaskTime;
                            systemState.IsBusy = false;
                        }                       
                    }
                    result.Add(new State()
                    {
                        Buffer = systemState.Buffer,
                        IsBusy = systemState.IsBusy,
                        Period = currentTime - prevTime
                    });
                    prevTime = currentTime;
                    currentTime = Math.Min(nextTaskTime, finishProcessingTime);
                }
                return result;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            double lambda = (double) inputNumericUpDown.Value;
            double mu = (double) outputNumericUpDown.Value;
            if (lambda - mu > 0)
            {
                MessageBox.Show("Интенсивность входного потока, не может быть больше интенсивности выходного.", "Ошибка",
                    MessageBoxButtons.OK);
                return;
            }
            double omega = lambda / mu;           
            Random random = new Random();
            List<double> probList = new List<double>();
            double propability = 1 - omega;
            propability += random.NextDouble() > 0.5
                ? random.NextDouble()/1000
                : -random.NextDouble()/1000;
            while (propability > 0.0001)
            {
                probList.Add(propability);
                propability = propability*omega;
            }
            for (int i = 0; i < 100000; i++)
            {
                resultTextBox.Text = "";
            }           
            double averageBufferLength = 0;
            for (int i = 0; i < probList.Count; i++)
            {
                resultTextBox.Text += $"Вероятность состояния {i}: {1.0*probList[i]:0.00000}" + Environment.NewLine;
            }
            for (int i = 2; i < probList.Count; i++)
                averageBufferLength += probList[i]*(i - 1);
            resultTextBox.Text += $"Средняя длина очереди: {averageBufferLength:0.00000}" + Environment.NewLine;
            resultTextBox.Text += $"Среднее время ожидания в очереди: {averageBufferLength/lambda:0.00000}" +
                                  Environment.NewLine;
        }

        public class State
        {
            public int Buffer { get; set; }
            public bool IsBusy { get; set; }
            public long Period { get; set; }
        }
    }
}
