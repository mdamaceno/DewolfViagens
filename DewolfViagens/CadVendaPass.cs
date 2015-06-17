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
    public partial class CadVendaPass : Form
    {
        public Viagem viagem;
        
        public CadVendaPass()
        {
            InitializeComponent();
        }

        private void CadVendaPass_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }


        public void Execute(Viagem viagem)
        {
            this.viagem = viagem;


            var valorKM = this.viagem.VrUnitarioKM;
            var Distancia = this.viagem.Distancia;

            var valorDistancia = Distancia * valorKM;

            var valorPedagio = this.viagem.VrUnitarioPedagio * this.viagem.QtdePedagio;

            textBox1.Text = this.viagem.Idviagem.ToString();
            textBox2.Text = valorDistancia.ToString();
            textBox3.Text = valorPedagio.ToString();


            var pass = TelerikModel.DewolfModel.Passageiros.ToList();
            var sourceTrat = new BindingSource() { DataSource = pass };
            comboBox1.DataSource = sourceTrat;
            comboBox1.DisplayMember = "nome";

            label7.Text = Convert.ToString(valorDistancia + valorPedagio);

            List<int> poltrona = new List<int>();
            
            for (int i = 1; i <= this.viagem.QtdeLugares; i++)
            {
                poltrona.Add(i);
            }

           

            var sourcePoltrona = new BindingSource() { DataSource = poltrona };

            comboBox2.DataSource = sourcePoltrona;


            /*txtId.Text = this.pessoa.Id.ToString();
            txtNome.Text = this.pessoa.Nome;
            txtCep.Text = this.pessoa.Cep;*/

            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vendaPass = new Passagem()
            {
                NumPoltrona = Convert.ToInt32(comboBox2.SelectedItem),
                Passageiro = Convert.ToInt32(((Passageiro)comboBox1.SelectedItem).Idpassageiro),
                Viagem = Convert.ToInt32(textBox1.Text),
                VrDistancia = Convert.ToDecimal(textBox2.Text),
                VrPedagio = Convert.ToDecimal(textBox3.Text),
                VrTotal = Convert.ToDecimal(label7.Text)
            };

            TelerikModel.DewolfModel.Add(vendaPass);

            if (TelerikModel.DewolfModel.HasChanges)
            {
                TelerikModel.DewolfModel.SaveChanges();
            }

            this.Close();
        }
    }
}
