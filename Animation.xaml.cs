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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DoubleAnimation _animation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            myHyperLink.TextDecorations = TextDecorations.Underline;
            HyperLink.TextDecorations = TextDecorations.Underline;
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            myHyperLink.TextDecorations = null;
            HyperLink.TextDecorations = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _animation = new DoubleAnimation();
            _animation.Completed += afterComplete;
            _animation.From = 200;
            _animation.To = 400;
            _animation.Duration = TimeSpan.FromSeconds(5);
            _animation.AutoReverse = true;
            _animation.FillBehavior = FillBehavior.HoldEnd;
            _animation.AccelerationRatio = 0.5;
            btnAnimation.BeginAnimation(Button.WidthProperty, _animation);
        }

        private void afterComplete(object sender, EventArgs e)
        {
            btnAnimation.BeginAnimation(Button.WidthProperty, null);
            btnAnimation.Width = 600;
        }
    }
}
