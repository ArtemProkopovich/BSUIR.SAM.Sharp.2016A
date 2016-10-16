using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.View
{
    public enum ModelState
    {
        Good,
        Warning,
        Error
    }

    public class ErrorState
    {
        public string Text { get; set; }
        public ModelState State { get; set; } 

        public void SetError(string text)
        {
            State = ModelState.Error;
            Text = text;
        }

        public void SetWarning(string text)
        {
            State = ModelState.Warning;
            Text = text;
        }

        public void SetProper(string text)
        {
            State = ModelState.Good;
            Text = text;
        }
    }
}
