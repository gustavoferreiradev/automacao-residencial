using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Automacao_Residencial
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            frmSala Sala = new frmSala();
            Sala.Show();
        }

        private void btnQuarto1_Click(object sender, EventArgs e)
        {

        }
    }
}
