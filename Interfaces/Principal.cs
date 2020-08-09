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
using Arduino_teste2.Interfaces;
using Arduino_teste2.Utils;


namespace Arduino_teste2
{   
    public partial class Form1 : Form
    {
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
            

            chart.AxisY.Minimum = 20;
            chart.AxisY.Maximum = 180;
            chart.AxisY.Interval = 10;
            

            chartPrincipal.Series.Add("Secagem");
            chartPrincipal.Series["Secagem"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPrincipal.Series["Secagem"].Color = Color.BlueViolet;
            chartPrincipal.Series["Secagem"].Points.AddXY("09:30:00",120);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:31:00", 122);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:32:00", 124);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:33:00", 126);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:34:00", 128);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:35:00", 140);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:36:00", 150);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:37:00", 157);
            chartPrincipal.Series["Secagem"].Points.AddXY("09:38:00", 158);
            


            chartPrincipal.Series.Add("Vulcanização");
            chartPrincipal.Series["Vulcanização"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chartPrincipal.Series["Vulcanização"].Color = Color.Coral;
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:30:00", 120);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:31:00", 122);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:32:00", 124);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:33:00", 126);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:34:00", 128);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:35:00", 140);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:36:00", 150);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:37:00", 160);
            chartPrincipal.Series["Vulcanização"].Points.AddXY("09:38:00", 167);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }



        private void btnSendData_Click(object sender, EventArgs e)
        {
            
        }

                

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void offsetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offsets offsets = new Offsets();
            offsets.ShowDialog();
        }

        private void com1Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM1";
        }

        private void com2Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM2";
        }

        private void com3Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM3";
        }

        private void com4Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM4";
        }

        private void com5Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM5";
        }

        private void com6Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM6";
        }

        private void com7Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM7";
        }

        private void com8Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM8";
        }

        private void com9Menu_Click(object sender, EventArgs e)
        {
            Arduino.portCom = "COM9";
        }

        private void conectarMenu_Click(object sender, EventArgs e)
        {
            if (Arduino.portCom != null)
            {
                Arduino.tryOpenPort();

                if (Arduino.streamCom == "Aberta")
                {
                    timer1.Start();
                    conectarMenu.Enabled = false;
                    com1Menu.Enabled = false;
                    com2Menu.Enabled = false;
                    com3Menu.Enabled = false;
                    com4Menu.Enabled = false;
                    com5Menu.Enabled = false;
                    com6Menu.Enabled = false;
                    com7Menu.Enabled = false;
                    com8Menu.Enabled = false;
                    com9Menu.Enabled = false;
                }
            }
            else
                MessageBox.Show("Não há porta de comunicação selecionada");
        }

        private void chartPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Arduino.portCom != null && Arduino.streamCom != "Fechada")
            {
                lblCom.Text = Arduino.streamCom;
            }
            else if (Arduino.streamCom == "Fechada" )
            {
                lblCom.Text = "Porta fechada";
                conectarMenu.Enabled = true;
                com1Menu.Enabled = true;
                com2Menu.Enabled = true;
                com3Menu.Enabled = true;
                com4Menu.Enabled = true;
                com5Menu.Enabled = true;
                com6Menu.Enabled = true;
                com7Menu.Enabled = true;
                com8Menu.Enabled = true;
                com9Menu.Enabled = true;
                timer1.Stop();
            }
        }

        private void desconectarMenu_Click(object sender, EventArgs e)
        {
            Arduino.close();
        }
    }
}
