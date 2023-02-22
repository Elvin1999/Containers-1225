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

namespace Lesson2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        /// <summary>
        /// Canvas
        /// StackPanel
        /// WrapPanel
        /// DockPanel
        /// UniFormgrid
        /// Grid
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            //_timer = new DispatcherTimer();
            //_timer.Interval = TimeSpan.FromMilliseconds(10);
            //_timer.Tick += _timer_Tick;
            //_timer.Start();
        }
        private int _myAngle = 0;
        private void _timer_Tick(object sender, EventArgs e)
        {
            var tr=new RotateTransform();
            _myAngle++;
            tr.Angle = _myAngle;
            //myLabel.RenderTransform = tr;
        }
    }
}
