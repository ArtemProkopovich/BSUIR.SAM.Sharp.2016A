using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Drawing
{
    public class HinstogramDrawer
    {
        private static Random random = new Random();
        public HinstogramDrawer()
        {
        }

        public Image DrawHistogram(Size size, double[] values, int rowCount, double? minValue, double? maxValue)
        {
            minValue = minValue ?? values.Min();
            maxValue = maxValue ?? values.Max();
            var grams = CountHistogramValues(values, rowCount, minValue.Value, maxValue.Value);
            var bmp = new Bitmap(size.Width, size.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Font font = new Font(FontFamily.GenericMonospace, 6);

            graph.FillRectangle(Brushes.White, 0, 0, size.Width, size.Height);

            graph.DrawLine(Pens.Black, 0, size.Height - 21, size.Width - 5, size.Height - 21);
            graph.DrawLine(Pens.Black, 22, size.Height, 22, 0);


            graph.DrawString($"0/{minValue:0.00}", font, Brushes.Black,
                new RectangleF(1, size.Height - 21, 20, size.Height));
            var axeXValueStep = (maxValue - minValue)/rowCount;
            var axeXPixelStep = (float) (size.Width - 25)/rowCount;
            for (int i = 1; i < rowCount + 1; i++)
            {
                var value = i*axeXValueStep + minValue;
                graph.DrawString($"{value:0.00}", font, Brushes.Black,
                    i*axeXPixelStep,
                    size.Height - 15);
                graph.DrawLine(Pens.Black, i*axeXPixelStep + 21, size.Height - 23,
                    i*axeXPixelStep + 21, size.Height - 19);
            }

            var axeYValueStep = Math.Max(grams.Average()*1.5, grams.Max())*2/rowCount;
            var axeYPixelStep = (float) (size.Height - 20)/rowCount;
            for (int i = 0; i < rowCount; i++)
            {
                double value = axeYValueStep*(rowCount - i);
                graph.DrawString($"{value:0.000}", font,
                    Brushes.Black, 0, i*axeYPixelStep);
                graph.DrawLine(Pens.Black, 20, i*axeYPixelStep, 24, i*axeYPixelStep);
            }

            for (int i = 0; i < rowCount; i++)
            {
                float width = axeXPixelStep - 3;
                float height = (float) (grams[i]*axeYPixelStep/axeYValueStep);
                float pointX = axeXPixelStep*i + 24;
                pointX = i > 0 ? pointX - 2 : pointX;
                float pointY = size.Height - 22 - height;
                graph.FillRectangle(
                    new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255))),
                    new RectangleF(pointX, pointY, width, height));
            }

            graph.Save();
            return bmp;
        }

        private double[] CountHistogramValues(double[] values, int rowCount, double minValue, double maxValue)
        {
            double approx = 0.000001;
            var step = (maxValue - minValue)/rowCount;
            var result = new double[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                result[i] =
                    values.Count(e => e >= (minValue + i*step - approx) && e < (minValue + (i + 1)*step - approx))/
                    (double) values.Length;
            }
            return result;
        }
    }
}
