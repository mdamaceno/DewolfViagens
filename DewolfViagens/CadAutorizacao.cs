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
    public partial class CadAutorizacao : Form
    {
        private Passageiro passageiro;
        public CadAutorizacao()
        {
            InitializeComponent();
        }

        private void CadAutorizacao_Load(object sender, EventArgs e)
        {

        }

        /*public void Execute(Passageiro passageiro)
        {
            this.passageiro = passageiro;

            label2.Text = this.passageiro.Nome;
            /*txtId.Text = this.passageiro.Id.ToString();
            txtNome.Text = this.passageiro.Nome;
            txtCep.Text = this.passageiro.Cep; 

            this.ShowDialog();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            var autoriza = new Autorizacao()
            {
                NomeResponsavel = textBox1.Text,
                NumDocResponsavel = textBox2.Text,
                Data = dateTimePicker1.Value,
                TelefoneContato = maskedTextBox1.Text

            };

            

            TelerikModel.DewolfModel.Add(autoriza);

            //this.passageiro.Autorizacao = autoriza.Idautorizacao;

            if (TelerikModel.DewolfModel.HasChanges)
            {
                TelerikModel.DewolfModel.SaveChanges();
            }

            CadPassageiro frm = new CadPassageiro();
            frm.Execute(autoriza);
            

            this.Close();


        }
    }
}
