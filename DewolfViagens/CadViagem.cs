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
    public partial class CadViagem : Form
    {
        public CadViagem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var viagem = new Viagem()
            {
                DataHorario = dateTimePicker1.Value,
                Motorista = textBox1.Text,
                Origem = textBox3.Text,
                Destino = textBox2.Text,
                QtdeLugares = Convert.ToInt32(numericUpDown1.Value),
                Distancia = Convert.ToInt32(textBox6.Text),
                VrUnitarioKM = Convert.ToDecimal(textBox4.Text),
                QtdePedagio = Convert.ToInt32(textBox7.Text),
                VrUnitarioPedagio = Convert.ToDecimal(textBox5.Text)
            };

            TelerikModel.DewolfModel.Add(viagem);

            if (TelerikModel.DewolfModel.HasChanges)
            {
                TelerikModel.DewolfModel.SaveChanges();
            }

            Form1 frm1 = new Form1();

            frm1.Execute();

            this.Close();

        }

        private void CadViagem_Load(object sender, EventArgs e)
        {

        }
    }
}
