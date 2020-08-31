
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Arduino_teste2.Utils;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Arduino_teste2.Entities
{
    class Grafico : Form
    {

        // Geral
        public LiveCharts.Wpf.CartesianChart CartesianChart { get; set; }
        public int Intervalo { get; set; } //Em segundos
        private Timer Timer = new Timer();
        private static Random R = new Random();

        // Exlcusiva para a classe Registro editar o numero de pontos
        private static List<Registro> registros = ConversorEntradaSerial.getRegistros("{Zona1="+R.Next(0,150) + ",Zona2=" + R.Next(25, 150) +", Zona3=300}");

        private ChartValues<Registro>[] chartValues = new ChartValues<Registro>[registros.Count];
        
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
            
            List<LineSeries> lines = new List<LineSeries>();

            foreach (Registro registro in registros) {
                addLine(lines, registro.Nome);
            }

            foreach (LineSeries line in lines)
            {
                CartesianChart.Series.Add(line);
            }
                
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
            
            foreach (ChartValues<Registro> chart in chartValues) { 
                chart.Add(new Registro
                {
                    DateTime = now,
                    Valor = R.Next(0, 157)
                });
            }

            SetAxisLimits(now);

            //lets only use the last 30 values

            foreach (ChartValues<Registro> chart in chartValues)
            {
                if (chart.Count > 30) chart.RemoveAt(0);
            }


            
        }

        private void addLine (List<LineSeries> lines, string titulo) {
            
            var mapper1 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Valor);        //use the value property as Y

            Charting.For<Registro>(mapper1);
            chartValues[lines.Count] = new ChartValues<Registro>();


            LineSeries line = new LineSeries
            {
                Title = titulo,
                Values = chartValues[lines.Count],
                PointGeometrySize = 18,
                StrokeThickness = 4
            };

            lines.Add(line);         
            
        }

        
    }
}
