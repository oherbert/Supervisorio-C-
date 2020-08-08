using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using LiveCharts.Wpf.Charts.Base;

namespace Arduino_teste2
{   
    public partial class Form1 : Form
    {
        public static SerialPort serialPort = new SerialPort();
        public Thread reading = new Thread(Read);

        public Form1()
        {
            InitializeComponent();
            chartLoad();
        }

        void chartLoad() {
            var chart = chartPrincipal.ChartAreas[0];
            chart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisX.LabelStyle.IsEndLabelVisible = true;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 180;

            chartPrincipal.Series.Add("Secagem");
            chartPrincipal.Series["Secagem"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPrincipal.Series["Secagem"].Color = Color.BlueViolet;
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:30:00",120);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:31:00", 122);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:32:00", 124);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:33:00", 126);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:34:00", 128);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:35:00", 140);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:36:00", 150);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:37:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:38:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:39:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:38:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:39:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:40:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:41:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:42:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:43:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:44:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:45:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:46:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:47:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:48:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:49:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:50:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:51:00", 158);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:52:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:53:00", 158);

            chartPrincipal.Series.Add("Vulcanização");
            chartPrincipal.Series["Vulcanização"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPrincipal.Series["Vulcanização"].Color = Color.Coral;
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:30:00", 120);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:31:00", 122);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:32:00", 124);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:33:00", 126);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:34:00", 128);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:35:00", 140);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:36:00", 150);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:37:00", 160);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:38:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:39:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:40:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:41:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:42:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:43:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:44:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:45:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:46:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:47:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:48:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:49:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:50:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:51:00", 168);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:52:00", 167);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("08/08/2020 09:53:00", 166);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tryOpenPort();
        }





        private void btnSendData_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine(txtSendArduino.Text);
        }

        public void tryOpenPort()
        {
            if (serialPort.IsOpen == false)
            {
                serialPort.PortName = "COM6";
                serialPort.BaudRate = 9600;
                serialPort.ReadTimeout = 1200;
                serialPort.WriteTimeout = 1200;
                try
                {
                    serialPort.Open();
                    reading.Start();
                    btnSendData.Enabled = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Não foi possivel encontrar a porta selecionada: ");
                    btnSendData.Enabled = false;
                }

                if (serialPort.IsOpen == true)
                    Console.WriteLine("Aberta");
                else
                    Console.WriteLine("fechada");
            }
        }

            public static void Read()
            {

                while (serialPort.IsOpen == true)
                {
                    try
                    {
                        string message = serialPort.ReadLine();
                        Console.WriteLine(message);
                    }
                    catch (TimeoutException)
                    {
                        Console.WriteLine("Sem dados");
                    }
                }
            }
        

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            tryOpenPort();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
