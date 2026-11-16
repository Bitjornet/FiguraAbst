using System;
using System.Windows.Forms;
using FiguraAbst;

namespace FiguraAbst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbFigura.SelectedIndex = 0; // Selecciona "Cuadrado" por defecto
        }

        private void cmbFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarCampos();
            string seleccion = cmbFigura.SelectedItem.ToString();

            if (seleccion == "Cuadrado")
            {
                lblDato1.Text = "Lado:";
                MostrarCamposTriangulo(false);
            }
            else if (seleccion == "Círculo")
            {
                lblDato1.Text = "Radio:";
                MostrarCamposTriangulo(false);
            }
            else if (seleccion == "Triángulo")
            {
                lblDato1.Text = "Base:";
                MostrarCamposTriangulo(true);
            }
        }

        private void MostrarCamposTriangulo(bool visible)
        {
            lblDato2.Visible = txtDato2.Visible = visible;
            lblDato3.Visible = txtDato3.Visible = visible;
            lblDato4.Visible = txtDato4.Visible = visible;
            lblDato5.Visible = txtDato5.Visible = visible;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string seleccion = cmbFigura.SelectedItem.ToString();
            Figuras figura = null;

            if (seleccion == "Cuadrado")
            {
                if (!float.TryParse(txtDato1.Text, out float lado))
                {
                    MessageBox.Show("Ingresa un valor numérico válido para el lado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Cuadrado cu = new Cuadrado(lado);
                cu.NombreFig = "Cuadrado";
                figura = cu;
            }
            else if (seleccion == "Círculo")
            {
                if (!float.TryParse(txtDato1.Text, out float radio))
                {
                    MessageBox.Show("Ingresa un valor numérico válido para el radio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Circulo cir = new Circulo(radio);
                cir.NombreFig = "Círculo";
                figura = cir;
            }
            else if (seleccion == "Triángulo")
            {
                if (!float.TryParse(txtDato1.Text, out float baseT) ||
                    !float.TryParse(txtDato2.Text, out float altura) ||
                    !float.TryParse(txtDato3.Text, out float l1) ||
                    !float.TryParse(txtDato4.Text, out float l2) ||
                    !float.TryParse(txtDato5.Text, out float l3))
                {
                    MessageBox.Show("Ingresa valores numéricos válidos para todos los datos del triángulo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Triangulo tri = new Triangulo(baseT, altura, l1, l2, l3);
                tri.NombreFig = "Triángulo";
                figura = tri;
            }

            if (figura != null)
            {
                lblFiguraRes.Text = "Figura: " + figura.NombreFig;
                lblArea.Text = "Área: " + figura.Area().ToString("0.00");
                lblPerimetro.Text = "Perímetro: " + figura.Perimetro().ToString("0.00");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDato1.Clear();
            txtDato2.Clear();
            txtDato3.Clear();
            txtDato4.Clear();
            txtDato5.Clear();
            lblFiguraRes.Text = "Figura: -";
            lblArea.Text = "Área: -";
            lblPerimetro.Text = "Perímetro: -";
            txtDato1.Focus();
        }
    }
}