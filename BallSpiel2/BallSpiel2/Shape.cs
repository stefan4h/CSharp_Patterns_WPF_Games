using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BallSpiel2
{
    abstract class Form
    {
        protected Shape s;
        protected bool boolSelected = false;
        private bool boolMoving = false;
        bool GoingRight = true;
        bool GoingDown = true;
        SolidColorBrush color = Brushes.Red;
        int speed = 1;
        
        public bool BoolMoving
        {
            get
            {
                return boolMoving;
            }

            set
            {
                boolMoving = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        internal SolidColorBrush Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Shape IsSelected()
        {
            s.StrokeThickness = 5;
            boolSelected = true;
            return s;
        }
        public Shape IsNotSelected()
        {
            s.StrokeThickness = 1;
            boolSelected = false;
            return s;
        }
        public double MoveObjectLeftRight(Canvas canvas,Shape shape)
        {
            s = shape;
            double x = Canvas.GetLeft(s);
            if (GoingRight)
                x += Speed;
            else
                x -= Speed;

            if (x + s.Width > canvas.ActualWidth)
            {
                GoingRight = false;
                x = canvas.ActualWidth - s.Width;
            }
            else if (x < 0.0)
            {
                GoingRight = true;
                x = 0.0;
            }
            return x;
        }
        public double MoveObjectUpDown(Canvas canvas, Shape shape)
        {
            s = shape;
            double y = Canvas.GetTop(s);
            if (GoingDown)
                y += Speed;
            else
                y -= Speed;

            if (y + s.Height > canvas.ActualHeight)
            {
                GoingDown = false;
                y = canvas.ActualHeight - s.Height;
            }
            else if (y < 0.0)
            {
                GoingDown = true;
                y = 0.0;
            }
            return y;
        }
        public void ChangeSpeed(int value)
        {
            speed = value;
        }
        public string GetStringForm()
        {
            return this.GetType().ToString().Split('.')[1].Substring(1);
        }
    }
}
