
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
        // Exlcusiva para a classe Registro
        public ChartValues<Registro> ChartValues1 { get; set; }
        public ChartValues<Registro> ChartValues2 { get; set; }

        // 
        public LiveCharts.Wpf.CartesianChart CartesianChart { get; set; }
        public int Intervalo { get; set; } //Em segundos
        private Timer Timer = new Timer();
        private Random R = new Random();

        public Grafico()
        {
        }

        public Grafico(int intervalo)
        {
            Intervalo = intervalo;
        }

        public Grafico(LiveCharts.Wpf.CartesianChart cartesianChart, int intervalo)
        {
            CartesianChart = cartesianChart;
            Intervalo = intervalo;
            chartInit();
        }



        public void chartInit()
        {

            var mapper1 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Valor);        //use the value property as Y

            Charting.For<Registro>(mapper1);
            ChartValues1 = new ChartValues<Registro>();

            LineSeries line1 = new LineSeries
            {
                Title = "Zona 1",
                Values = ChartValues1,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };


            var mapper2 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Valor);          //use the value property as Y

            Charting.For<Registro>(mapper2);
            ChartValues2 = new ChartValues<Registro>();

            LineSeries line2 = new LineSeries()
            {
                Title = "Zona 2",
                Values = ChartValues2,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };

            LineSeries[] lineSeries = new LineSeries[] { line1, line2 };


            CartesianChart.Series = new SeriesCollection { line1, line2};
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

            //The next code create data changes 
            Timer = new Timer
            {
                Interval = (Intervalo * 1000)
            };
            Timer.Tick += TimerOnTick;
            Timer.Start();
        }

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
                Valor = R.Next(0, 157)
            });

            ChartValues2.Add(new Registro
            {
                DateTime = now,
                Valor = R.Next(160, 167)
            });

            SetAxisLimits(now);

            //lets only use the last 30 values
            if (ChartValues1.Count > 30) ChartValues1.RemoveAt(0);
            if (ChartValues2.Count > 30) ChartValues2.RemoveAt(0);
        }

        private LineSeries[] CreateLines() {
            
           
            var mapper1 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Valor);        //use the value property as Y

            Charting.For<Registro>(mapper1);
            ChartValues1 = new ChartValues<Registro>();

            LineSeries line1 = new LineSeries
            {
                Title = "Zona 1",
                Values = ChartValues1,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };


            var mapper2 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Valor);          //use the value property as Y

            Charting.For<Registro>(mapper2);
            ChartValues2 = new ChartValues<Registro>();

            LineSeries line2 = new LineSeries()
            {
                Title = "Zona 2",
                Values = ChartValues2,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };

            LineSeries[] lineSeries = new LineSeries[] { line1, line2 };

            return lineSeries;
        }
    }
}
