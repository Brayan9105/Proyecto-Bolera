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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void login() {
            string query = String.Format($"SELECT COUNT(*) FROM usuarios WHERE usuario = '{txtIdentificacion.Text}'");
            if (Validacion.validarSiExisteRegistro(query))
            {
                query = String.Format($"SELECT usuario, passw,tipoempleado.nombre AS Roll FROM usuarios INNER JOIN tipoempleado ON tipoempleado.idtipo = usuarios.tipousuario WHERE usuario = '{txtIdentificacion.Text}'");
                DataSet ds = Conexion.getQuery(query);

                string user = ds.Tables[0].Rows[0]["usuario"].ToString().Trim();
                string password = ds.Tables[0].Rows[0]["passw"].ToString().Trim();
                string roll = ds.Tables[0].Rows[0]["Roll"].ToString().Trim();

                if (user.Equals(txtIdentificacion.Text) && password.Equals(txtPassword.Text))
                {
                    MainForm mainf = new MainForm(roll);
                    mainf.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña errada");
                }

            }
            else {
                MessageBox.Show("Usuario o contraseña errada");
            }
            
        }

      

       

        private void BtnConectar_Click_1(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text != "" && txtPassword.Text != "")
            {
                login();
            }
        }
    }
}
