using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBolera
{
    public partial class FacturaForm : Form
    {
        public FacturaForm(string numeroPista, string codigoPista)
        {
            InitializeComponent();
            numPista = numeroPista;
            codPista = codigoPista;
        }

        private string numPista = "", codPista="";

        private void AlquilerPistaForm_Load(object sender, EventArgs e)
        {
            lbNumPista.Text = numPista;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }

        int minutos1 = 0;
        int minutos2 = 0;

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
            AlquilerForm.pista2 = null;
        }

        private void BtnAlquilar_Click(object sender, EventArgs e)
        {
            string inici = "";
            string entrega = "";
            string[] hora1 = { "0", "0" };
            string[] hora2 = { "0", "0" };

            MessageBox.Show("algo");
            if (button5.Text == "Alquilar")
            {
                inici = DateTime.Now.ToString(@"hh\:mm");
                txtHoraInicio.Text = inici;
                button5.Text = "Facturar";
                hora1 = inici.Split(':');

                if (Convert.ToInt32(hora1[0]) > 0)
                {
                    minutos1 = (Convert.ToInt32(hora1[0]) * 60) + Convert.ToInt32(hora1[1]);
                }
                else
                {
                    minutos1 = Convert.ToInt32(hora1[1]);
                }


            }
            else
            {
                entrega = DateTime.Now.ToString(@"hh\:mm");
                txtHoraEntrega.Text = entrega;
                button5.Text = "Alquilar";


                hora2 = entrega.Split(':');

                if (Convert.ToInt32(hora2[0]) > 0)
                {
                    minutos2 = (Convert.ToInt32(hora2[0]) * 60) + Convert.ToInt32(hora2[1]);
                }
                else
                {
                    minutos2 = Convert.ToInt32(hora2[1]);
                }

                txtHoraJugada.Text = (minutos2 - minutos1).ToString();

            }
        }

        
    }
}
