using Lab3.Simulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lab3.Simulators.Interface;
using Lab3.Statistics;
using Lab3.Testers;
using Lab3.Utilities;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitStateArray();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            const int tactCount = 1000000;
            Simulator simulator = new Simulator(0.3, 0.5, StateArray, StateArray[0]);
            Tester tester = new Tester(simulator, tactCount);
            TestStateResult[] results = tester.RunTest();
            Stats stats = new Stats(StateArray, results);
            var statsResult = stats.GetFrequencyStats();
            resultTextBox.Text = "";
            for (int i = 0; i < StateArray.Length; i++)
            {
                resultTextBox.Text += $"{StateArray[i]}: {statsResult.FrequencyList[i]:0.00000}" + Environment.NewLine;
            }
            resultTextBox.Text += $"Относительная пропускная способность: {statsResult.RelativeBandwidth}" +
                                  Environment.NewLine;
            resultTextBox.Text += $"Абсолютная пропускная способность: {statsResult.AbsoluteBandwidth}" +
                                  Environment.NewLine;
            resultTextBox.Text += $"Средняя длина очереди: {statsResult.AverageBufferLength}" +
                                  Environment.NewLine;
            resultTextBox.Text += "------------------------------" + Environment.NewLine;
            resultTextBox.Text += "Funcs:" + Environment.NewLine;
            foreach (var str in CreateFuncs(statsResult))
            {
                resultTextBox.Text += str + Environment.NewLine;
            }
            
        }

        public SystemState[] StateArray;

        private List<string> CreateFuncs(StatsResult stats)
        {
            List<string> funcsList = new List<string>();
            foreach (var state in StateArray)
            {
                string func = "";
                string numFunc = "";
                double value = 0;
                foreach (var tempState in StateArray)
                {
                    foreach (var cond in tempState.JumpConditionArray)
                    {
                        if (cond.JumpState.Index == state.Index)
                        {
                            func = AttachCondToFunc(func, cond, tempState);
                            numFunc = AttachCondToNumFunc(numFunc, cond, stats.FrequencyList[tempState.Index - 1]);
                            value = CalcValue(value, cond, stats.FrequencyList[tempState.Index - 1]);
                        }
                    }
                }
                func = $"P{state.Index} = {func} = {numFunc} = {value:0.00000}";
                funcsList.Add(func);
            }
            return funcsList;
        }

        private string AttachCondToFunc(string str, JumpCondition cond, SystemState currState)
        {
            var builder = new StringBuilder(str);
            if (builder.Length != 0)
                builder.Append(" + ");
            if (cond.IsFirstAvailable.HasValue)
                builder.Append(cond.IsFirstAvailable.Value ? "q1" : "π1");
            if (cond.IsSecondAvailable.HasValue)
            {
                builder.Append(cond.IsFirstAvailable.HasValue ? "*" : "");
                builder.Append(cond.IsSecondAvailable.Value ? "q2" : "π2");
            }
            builder.Append("*P").Append(currState.Index);
            return builder.ToString();
        }

        private string AttachCondToNumFunc(string str, JumpCondition cond, double currStateValue)
        {
            var builder = new StringBuilder(str);
            if (builder.Length != 0)
                builder.Append(" + ");
            if (cond.IsFirstAvailable.HasValue)
                builder.Append(cond.IsFirstAvailable.Value ? "0.7" : "0.3");
            if (cond.IsSecondAvailable.HasValue)
            {
                builder.Append(cond.IsFirstAvailable.HasValue ? "*" : "");
                builder.Append("0.5");
            }
            builder.Append($"*{currStateValue:0.00000}");
            return builder.ToString();
        }

        private double CalcValue(double value, JumpCondition cond, double currStateValue)
        {
            double tempValue = 1.0;
            if (cond.IsFirstAvailable.HasValue)
                tempValue *= cond.IsFirstAvailable.Value ? 0.7 : 0.3;
            if (cond.IsSecondAvailable.HasValue)
            {
                tempValue *= 0.5;
            }
            tempValue *= currStateValue;
            return value + tempValue;
        }

        private void InitStateArray()
        {
            StateArray = new[]
            {
                new SystemState()
                {
                    Index = 1,
                    OrderState = 2,
                    FirstControllerState = 1,
                    BufferState = 0,
                    SecondControllerState = 0,
                },
                new SystemState()
                {
                    Index = 2,
                    OrderState = 1,
                    FirstControllerState = 1,
                    BufferState = 0,
                    SecondControllerState = 0,
                },
                new SystemState()
                {
                    Index = 3,
                    OrderState = 1,
                    FirstControllerState = 0,
                    BufferState = 0,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 4,
                    OrderState = 2,
                    FirstControllerState = 1,
                    BufferState = 0,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 5,
                    OrderState = 1,
                    FirstControllerState = 1,
                    BufferState = 0,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 6,
                    OrderState = 1,
                    FirstControllerState = 0,
                    BufferState = 1,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 7,
                    OrderState = 2,
                    FirstControllerState = 1,
                    BufferState = 1,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 8,
                    OrderState = 1,
                    FirstControllerState = 0,
                    BufferState = 2,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 9,
                    OrderState = 1,
                    FirstControllerState = 1,
                    BufferState = 1,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 10,
                    OrderState = 2,
                    FirstControllerState = 1,
                    BufferState = 2,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 11,
                    OrderState = 1,
                    FirstControllerState = 3,
                    BufferState = 2,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 12,
                    OrderState = 1,
                    FirstControllerState = 1,
                    BufferState = 2,
                    SecondControllerState = 1,
                },
                new SystemState()
                {
                    Index = 13,
                    OrderState = 2,
                    FirstControllerState = 3,
                    BufferState = 1,
                    SecondControllerState = 1,
                }
            };
            StateArray[0].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = null, JumpState = StateArray[1]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = null, JumpState = StateArray[2]},
            };
            StateArray[1].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = null, JumpState = StateArray[0]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = null, JumpState = StateArray[3]},
            };
            StateArray[2].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = false, JumpState = StateArray[3]},
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = true, JumpState = StateArray[0]},
            };
            StateArray[3].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = true, JumpState = StateArray[1]},
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = false, JumpState = StateArray[4]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = true, JumpState = StateArray[2]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = false, JumpState = StateArray[5]},
            };
            StateArray[4].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = true, JumpState = StateArray[0]},
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = false, JumpState = StateArray[3]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = true, JumpState = StateArray[3]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = false, JumpState = StateArray[6]},
            };
            StateArray[5].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = false, JumpState = StateArray[6]},
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = true, JumpState = StateArray[3]},
            };
            StateArray[6].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = true, JumpState = StateArray[4]},
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = false, JumpState = StateArray[8]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = true, JumpState = StateArray[5]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = false, JumpState = StateArray[7]},

            };
            StateArray[7].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = false, JumpState = StateArray[9]},
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = true, JumpState = StateArray[6]},
            };
            StateArray[8].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = true, JumpState = StateArray[3]},
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = false, JumpState = StateArray[6]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = true, JumpState = StateArray[6]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = false, JumpState = StateArray[9]},
            };
            StateArray[9].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = true, JumpState = StateArray[8]},
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = false, JumpState = StateArray[11]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = true, JumpState = StateArray[7]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = false, JumpState = StateArray[10]},

            };
            StateArray[10].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = false, JumpState = StateArray[12]},
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = true, JumpState = StateArray[9]},
            };
            StateArray[11].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = true, JumpState = StateArray[6]},
                new JumpCondition() {IsFirstAvailable = false, IsSecondAvailable = false, JumpState = StateArray[9]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = true, JumpState = StateArray[9]},
                new JumpCondition() {IsFirstAvailable = true, IsSecondAvailable = false, JumpState = StateArray[12]},
            };
            StateArray[12].JumpConditionArray = new[]
            {
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = false, JumpState = StateArray[10]},
                new JumpCondition() {IsFirstAvailable = null, IsSecondAvailable = true, JumpState = StateArray[7]},
            };
        }
    }
}
