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
    public partial class Frmp2 : Form
    {
        public Frmp2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnCerta2.Checked == true)
            {
                MessageBox.Show("Certa Resposta,Sera?");
                VariaveisGlobais.acertos += 1;
                Frmp3 p3 = new Frmp3();
                p3.ShowDialog();
                this.Dispose();
            }
            else if (radioButton1.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Resposta errada?");
                VariaveisGlobais.erros += 1;
                Frmp3 p3 = new Frmp3();
                p3.ShowDialog();
                this.Dispose();
            }
            else
            {

                MessageBox.Show("Escolha uma opção");
            }
        }
    }
}
