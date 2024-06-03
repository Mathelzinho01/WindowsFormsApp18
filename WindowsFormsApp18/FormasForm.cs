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
    public partial class FormasForm : Form
    {
        public FormasForm()
        {
            InitializeComponent();
        }

        private void lblFormaResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularForma_Click(object sender, EventArgs e)
        {
            {
                string forma = cmbFormas.SelectedItem.ToString();

                if (forma == "Círculo")
                {
                    double diametro = double.Parse(txtDiametro.Text);
                    double raio = diametro / 2;
                    double area = Math.PI * raio * raio;
                    lblResultado.Text = $"Área do Círculo: {area:F2}";
                }
                else if (forma == "Triângulo")
                {
                    double lado1 = double.Parse(txtLado1.Text);
                    double lado2 = double.Parse(txtLado2.Text);
                    double lado3 = double.Parse(txtLado3.Text);

                    if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
                    {
                        double perimetro = lado1 + lado2 + lado3;
                        lblResultado.Text = $"Perímetro do Triângulo: {perimetro:F2}";
                    }
                    else
                    {
                        lblResultado.Text = "Triângulo inválido!";
                    }
                }
                else if (forma == "Quadrilátero")
                {
                    double lado1 = double.Parse(txtLado1.Text);
                    double lado2 = double.Parse(txtLado2.Text);
                    double lado3 = double.Parse(txtLado3.Text);
                    double lado4 = double.Parse(txtLado4.Text);

                    if (lado1 == lado3 && lado2 == lado4)
                    {
                        double perimetro = 2 * (lado1 + lado2);
                        lblResultado.Text = $"Perímetro do Quadrilátero: {perimetro:F2}";
                    }
                    else
                    {
                        lblResultado.Text = "Quadrilátero inválido!";
                    }
                }
            }
        }
    }
}