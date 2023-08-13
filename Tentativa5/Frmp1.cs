using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tentativa5
{
    public partial class Frmp1 : Form
    {
        public Frmp1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnCerta1.Checked == true)
            {
                MessageBox.Show("Certa Resposta,Sera?");
                VariaveisGlobais.acertos += 1;
                Frmp2 p2 = new Frmp2();
                p2.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked|| radioButton4.Checked)
            {
                MessageBox.Show("Resposta errada?");
                VariaveisGlobais.erros += 1;
                Frmp2 p2 = new Frmp2();
                p2.ShowDialog();
                this.Dispose();
            }
            else
            {

                MessageBox.Show("Escolha uma opção");
            }
        }
    }
}
