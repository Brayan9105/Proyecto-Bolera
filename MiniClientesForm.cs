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
    public partial class MiniClientesForm : Form
    {
        public MiniClientesForm()
        {
            InitializeComponent();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloTexto(sender, e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloTexto(sender, e);
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && dateNacimiento.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                if (Validacion.emailValid(txtEmail.Text))
                {
                    registrarCliente();
                }
                else {
                    MessageBox.Show("Correo no valido");
                }
            }
            else {
                MessageBox.Show("Aun hay compos sin completar");
            }
            
        }

        private void registrarCliente()
        {
            string queryCount = String.Format($"SELECT COUNT(*) FROM clientes WHERE idcliente = '{txtCedula.Text}'");
            if (!Validacion.validarSiExisteRegistro(queryCount))
            {
                
                    string query = String.Format($"INSERT INTO clientes VALUES ('{txtCedula.Text}','{txtNombre.Text}','{txtApellido.Text}','{dateNacimiento.Value.ToString()}','{txtEmail.Text}',{txtTelefono.Text})");
                    Conexion.getQuery(query);

                    MessageBox.Show("Registro Existoso");
                    limpiarFormulario();
                
            }
            else
            {
                MessageBox.Show("La cedula ya se encuentra registrada en la base de datos");
            }
        }

        private void limpiarFormulario() {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateNacimiento.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }
    }
}
