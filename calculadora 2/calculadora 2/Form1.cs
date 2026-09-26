using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculadora_2
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor = 0;
        string operacao = "";

        //cultura brasileira: usa virgula como separador decimal
        CultureInfo ptBR = new CultureInfo("pt-BR");

        //indica se o último comando foi o botão = 
        bool novocalculo = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //  numeros
        private void adicionarnumero(string)
        {
            //se acabou de calcular,começa um novo número
            if (novoCalculo)
            {
                txtResultado.Text = "";
                novocalculo = false;
            }
            txtResultado.Text += numero;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            adicionarnumero("0");
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            adicionarnumero("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            adicionarnumero("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            adicionarnumero("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            adicionarnumero("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            adicionarnumero("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            adicionarnumero("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            adicionarnumero("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            adicionarnumero("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            adicionarnumero("9");
        }
    }
}
