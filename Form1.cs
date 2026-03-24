using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        public decimal valor1, valor2, resultado;
        public char operador;
            
        private void Calculadora_Load(object sender, EventArgs e)
        {

        }


        private void btnCe_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }


        private void btnC_Click(object sender, EventArgs e)
        {
            LimparVIsor();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVisor.Text))
            {
                txtVisor.Text = "0,";
            }
            else if (!txtVisor.Text.Contains(","))
            {
                txtVisor.Text += ",";
            }
        }


        #region Metodos

        public void LimparTudo()
        {
            LimparVIsor();
            valor1 = 0;
            valor2 = 0;
            lblConta.Text = "";
            operador = ' ';
        }
        public void LimparVIsor()
        {
            txtVisor.Clear();

        }

        decimal Calcular(decimal valor1, decimal valor2)
        {
            switch (operador)
            {
                case '-':
                    resultado = valor1 - valor2;
                    break;
                case '+':
                    resultado = valor1 + valor2;
                    break;
                case '×':
                    resultado = valor1 * valor2;
                    break;
                case '÷':
                    resultado = valor1 / valor2;
                    break ;
                    default:
                    txtVisor.Text = "Error";
                    break;
            }
            return resultado;
        }
        #endregion
        #region Botoes numericos
        private void btnUm_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }
           
        private void btnNove_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }
        
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }
        #endregion
        #region Botoes Operadores
        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtVisor.Text);
            resultado = Calcular(valor1, valor2);
            txtVisor.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            
            valor1 = decimal.Parse(txtVisor.Text);
            lblConta.Text = "÷";
            operador = '÷';
            LimparVIsor();
        }
        private void btnVezes_Click(object sender, EventArgs e)
        {
            
            valor1 = decimal.Parse(txtVisor.Text);
            lblConta.Text = "×";
            operador = '×';
            LimparVIsor();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text);
            lblConta.Text = "+";
            operador = '+';
            LimparVIsor();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtVisor.Text);
            lblConta.Text = "-";
            operador = '-';
            LimparVIsor();
        }
        #endregion
    }
}
