using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18
{
    public partial class IMCForm : Form
    {
        public IMCForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores de peso e altura
                double peso = double.Parse(txtPeso.Text);
                double altura = double.Parse(txtAltura.Text);

                // Verificar se os valores são válidos
                if (peso <= 0 || altura <= 0)
                {
                    lblResultadoIMC.Text = "Peso e altura devem ser positivos!";
                    return;
                }

                // Calcular o IMC
                double imc = peso / (altura * altura);

                // Calcular o peso ideal para homens (fórmula de Lorentz)
                double pesoIdealHomem = 22 * altura * altura;

                // Calcular o peso ideal para mulheres (fórmula de Lorentz)
                double pesoIdealMulher = 21.5 * altura * altura;

                // Exibir o resultado
                lblResultadoIMC.Text = $"Seu IMC é: {imc:F2}. Peso ideal (homem): {pesoIdealHomem:F2} kg. Peso ideal (mulher): {pesoIdealMulher:F2} kg.";
            }
            catch (FormatException)
            {
                lblResultadoIMC.Text = "Entrada inválida! Por favor, insira números válidos.";
            }
            catch (Exception ex)
            {
                lblResultadoIMC.Text = $"Erro: {ex.Message}";
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
