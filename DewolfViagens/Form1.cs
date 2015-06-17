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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Execute()
        {
            var viagem = TelerikModel.DewolfModel.Viagems.ToList();

            var source = new BindingSource() { DataSource = viagem };
            dataGridView1.DataSource = source;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CadPassageiro Frm = new CadPassageiro();

            Frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadViagem Frm = new CadViagem();

            Frm.ShowDialog();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var viagem = TelerikModel.DewolfModel.Viagems.ToList();


            var source = new BindingSource() { DataSource = viagem };
            dataGridView1.DataSource = source;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var viagem = (Viagem)dataGridView1.SelectedRows[0].DataBoundItem;

                CadVendaPass Frm = new CadVendaPass();
                Frm.Execute(viagem);

                /*var pessoas = TelerikModel.DewolfModel.Pessoas.ToList();
                var source = new BindingSource() { DataSource = pessoas };
                dataGridView1.DataSource = source;*/
            }
            
        }
    }
}
