using System;
using System.Collections;
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
    public partial class EmpleadosForm : Form
    {
        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloTexto( sender,  e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloTexto(sender, e);
        }


        private void registrarEmpleado() {
            string queryCount = String.Format($"SELECT COUNT(*) FROM empleados WHERE idempleado = '{txtCedula.Text}'");
            if (!Validacion.validarSiExisteRegistro(queryCount))
            {
                queryCount = String.Format($"SELECT COUNT(*) FROM usuarios WHERE usuario = '{txtUser.Text}'");
                if (!Validacion.validarSiExisteRegistro(queryCount))
                {
                    string query = String.Format($"INSERT INTO empleados VALUES ('{txtCedula.Text}','{txtNombre.Text}','{txtApellido.Text}','{combTipUsuario.SelectedValue.ToString()}')");
                    Conexion.getQuery(query);

                    query = String.Format($"INSERT INTO usuarios (usuario, passw, idempleado, tipousuario) VALUES ('{txtUser.Text}','{txtPassword.Text}','{txtCedula.Text}','{combTipUsuario.SelectedValue.ToString()}')");
                    Conexion.getQuery(query);

                    MessageBox.Show("Registro Existoso");

                    llenarDataGrid();
                    limpiarFormulario();
                }
                else {
                    MessageBox.Show("El usuario ya se encuentra registrada en la base de datos");
                }
            }
            else {
                MessageBox.Show("La cedula ya se encuentra registrada en la base de datos");
            }
        }


        private void actualizarEmpleado() {

            string query = String.Format($"UPDATE empleados SET nombre = '{txtNombre.Text}', apellido = '{txtApellido.Text}', tipo_empleadoid ='{combTipUsuario.SelectedValue.ToString()}' WHERE idempleado = '{txtCedula.Text}'");
            Conexion.getQuery(query);

            query = String.Format($"UPDATE usuarios SET passw = '{txtPassword.Text}', tipousuario ='{combTipUsuario.SelectedValue.ToString()}' WHERE usuario = '{txtUser.Text}'");
            Conexion.getQuery(query);

            limpiarFormulario();
            llenarDataGrid();

            MessageBox.Show("Se ha actualizado el registro con exito");
        }


        private void llenarDataGrid() {
            string query = String.Format($"SELECT empleados.idempleado AS Identificacion, empleados.nombre AS Nombre, apellido, tipoempleado.nombre AS Categoria, usuario, passw FROM empleados INNER JOIN tipoempleado ON tipoempleado.idtipo = empleados.tipo_empleadoid INNER JOIN usuarios ON usuarios.idempleado = empleados.idempleado");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                dtgEmpleados.DataSource = ds.Tables[0];
            }
            
        }

        private void llenarCombobox() {
            string query = String.Format($"SELECT idtipo, nombre FROM tipoempleado");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                combTipUsuario.DataSource = ds.Tables[0];
                combTipUsuario.DisplayMember = "nombre";
                combTipUsuario.ValueMember = "idtipo";
            }
            //combTipUsuario.SelectedValue.ToString()
        }

        private void limpiarFormulario() {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            combTipUsuario.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarCamporVacios())
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    if (Validacion.validarPassword(txtPassword.Text))
                    {
                        registrarEmpleado();
                    }
                }
                else
                {
                    actualizarEmpleado();
                }
            }else {
                MessageBox.Show("Faltan datos por completar");
            }
            
        }

        private bool validarCamporVacios() {
            bool valido = false;
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtPassword.Text != "" && txtUser.Text != "") {
                valido = true;
            }

            return valido;
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Registrar";
            txtCedula.Enabled = true;
            txtUser.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Actualizar";
            txtCedula.Enabled = false;
            txtUser.Enabled = false;
            limpiarFormulario();
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            llenarDataGrid();
            llenarCombobox();
            llenarCombFiltrar();
        }

        private void DtgEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dtgEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtgEmpleados.CurrentRow.Cells[2].Value.ToString();
            combTipUsuario.Text = dtgEmpleados.CurrentRow.Cells[3].Value.ToString();

            txtUser.Text = dtgEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = dtgEmpleados.CurrentRow.Cells[5].Value.ToString();
            //string query = String.Format($"SELECT idempleado AS Identificacion, empleados.nombre AS Nombre, apellido, tipo_empleadoid AS TipoID, tipoempleado.nombre AS Categoria, usuario, passw FROM empleados INNER JOIN tipoempleado ON tipoempleado.idtipo = empleados.tipo_empleadoid INNER JOIN usuarios ON usuarios.idempleado = empleados.idempleado");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            string query = String.Format($"SELECT empleados.idempleado AS Identificacion, empleados.nombre AS Nombre, apellido, tipoempleado.nombre AS Categoria, usuario, passw FROM empleados INNER JOIN tipoempleado ON tipoempleado.idtipo = empleados.tipo_empleadoid INNER JOIN usuarios ON usuarios.idempleado = empleados.idempleado WHERE {combFiltrar.SelectedValue} LIKE '%{txtBuscar.Text}%'");
            DataSet ds = Conexion.getQuery(query);
            if (ds != null)
            {
                dtgEmpleados.DataSource = ds.Tables[0];
            }
            

        }

        private void llenarCombFiltrar() {
           
            var items = new List<Options>
            {
                new Options() { Name="Identificacion", Value="empleados.idempleado"},
                new Options() { Name="Nombre", Value="empleados.nombre"},
                new Options() { Name="Apellido", Value="empleados.apellido"},
                new Options() { Name="Categoria", Value="tipoempleado.nombre"},
                new Options() { Name="Usuario", Value="usuarios.usuario"},
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
    }
}
