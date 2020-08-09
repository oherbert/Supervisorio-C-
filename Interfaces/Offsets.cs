using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_teste2.Interfaces
{
    public partial class Offsets : Form
    {
        public Offsets()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtOffSec1.Text + "\n" + txtOffVul1.Text) ;
        }
    }
}
