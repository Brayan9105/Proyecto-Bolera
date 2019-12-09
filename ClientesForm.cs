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
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void llenarDataGrid() {
            string query = String.Format($"SELECT idcliente AS Identificacion, nombre AS Nombre, apellido AS Apellido, correo, telefono FROM clientes");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                dtgClientes.DataSource = ds.Tables[0];
            }
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
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
                llenarDataGrid();

            }
            else
            {
                MessageBox.Show("La cedula ya se encuentra registrada en la base de datos");
            }
        }

        private void actualizarRegistro() {

            string query = String.Format($"UPDATE clientes SET nombre = '{txtNombre.Text}', apellido = '{txtApellido.Text}', fecha_nacimiento ='{dateNacimiento.Value.ToString()}', correo = '{txtEmail.Text}', telefono = '{txtTelefono.Text}' WHERE idempleado = '{txtCedula.Text}' WHERE idcliente = '{txtCedula.Text}'");
            Conexion.getQuery(query);


            limpiarFormulario();
            llenarDataGrid();
            

            MessageBox.Show("Se ha actualizado el registro con exito");
        }

        private void limpiarFormulario()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dateNacimiento.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && dateNacimiento.Text != "" && txtEmail.Text != "" && txtTelefono.Text != "")
            {
                if (Validacion.emailValid(txtEmail.Text))
                {
                    if (btnBuscar.Text == "Registrar")
                    {
                        registrarCliente();
                        
                    }
                    else {
                        actualizarRegistro();
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show("Correo no valido");
                }
            }
            else
            {
                MessageBox.Show("Aun hay compos sin completar");
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Text = "Registrar";
            txtCedula.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Text = "Actualizar";
            txtCedula.Enabled = false;
            limpiarFormulario();
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            llenarDataGrid();
            llenarCombFiltrar();
        }


      

        private void llenarCombFiltrar()
        {

            var items = new List<Options>
            {
                new Options() { Name="Identificacion", Value="clientes.idcliente"},
                new Options() { Name="Nombre", Value="clientes.nombre"},
                new Options() { Name="Apellido", Value="clientes.apellido"},
                
            };

            combFiltrar.DataSource = items;
            combFiltrar.DisplayMember = "Name";
            combFiltrar.ValueMember = "Value";
        }

        public class Options
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            string query = String.Format($"SELECT idcliente AS Identificacion, nombre AS Nombre, apellido AS Apellido, correo, telefono FROM clientes WHERE {combFiltrar.SelectedValue} LIKE '%{txtBuscar.Text}%'");
            DataSet ds = Conexion.getQuery(query);
            if (ds != null)
            {
                dtgClientes.DataSource = ds.Tables[0];
            }
        }

        private void DtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString(); ;
            txtApellido.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString(); ;
           
            txtEmail.Text = dtgClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dtgClientes.CurrentRow.Cells[4].Value.ToString(); ;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void CombFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
