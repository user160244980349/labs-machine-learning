using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Windows;

namespace ML0.Models
{
    public class ColumnChartModel : DependencyObject
    {
        public PlotModel Plot { get; private set; }

        private ColumnSeries _series;
        private CategoryAxis _XAxis;
        private LinearAxis _YAxis;

        public ColumnChartModel()
        {
            Plot = new PlotModel();
            Plot.Axes.Clear();
            Plot.IsLegendVisible = true;
            Plot.LegendPosition = LegendPosition.RightTop;

            _XAxis = new CategoryAxis();
            Plot.Axes.Add(_XAxis);
            _XAxis.Title = "Изображение";
            _XAxis.Position = AxisPosition.Bottom;
            _XAxis.Maximum = 4;
            _XAxis.MinorGridlineStyle = LineStyle.Dash;
            _XAxis.MajorGridlineStyle = LineStyle.Solid;
            _XAxis.MinorStep = 0.1;
            _XAxis.MajorStep = 1;
            _XAxis.Labels.Add("1");
            _XAxis.Labels.Add("2");
            _XAxis.Labels.Add("3");
            _XAxis.Labels.Add("4");

            _YAxis = new LinearAxis();
            Plot.Axes.Add(_YAxis);
            _YAxis.Title = "Соответствие";
            _YAxis.Position = AxisPosition.Left;
            _YAxis.Maximum = 1;
            _YAxis.MinimumRange = 1;
            _YAxis.MinorGridlineStyle = LineStyle.Dash;
            _YAxis.MajorGridlineStyle = LineStyle.Solid;
            _YAxis.MinorStep = 0.1;
            _YAxis.MajorStep = 0.1;

            _series = new ColumnSeries();
            _series.Title = "Соответствие";
            _series.FillColor = OxyColors.RoyalBlue;
            _series.RenderInLegend = true;
            Plot.Series.Add(_series);
        }
        public void SetColumns(double[] cols)
        {
            _XAxis.Maximum = double.NaN;
            _XAxis.Minimum = double.NaN;

            _YAxis.Maximum = double.NaN;
            _YAxis.Minimum = double.NaN;

            _series.Items.Clear();
            for (var i = 0; i < cols.Length; i++)
            {
                _series.Items.Add(new ColumnItem
                {
                    CategoryIndex = cols.Length - 1 - i,
                    Value = cols[i],
                });
            }
            Plot.InvalidatePlot(true);
        }
    }
}
