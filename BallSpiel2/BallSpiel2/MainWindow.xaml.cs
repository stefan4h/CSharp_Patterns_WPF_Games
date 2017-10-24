using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BallSpiel2
{
   
    public partial class MainWindow : Window
    {
        static int score;
        Form SelectedForm;
        Form FlyRectangle, FlyTriangle, FlyEllipse;
        DispatcherTimer timer;
        public MainWindow()
        {        
            InitializeComponent();
            MessageBox.Show("Formen werden mit Rechtsklick ausgewählt, mit Linksklick werden Punkte erzielt");
            FlyTriangle = new FTriangle(Triangle);
            FlyRectangle = new FRectangle(Rectangle);
            FlyEllipse = new FEllipse(Ball);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.05);
            timer.Start();
            RenderOptions.SetBitmapScalingMode(Ball, VisualBitmapScalingMode);
            RenderOptions.SetBitmapScalingMode(Rectangle, VisualBitmapScalingMode);
            RenderOptions.SetBitmapScalingMode(Triangle, VisualBitmapScalingMode);
        }

        private void btn_Start_Stop_Click(object sender, RoutedEventArgs e)
        {
            StartStopMoving(new ViewMoving(btn_Start_Stop.Content.ToString(),SelectedForm));
        }

        private void StartStopMoving(ViewMoving m)
        {
            btn_Start_Stop.Content = m.ContentButton;

            if (m.MoveObject(FlyRectangle))
                timer.Tick += MoveRectangle;
            else if(m.Selected(FlyRectangle))
                timer.Tick -= MoveRectangle;
            if (m.MoveObject(FlyEllipse))
                timer.Tick += MoveEllipse;
            else if (m.Selected(FlyEllipse))
                timer.Tick -= MoveEllipse;
            if (m.MoveObject(FlyTriangle))
                timer.Tick += MoveTriangle;
            else if (m.Selected(FlyTriangle))
                timer.Tick -= MoveTriangle;

            SelectedForm = m.SelectedForm;
            FlyRectangle.BoolMoving = m.GetBoolObjectMoving(FlyRectangle);
            FlyEllipse.BoolMoving = m.GetBoolObjectMoving(FlyEllipse);
            FlyTriangle.BoolMoving = m.GetBoolObjectMoving(FlyTriangle);
        }

        private void LoadContentButtonStartStop(ViewMoving m)
        {
            btn_Start_Stop.Content = m.ContentButton;
        }

        private void Score(object sender, MouseButtonEventArgs e)
        {
            score++;
            lbl_Score_Count.Content = score.ToString();
        }

        private void Selected(object sender, MouseButtonEventArgs e)
        {
            MakeEverythingVisible();
            SelectNone();
            switch (sender.GetType().FullName)
            {
                case "System.Windows.Shapes.Rectangle":
                    SelectedForm = FlyRectangle;
                    SelectedForm.BoolMoving = FlyRectangle.BoolMoving;
                    break;
                case "System.Windows.Shapes.Ellipse":
                    SelectedForm = FlyEllipse;
                    SelectedForm.BoolMoving = FlyEllipse.BoolMoving;
                    break;
                case "System.Windows.Shapes.Polygon":
                    SelectedForm = FlyTriangle;
                    SelectedForm.BoolMoving = FlyTriangle.BoolMoving;
                    break;
                default:
                    SelectNone();
                    break;
            }
            SelectedForm.IsSelected();
            CheckWhichFormIsSelected();
            LoadContentButtonStartStop(new ViewMoving(SelectedForm));
            ChangePositionSlider();
            SelectRightCheckBox();
        }

        private void SelectNone()
        {
            if(SelectedForm!=null)
            SelectedForm.IsNotSelected();
        }
        private void SelectRightCheckBox()
        {
            if (SelectedForm.Color == Brushes.Red)
                rbt_Red.IsChecked = true;
            if (SelectedForm.Color == Brushes.Green)
                rbt_Green.IsChecked = true;
            if (SelectedForm.Color == Brushes.Blue)
                rbt_Blue.IsChecked = true;
        }

        private void CheckWhichFormIsSelected()
        {
            lbl_Selected_Form.Content = SelectedForm.GetStringForm();
        }
        private void MakeEverythingVisible()
        {
            btn_Start_Stop.Visibility = Visibility.Visible;
            lbl_Selected.Visibility = Visibility.Visible;
            lbl_Selected_Form.Visibility = Visibility.Visible;
            SpeedSlider.Visibility = Visibility.Visible;
            rbt_Red.Visibility = Visibility.Visible;
            rbt_Green.Visibility = Visibility.Visible;
            rbt_Blue.Visibility = Visibility.Visible;
        }
        private void MoveRectangle(object sender, EventArgs e)
        {
                    Canvas.SetLeft(Rectangle, FlyRectangle.MoveObjectLeftRight(my_Canvas, Rectangle));
                    Canvas.SetTop(Rectangle, FlyRectangle.MoveObjectUpDown(my_Canvas, Rectangle));
        }
        private void MoveEllipse(object sender, EventArgs e)
        {
            Canvas.SetLeft(Ball, FlyEllipse.MoveObjectLeftRight(my_Canvas, Ball));
            Canvas.SetTop(Ball, FlyEllipse.MoveObjectUpDown(my_Canvas, Ball));
        }
        private void MoveTriangle(object sender, EventArgs e)
        {
            Canvas.SetLeft(Triangle, FlyTriangle.MoveObjectLeftRight(my_Canvas, Triangle));
            Canvas.SetTop(Triangle, FlyTriangle.MoveObjectUpDown(my_Canvas, Triangle));
        }

        private void rbt_Red_Checked(object sender, RoutedEventArgs e)
        {
            if(SelectedForm!=null)
            ChangeColor(Brushes.Red);
        }
        private void rbt_Blue_Checked(object sender, RoutedEventArgs e)
        {
            if (SelectedForm != null)
                ChangeColor(Brushes.Blue);
        }

        private void rbt_Green_Checked(object sender, RoutedEventArgs e)
        {
            if (SelectedForm != null)
                ChangeColor(Brushes.Green);
        }
        private void ChangeColor(System.Windows.Media.SolidColorBrush color)
        {
            ViewColor c = new ViewColor(SelectedForm, color);
            if (c.Selected(FlyEllipse))
                Ball.Fill = color;
            if (c.Selected(FlyRectangle))
                Rectangle.Fill = color;
            if (c.Selected(FlyTriangle))
                Triangle.Fill = color;

            FlyEllipse.Color = c.SetColor(FlyEllipse);
            FlyRectangle.Color = c.SetColor(FlyRectangle);
            FlyTriangle.Color = c.SetColor(FlyTriangle);
        }

        private void ChangeSpeed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(SelectedForm!=null)
            SelectedForm.ChangeSpeed(Convert.ToInt32(SpeedSlider.Value));
        }
        public void ChangePositionSlider()
        {
                SpeedSlider.Value = SelectedForm.Speed;
        }

    }

}
