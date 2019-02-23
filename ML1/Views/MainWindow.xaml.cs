using ML1.Models;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows;

namespace ML1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowModel WindowModel { get; private set;}

        private int _testSample;
        private int _x;
        private int _y;
        private int _epoches;
        private double _speed;
        private double _learnNoise;
        private double _testNoise;

        public MainWindow()
        {
            InitializeComponent();
            WindowModel = new MainWindowModel();
            DataContext = WindowModel;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var images = new Bitmap[]
            {
                Properties.Resources._11,
                Properties.Resources._12,
                Properties.Resources._13,
                Properties.Resources._14,
            };
            WindowModel.Trainigs = GetPicturesBitmaps(images);
        }
        private static double GetDouble(string value, double defaultValue)
        {
            double result;
            if (!double.TryParse(value, NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                !double.TryParse(value, NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
                !double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
            {
                result = defaultValue;
            }
            return result;
        }
        private static double[][] GetPicturesBitmaps(Bitmap[] images)
        {
            var bitmaps = new double[images.Length][];
            for (var i = 0; i < images.Length; i++)
            {
                var j = 0;
                bitmaps[i] = new double[images[i].Height * images[i].Width];
                for (var y = 0; y < images[i].Height; y++)
                {
                    for (var x = 0; x < images[i].Width; x++)
                    {
                        Color c = images[i].GetPixel(x, y);
                        double bw = 1 - Math.Round((double)(c.R + c.G + c.B) / 255 / 3);
                        bitmaps[i][j] = bw;
                        j++;
                    }
                }
            }

            return bitmaps;
        }

        private void LearnClick(object sender, RoutedEventArgs e)
        {
            WindowModel.X = _x;
            WindowModel.Y = _y;
            WindowModel.E = _epoches;
            WindowModel.L = _speed;
            WindowModel.LearnNoise = _learnNoise;
            WindowModel.Train();
        }
        private void TestClick(object sender, RoutedEventArgs e)
        {
            WindowModel.TestSample = _testSample;
            WindowModel.TestNoise = _testNoise;
            WindowModel.Run();
        }
        private void Six_Checked(object sender, RoutedEventArgs e)
        {
            _testSample = 0;
        }
        private void Seven_Checked(object sender, RoutedEventArgs e)
        {
            _testSample = 1;
        }
        private void Zhe_Checked(object sender, RoutedEventArgs e)
        {
            _testSample = 2;
        }
        private void Sche_Checked(object sender, RoutedEventArgs e)
        {
            _testSample = 3;
        }
        private void X_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _x = Convert.ToInt32(X.Text);
        }
        private void Y_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _y = Convert.ToInt32(Y.Text);
        }
        private void Epoches_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _epoches = Convert.ToInt32(Epoches.Text);
        }
        private void Speed_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _speed = GetDouble(Speed.Text, 0);
        }
        private void LearnNoise_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _learnNoise = GetDouble(LearnNoise.Text, 0);
        }
        private void TestNoise_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _testNoise = GetDouble(TestNoise.Text, 0);
        }
    }
}
