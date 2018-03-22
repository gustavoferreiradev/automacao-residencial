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
    public partial class frmSala : Form
    {
        public frmSala()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";
            serialPort1.BaudRate = 9600;
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("1");
            }
            serialPort1.Close();

        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("0");
            }
            serialPort1.Close();
        }

   
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                    var Posicao = trackBar1.Value.ToString();
                     int pos = Posicao.Length;
                 if (pos == 1)
                 {
                     Posicao ="00" + Posicao;

                 }
                 else if (pos == 2)
                 {
                     Posicao = "0" + Posicao;
                 }
                 serialPort1.Close();
            
                
                   
                    }
            }
        

    }
    }
