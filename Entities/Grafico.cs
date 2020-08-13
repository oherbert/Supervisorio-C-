using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using Arduino_teste2.Entities;
using System.Collections.Generic;
using System.Windows;

namespace Arduino_teste2.Entities
{
    class  Grafico: UserControl
    {
        private SeriesCollection SeriesCollection;
        public CartesianChart Cartesian { get; set; }
        private List<Registro> registros = new List<Registro>();

        public void createSeries()
        {

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Zona 1",
                    Values = new ChartValues<double> { },
                    LineSmoothness = 0,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 15,
                    PointForeground = Brushes.Blue,
                },
                new LineSeries
                {
                    Title = "Zona 2",
                    Values = new ChartValues<double> { },
                    LineSmoothness = 0,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 15,
                    PointForeground = Brushes.Red
                },

            };           
            DataContext = this;

            Cartesian.Series = SeriesCollection;

        }

        public void addRegistro(Registro registro) {
            //modifying any series values will also animate and update the chart

            SeriesCollection.Clear();
            createSeries();

            registros.Add(registro);

            string[] labels = new string[60];
            int cont = 0;

            foreach (Registro pos in registros) {
                SeriesCollection[0].Values.Add(pos.Zona1);
                SeriesCollection[1].Values.Add(pos.Zona2);
                string[] cut = pos.DataTime.Split();
                labels[cont] = cut[1];
            }

            

            Cartesian.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Hora",
                Labels =  labels
            });

        }


    }
}
