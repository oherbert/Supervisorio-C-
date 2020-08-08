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
            chart.AxisY.Maximum = 200;

            chartPrincipal.Series.Add("Secagem");
            chartPrincipal.Series["Secagem"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPrincipal.Series["Secagem"].Color = Color.BlueViolet;
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:30:00",120);
            chartPrincipal.Series["Secagem"].Points.AddXY("08/08/2020 09:31:00", 122);

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
