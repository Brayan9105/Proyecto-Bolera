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
    public partial class AlquilerForm : Form
    {
        public static Form pista1 = null, pista2 = null;

        public AlquilerForm()
        {
            InitializeComponent();
        }

        
        public void llenarHoraInicioPista1(string hora) {
            //lbGlobalPista1.Text = "";
        }

        public void llenarHoraInicioPista2(string hora)
        {
            lbGlobalPista2.Text = hora;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (pista2 == null)
            {

                pista2 = new PistaFacturaForm("2","pis2");
                openChildForm(pista2);
                
            }
            else {
                pista2.Show();
            }
        }


        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            if (pista1 == null)
            {
                pista1 = new PistaFacturaForm("1", "pis1");
                openChildForm(pista1);
                
            }
            else {
                pista1.Show();
            }
        }

        private void AlquilerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            alquilerPanel.Controls.Add(childForm);
            alquilerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
