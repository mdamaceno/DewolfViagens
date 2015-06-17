using Dewolf.Model;
using DewolfViagens.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DewolfViagens
{
    public partial class CadPassageiro : Form
    {
        private Autorizacao autoriza;
        public CadPassageiro()
        {
            InitializeComponent();
        }

        public void Execute(Autorizacao autoriza)
        {
            this.autoriza = autoriza;
            //var idAutoriza = this.autoriza.Idautorizacao;
            textBox3.Text = Convert.ToString(this.autoriza.Idautorizacao);
            //textBox3.Text = this.autoriza.Idautorizacao.ToString();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 12) {
                var passageiro = new Passageiro()
                {
                    Nome = textBox1.Text,
                    Idade = Convert.ToInt32(numericUpDown1.Value),
                    Cpf = maskedTextBox1.Text,
                    Rg = textBox2.Text,
                    Autorizacao = Convert.ToInt32(textBox3.Text)
                };

                TelerikModel.DewolfModel.Add(passageiro);

                if (TelerikModel.DewolfModel.HasChanges)
                {
                    TelerikModel.DewolfModel.SaveChanges();
                }
            }
            else 
            { 
                var passageiro = new Passageiro()
                {
                    Nome = textBox1.Text,
                    Idade = Convert.ToInt32(numericUpDown1.Value),
                    Cpf = maskedTextBox1.Text,
                    Rg = textBox2.Text 
                };

                TelerikModel.DewolfModel.Add(passageiro);

                if (TelerikModel.DewolfModel.HasChanges)
                {
                    TelerikModel.DewolfModel.SaveChanges();
                }
            }

            

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= 12)
            {
                button1.Enabled = true;
                

                MessageBox.Show("Passageiros Menores de 12 anos requerem Autorizaçao");
            }
            else 
            {
                button1.Enabled = false;
            }
        }

        private void CadPassageiro_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
            CadAutorizacao frm = new CadAutorizacao();
            //frm.Execute(passageiro);

            frm.ShowDialog();
        }
    }
}
