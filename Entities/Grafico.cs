
using System;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Arduino_teste2.Entities
{
     class Grafico : Form
    {
        
    public LiveCharts.Wpf.CartesianChart CartesianChart { get; set; }

        public void chartInit()
        {

            //To handle live data easily, in this case we built a specialized type
            //the MeasureModel class, it only contains 2 properties
            //DateTime and Value
            //We need to configure LiveCharts to handle MeasureModel class
            //The next code configures MEasureModel  globally, this means
            //that livecharts learns to plot MeasureModel and will use this config every time
            //a ChartValues instance uses this type.
            //this code ideally should only run once, when application starts is reccomended.
            //you can configure series in many ways, learn more at http://lvcharts.net/App/examples/v1/wpf/Types%20and%20Configuration

            var mapper1 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Zona1);        //use the value property as Y
                

            var mapper2 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Zona2);          //use the value property as Y

            //lets save the mapper globally.
            Charting.For<Registro>(mapper1);
            
            //the ChartValues property will store our values array
            ChartValues1 = new ChartValues<Registro>();
            
            LineSeries line1 = new LineSeries {
                Title = "Zona 1",
                Values = ChartValues1,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };

            Charting.For<Registro>(mapper2);
            ChartValues2 = new ChartValues<Registro>();

            LineSeries line2 = new LineSeries()
            {
                Title = "Zona 2",
                Values = ChartValues2,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };

                      

            CartesianChart.Series = new SeriesCollection{ line1,line2 };

            CartesianChart.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            SetAxisLimits(DateTime.Now);

            //The next code simulates data changes every 500 ms
            Timer = new Timer
            {
                Interval = 2000
            };
            Timer.Tick += TimerOnTick;
            R = new Random();
            Timer.Start();
        }

        public ChartValues<Registro> ChartValues1 { get; set; }
        public ChartValues<Registro> ChartValues2 { get; set; }
        public Timer Timer { get; set; }
        public Random R { get; set; }

        private void SetAxisLimits(DateTime now)
        {
            CartesianChart.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            CartesianChart.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            var now = DateTime.Now;

            ChartValues1.Add(new Registro
            {
                DateTime = now,
                Zona1 = R.Next(150, 157),
                Zona2 = R.Next(160, 167)
            });
            
            ChartValues2.Add(new Registro
            {
                DateTime = now,
                Zona1 = R.Next(160, 167),
                Zona2 = R.Next(160, 167)
            });
            
            SetAxisLimits(now);

            //lets only use the last 30 values
            if (ChartValues1.Count > 30) ChartValues1.RemoveAt(0);
            if (ChartValues2.Count > 30) ChartValues1.RemoveAt(0);
        }
    }
}
