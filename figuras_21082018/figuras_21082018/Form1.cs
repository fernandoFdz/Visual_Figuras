using System;
using System.Windows.Forms;

namespace figuras_21082018
{
    public partial class Form1 : Form
    {
        Figura Fig;
        CCirculo cir;
        CRectangulo cuadrado;
        Triangulo tri;
        
        public Form1()
        {
            InitializeComponent();
            Fig = new Figura();
            cir = new CCirculo();
            cuadrado = new CRectangulo();
            tri = new Triangulo();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           //bLista.SelectedItem
        }

        private void cbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbLista.SelectedIndex;
          //  MessageBox.Show("cambio " + selectedIndex);
            switch (selectedIndex)
            {
                case 0:
                    tbDato1.Enabled = true;
                    btCalcular.Enabled = true;
                    rbArea.Enabled = true;
                    rbPerimetro.Enabled = true;  
                    
                            
                break;
                case 1:
                    tbDato1.Enabled = true;
                    tbDato2.Enabled = true;
                    btCalcular.Enabled = true;
                    rbArea.Enabled = true;
                    rbPerimetro.Enabled = true;
                    break;
                case 2:
                    tbDato1.Enabled = true;
                    btCalcular.Enabled = true;
                    rbArea.Enabled = true;
                    rbPerimetro.Enabled = true;
                    break;

            }
            

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int selectedIndex = cbLista.SelectedIndex;

            if (rbPerimetro.Checked == false && rbArea.Checked == false)
            {
                MessageBox.Show("no selecciono una opcion");
            }

            if (rbArea.Checked == true)
            {
                switch (selectedIndex)
                {
                    case 0:
                        try
                        {
                            cir.Diametro = float.Parse(tbDato1.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        

                        MessageBox.Show("El Area es: " + Convert.ToString(cir.CalcularArea()));

                        break;
                    case 1:
                        try
                        { 
                        tri.Altura = float.Parse(tbDato1.Text);
                        tri.Base = float.Parse(tbDato2.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        MessageBox.Show("El Area es: " + Convert.ToString(tri.CalcularArea()));

                        break;
                    case 2:
                        try
                        {                           
                        cuadrado.Lado = float.Parse(tbDato1.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        MessageBox.Show("El Area es: " + Convert.ToString(cuadrado.CalcularArea()));
                        
                        break;

                }
            }

            if (rbPerimetro.Checked == true)
            {
                switch (selectedIndex)
                {
                    case 0:
                        try
                        {
                        cir.Diametro = float.Parse(tbDato1.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        MessageBox.Show("Perimetro: " + Convert.ToString(cir.CalcularPerimetro()));

                        break;
                    case 1:
                        try
                        { 
                        tri.Altura = float.Parse(tbDato1.Text);
                        tri.Base = float.Parse(tbDato2.Text);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        MessageBox.Show("El Perimetro es: " + Convert.ToString(tri.CalcularPerimetro()));

                        break;
                    case 2:
                        try { 
                        cuadrado.Lado = Convert.ToInt32(tbDato1);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        MessageBox.Show("Perimetro: " + Convert.ToString(cuadrado.CalcularPerimetro()));

                        break;

                }
            }
        }
    }
}
