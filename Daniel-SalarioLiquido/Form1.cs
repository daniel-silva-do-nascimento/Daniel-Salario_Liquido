using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniel_SalarioLiquido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorHora, valorDesconto, totalDesconto, salarioLiquido, salarioBruto;
            int horasTrabalho;

            horasTrabalho = Convert.ToInt32(textBox3.Text);
            valorHora = Convert.ToDouble(textBox1.Text);
            valorDesconto = Convert.ToDouble(textBox2.Text);

            salarioBruto = horasTrabalho * valorHora;
            totalDesconto = (valorDesconto / 100) * salarioBruto;
            salarioLiquido = salarioBruto - totalDesconto;

            salarioLiquido = Math.Round(salarioLiquido, 2);
            salarioBruto = Math.Round(salarioBruto, 2);
            totalDesconto = Math.Round(totalDesconto, 2);



            label11.Text = "R$" + salarioBruto.ToString();
            label12.Text = "R$" + salarioLiquido.ToString();
            label13.Text = "R$" + totalDesconto.ToString();

            //variavel = Math.Round(variavel,2); arredondar para 2 números após a vírgula
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label11.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
