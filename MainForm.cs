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
    public partial class MainForm : Form
    {
        public MainForm(string roll)
        {
            InitializeComponent();
            if (roll != "Administrador")
            {
                btnClientes.Hide();
                btnPistas.Hide();
                btnUsuarios.Hide();
                btnProductos.Hide();
                btnClientes.Hide();
                btnDashboard.Hide();
                btnAlquiler.Hide();
                openChildForm(new AlquilerForm());
            }
            else {
                
                btnPistas.Hide();
                btnProductos.Hide();
            }
        }


        Form currentForm = null;
        private void openChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new EmpleadosForm());
        }

        private void BtnAlquiler_Click(object sender, EventArgs e)
        {
            openChildForm(new AlquilerForm());
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientesForm());
        }

        private void BtnSalirMain_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }
    }
}
