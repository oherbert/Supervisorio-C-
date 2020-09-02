using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Arduino_teste2.Interfaces;
using Arduino_teste2.Utils;
using Arduino_teste2.Entities;


namespace Arduino_teste2
{
    public partial class Form1 : Form
    {
        private List<ToolStripMenuItem> menusCom;
        Grafico chart = new Grafico(1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart.CartesianChart = cartesianChart;
            chart.chartInit();

            menusCom = new List<ToolStripMenuItem>();

            for (int i = 1; i <= 9; i++)
            {
                string nomeCom = "COM" + i.ToString();
                menusCom.Add(new ToolStripMenuItem(nomeCom, null, comTool_Click, nomeCom));
            }

            foreach (ToolStripMenuItem menu in menusCom)
            {
                comunicaçãoMenu.DropDown.Items.Add(menu);
            }


        }

        private void comTool_Click(object sender, EventArgs e)
        {
            Arduino.PortCom = sender.ToString();
        }


        private void offsetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offsets offsets = new Offsets();
            offsets.ShowDialog();
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

                    foreach (ToolStripMenuItem menu in menusCom)
                    {
                        menu.Enabled = false;
                    }
                }
            }
            else
                MessageBox.Show("Não há porta de comunicação selecionada");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Arduino.PortCom != null && Arduino.StreamCom != "Fechada")
            {
                lblCom.Text = Arduino.StreamCom;
            }
            else if (Arduino.StreamCom == "Fechada")
            {
                lblCom.Text = "Porta fechada";
                conectarMenu.Enabled = true;

                foreach (ToolStripMenuItem menu in menusCom)
                {
                    menu.Enabled = true;
                }

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

            foreach (ToolStripMenuItem menu in menusCom)
            {
                menu.Checked = false;

                if (Arduino.PortCom == menu.ToString())
                {
                    menu.Checked = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Arduino.close();
            Application.ExitThread();
            Environment.Exit(0);

        }

    }
}
