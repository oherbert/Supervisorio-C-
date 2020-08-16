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
using LiveCharts.Wpf;
using LiveCharts;
using System.Windows.Media.Animation;
using System.Windows.Media;
using Arduino_teste2.Entities;

namespace Arduino_teste2
{   
    public partial class Form1 : Form
    {

        Grafico chart = new Grafico(1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.CartesianChart = cartesianChart;
            chart.chartInit(); 
            
        }


        private void offsetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offsets offsets = new Offsets();
            offsets.ShowDialog();
        }

        private void com1Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM1";
        }

        private void com2Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM2";
        }

        private void com3Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM3";
        }

        private void com4Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM4";
        }

        private void com5Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM5";
        }

        private void com6Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM6";
        }

        private void com7Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM7";
        }

        private void com8Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM8";
        }

        private void com9Menu_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = "COM9";
        }

        private void conectarMenu_Click(object sender, EventArgs e)
        {
            if (Arduino.PortCom != null)
            {
                Arduino.tryOpenPort();

                if (Arduino.StreamCom == "Aberta")
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

            if (Arduino.PortCom != null && Arduino.StreamCom != "Fechada")
            {
                lblCom.Text = Arduino.StreamCom;
            }
            else if (Arduino.StreamCom == "Fechada" )
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

        // Para mostrar a porta selecionada
        private void comunicaçãoMenu_MouseEnter(object sender, EventArgs e)
        {
            com1Menu.Checked = false;
            com2Menu.Checked = false;
            com3Menu.Checked = false;
            com4Menu.Checked = false;
            com5Menu.Checked = false;
            com6Menu.Checked = false;
            com7Menu.Checked = false;
            com8Menu.Checked = false;
            com9Menu.Checked = false;


            switch (Arduino.PortCom) 
            {
                case "COM1":
                    com1Menu.Checked = true;
                    break;
                case "COM2":
                    com2Menu.Checked = true;
                    break;
                case "COM3":
                    com3Menu.Checked = true;
                    break;
                case "COM4":
                    com4Menu.Checked = true;
                    break;
                case "COM5":
                    com5Menu.Checked = true;
                    break;
                case "COM6":
                    com6Menu.Checked = true;
                    break;
                case "COM7":
                    com7Menu.Checked = true;
                    break;
                case "COM8":
                    com8Menu.Checked = true;
                    break;
                case "COM9":
                    com9Menu.Checked = true;
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Arduino.close();
            Application.ExitThread();
            Environment.Exit(0);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
              
        }
    }
}
