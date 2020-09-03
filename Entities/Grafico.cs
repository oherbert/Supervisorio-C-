
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Arduino_teste2.Utils;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.WinForms;
using LiveCharts.Wpf;

namespace Arduino_teste2.Entities
{
    class Grafico
    {

        // Geral
        public LiveCharts.Wpf.CartesianChart CartesianChart { get; set; }
        private static Random R = new Random();

        // Exlcusiva para a classe Registro editar o numero de pontos
        //  private static List<Registro> registros;

        // private ChartValues<Registro>[] chartValues;

        public List<RegistroGrafico> registroGraficos = new List<RegistroGrafico>();

        public Grafico()
        {
            List<Registro> registros = ConversorEntradaSerial.getRegistros("{Zona1=" + R.Next(0, 150) + ",Zona2=" + R.Next(25, 150) + ", Zona3=300}");
            //chartValues = new ChartValues<Registro>[registros.Count];

            foreach (Registro registro in registros) 
            {
                ChartValues<Registro> registros1 = null;
                registroGraficos.Add(new RegistroGrafico(registro, registros1));
            }
            
        }



        public void chartInit()
        {

            List<LineSeries> lines = new List<LineSeries>();

            foreach (RegistroGrafico registroG in registroGraficos)
            {
                addLine(lines, registroG.Registro.Nome) ;
            }

            foreach (LineSeries line in lines)
            {
                CartesianChart.Series.Add(line);
            }

            CartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new DateTime((long)value).ToString("HH:mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });


            SetAxisLimits(DateTime.Now);

            atualizaGrafico();
        }

        public void atualizaGrafico()
        {
            var now = DateTime.Now;

            List<Registro> registros = ConversorEntradaSerial.getRegistros("{Zona1=" + R.Next(0, 150) + ",Zona2=" + R.Next(25, 150) + ", Zona3=160}");
            

            foreach (RegistroGrafico rg in registroGraficos) {

                foreach (Registro registro in registros) {
                    if (rg.Registro.Nome == registro.Nome) {
                        rg.Registro = registro;
                    }
                }

                rg.ChartVal.Add( rg.Registro);

            }

            SetAxisLimits(now);

            //lets only use the last 30 values

            foreach (RegistroGrafico rG in registroGraficos)
            {
                if (rG.ChartVal.Count > 30) rG.ChartVal.RemoveAt(0);
            }


        }

        private void SetAxisLimits(DateTime now)
        {
            CartesianChart.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks; // lets force the axis to be 100ms ahead
            CartesianChart.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks; //we only care about the last 8 seconds
        }

        private void addLine(List<LineSeries> lines, string titulo)
        {

            var mapper1 = Mappers.Xy<Registro>()
                .X(model => model.DateTime.Ticks)   //use DateTime.Ticks as X
                .Y(model => model.Valor);        //use the value property as Y

            Charting.For<Registro>(mapper1);
            //chartValues[lines.Count] = new ChartValues<Registro>();
            ChartValues<Registro> chart = new ChartValues<Registro>();


            foreach (RegistroGrafico rg in registroGraficos) {

                if (rg.ChartVal == null) {
                    rg.ChartVal = chart;
                    break;
                }
            }

            

            LineSeries line = new LineSeries
            {
                Title = titulo,
                Values = chart,
                PointGeometrySize = 18,
                StrokeThickness = 4
            };

            lines.Add(line);

        }


    }

    class RegistroGrafico {

        public Registro Registro { get; set; }
        public ChartValues<Registro> ChartVal { get; set; }

        public RegistroGrafico(Registro registro, ChartValues<Registro> chartRegistro) {
            Registro = registro;
            ChartVal = chartRegistro;
        }

    }
}
