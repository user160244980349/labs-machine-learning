using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace ML0.Models
{
    public class LinearChartModel
    {
        public PlotModel Plot { get; set; }

        private LineSeries _learnSeries;
        private LineSeries _testSeries;
        private LinearAxis _XAxis;
        private LinearAxis _YAxis;

        public LinearChartModel()
        {
            Plot = new PlotModel();
            Plot.Axes.Clear();
            Plot.IsLegendVisible = true;
            Plot.LegendPosition = LegendPosition.RightTop;

            _XAxis = new LinearAxis();
            Plot.Axes.Add(_XAxis);
            _XAxis.Title = "Эпохи";
            _XAxis.Position = AxisPosition.Bottom;
            _XAxis.Maximum = 1000;
            _XAxis.Minimum = 0;
            _XAxis.MinorGridlineStyle = LineStyle.Dash;
            _XAxis.MajorGridlineStyle = LineStyle.Solid;
            _XAxis.MinorStep = 50;
            _XAxis.MajorStep = 100;

            _YAxis = new LinearAxis();
            Plot.Axes.Add(_YAxis);
            _YAxis.Title = "Ошибка";
            _YAxis.Position = AxisPosition.Left;
            _YAxis.Maximum = 5;
            _YAxis.Minimum = 0;
            _YAxis.MinorGridlineStyle = LineStyle.Dash;
            _YAxis.MajorGridlineStyle = LineStyle.Solid;
            _YAxis.MinorStep = 0.1;
            _YAxis.MajorStep = 0.5;

            _learnSeries = new LineSeries();
            Plot.Series.Add(_learnSeries);
            _learnSeries.Smooth = true;
            _learnSeries.Color = OxyColors.PaleVioletRed;
            _learnSeries.Title = "Ошибка обучения";
            _learnSeries.RenderInLegend = true;

            _testSeries = new LineSeries();
            Plot.Series.Add(_testSeries);
            _testSeries.Smooth = true;
            _testSeries.Color = OxyColors.MediumPurple;
            _testSeries.Title = "Ошибка тестирования";
            _testSeries.RenderInLegend = true;
        }
        public void SetLines(double[] learn, double[] test)
        {
            _XAxis.Maximum = double.NaN;
            _XAxis.Minimum = double.NaN;

            _YAxis.Maximum = double.NaN;
            _YAxis.Minimum = double.NaN;

            _learnSeries.Points.Clear();
            for (var i = 0; i < learn.Length; i++)
            {
                _learnSeries.Points.Add(new DataPoint(i, learn[i]));
            }
            _testSeries.Points.Clear();
            for (var i = 0; i < test.Length; i++)
            {
                _testSeries.Points.Add(new DataPoint(i, test[i]));
            }
            Plot.InvalidatePlot(true);
        }
    }
}
