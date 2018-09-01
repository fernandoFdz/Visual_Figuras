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

        static void Changed(object sender, EventArgs e)
        {
            //ejemplo evento
            CCirculo c = (CCirculo)sender;
            MessageBox.Show("el valor cambio: " + c.Diametro.ToString());
        }

        static void Changed2(object sender, EventArgs e)
        {
            //ejemplo evento
            CRectangulo c = (CRectangulo)sender;
            MessageBox.Show("el valor cambio: " + c.Lado.ToString());
        }

        static void Changed3(object sender, EventArgs e)
        {
            //ejemplo evento
            Triangulo c = (Triangulo)sender;
            MessageBox.Show("el valor 1 cambio: " + c.Base.ToString() + "el valor 2 cambio:" + c.Altura.ToString());
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
                            cir.Changed += new EventHandler(Changed);
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
                            tri.Changed3 += new EventHandler(Changed3);
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
                            cuadrado.Changed2 += new EventHandler(Changed2);                  
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
                            cir.Changed += new EventHandler(Changed);
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
                            tri.Changed3 += new EventHandler(Changed3);
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
                            cuadrado.Changed2 += new EventHandler(Changed2);
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
