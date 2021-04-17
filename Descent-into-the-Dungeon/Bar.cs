using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Menu
{
    class Bar : Control
    {
        public Bar ()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            MaxValue = 100;
            MinValue = 0;
            Value = 0;
            Step = 10;
        }
        private int step;
        public int Step
        {
            get { return step; }
            set { step = value; }
        }

        private int minValue;
        public int MinValue
        {
            get { return minValue; }
            set
            {
                if (value < maxValue)
                    minValue = value;
            }
        }

        private int maxValue;
        public int MaxValue
        {
            get { return maxValue; }
            set
            {
                if (value > minValue)
                    maxValue = value;
            }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value >= minValue && value <= maxValue)
                    _value = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, Width, Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), 0, 0, (int)(Width*(Value/(MaxValue*1f))), Height);
            base.OnPaint(e);
        }
        public void PerformStep()
        {
            Value += Step;
            Refresh();
        }
    }
}
