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
    public partial class PistaFacturaForm : Form
    {
        public PistaFacturaForm(string numeroPista, string codigoPista)
        {
            InitializeComponent();
            numPista = numeroPista;
            codPista = codigoPista;
        }

        AlquilerForm formularioAlquiler = new AlquilerForm();

        private string numPista = "", codPista = "";
        private int minutos1 = 0;
        private int totalVenta = 0;



        private void BtnAlquilar_Click(object sender, EventArgs e)
        {
            string inici = "";
            string entrega = "";
            string[] hora1 = { "0", "0" };
            string[] hora2 = { "0", "0" };

            
            if (btnAlquilar.Text == "Alquilar")
            {

                

                btnAlquilar.BackColor = Color.Red;
                inici = DateTime.Now.ToString(@"hh\:mm");
                txtHoraInicio.Text = inici;
                btnAlquilar.Text = "Finalizar Alquiler";
                hora1 = inici.Split(':');

                switch (lbNumPista.Text)
                {
                    case "1":
                        formularioAlquiler.llenarHoraInicioPista1(inici);
                        break;
                    case "2":
                        formularioAlquiler.llenarHoraInicioPista2(inici);
                        break;
                }

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
                btnAlquilar.BackColor = Color.Chartreuse;
                entrega = DateTime.Now.ToString(@"hh\:mm");
                txtHoraEntrega.Text = entrega;
                btnAlquilar.Text = "Alquilar";


                hora2 = entrega.Split(':');

                if (Convert.ToInt32(hora2[0]) > 0)
                {
                    minutos2 = (Convert.ToInt32(hora2[0]) * 60) + Convert.ToInt32(hora2[1]);
                }
                else
                {
                    minutos2 = Convert.ToInt32(hora2[1]);
                }

                if ((minutos2 - minutos1) >= 10)
                {
                    txtHoraJugada.Text = "00:" + (minutos2 - minutos1).ToString();
                }
                else {
                    txtHoraJugada.Text = "00:0" + (minutos2 - minutos1).ToString();
                }
                

            }
        }

        private void BtnOcultar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PistaFacturaForm_Load(object sender, EventArgs e)
        {
            dtgAux.Hide();
            lbNumPista.Text = numPista;
            llenarDataGrid();
            llenarComboboxEmpleado();
            llenarComboboxProductos();
        }

        private int minutos2 = 0;

        private void DtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdentificacion.Text = dtgClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtgClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dtgClientes.CurrentRow.Cells[2].Value.ToString();
        }

        private void BtnBuscarId_Click(object sender, EventArgs e)
        {
            string query = String.Format($"SELECT idcliente AS Identificacion, nombre AS Nombre, apellido AS Apellido FROM clientes WHERE idcliente LIKE '%{txtBuscarId.Text}%'");
            DataSet ds = Conexion.getQuery(query);
            if (ds != null)
            {
                dtgClientes.DataSource = ds.Tables[0];
            }
        }

        private void TxtBuscarId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            Form miFormCliente = new MiniClientesForm();
            miFormCliente.Show();
        }

        private void llenarDataGrid()
        {
            string query = String.Format($"SELECT idcliente AS Identificacion, nombre AS Nombre, apellido AS Apellido FROM clientes ");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                dtgClientes.DataSource = ds.Tables[0];
            }

        }
        

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if (txtHoraEntrega.Text != "") {
                int rows = dtgFactura.Rows.Count - 2;

                if (txtIdentificacion.Text != "" && rows >= 0)
                {

                    //Inserta en factura
                    string query = String.Format($"INSERT INTO factura (fecha_inicio, fecha_entrega, pista_id, total, empleado_id, cliente_id) VALUES ('{txtHoraInicio.Text}','{txtHoraEntrega.Text}','{codPista}','{Convert.ToInt32(txtTotal.Text)}','{combEmpleado.SelectedValue}','{txtIdentificacion.Text}')");
                    DataSet ds = Conexion.getQuery(query);

                    //Buscar la ultima factura
                    query = String.Format($"SELECT MAX(idfactura) FROM factura");
                    ds = Conexion.getQuery(query);
                    dtgAux.DataSource = ds.Tables[0];

                    //Inserta en productosfacturados
                    int indice = dtgFactura.Rows.Count - 2;
                    for (int i = 0; i <= indice; i++)
                    {
                        query = String.Format($"INSERT INTO productosfacturados VALUES ('{Convert.ToInt32(dtgAux.Rows[0].Cells[0].Value)}','{dtgFactura.Rows[i].Cells[0].Value}','{Convert.ToInt32(dtgFactura.Rows[i].Cells[3].Value)}')");
                        ds = Conexion.getQuery(query);
                    }

                    MessageBox.Show("Venta exitosa");
                    limpiarFormulario();
                }
                else {
                    MessageBox.Show("No ha seleccionado cliente o no ha agregado productos");
                }
                
            }
            else {
                MessageBox.Show("Aun el cliente no ha entregado la pista");
            }
            

        }

        

        private void BtnAgregarProd_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "" &&  combProductos.Text != "")
            {
                
                string query = String.Format($"SELECT idproducto AS Codigo, nombre AS Descripcion, costo AS 'Valor Unit.' FROM productos WHERE idproducto = '{combProductos.SelectedValue}' ");
                DataSet ds = Conexion.getQuery(query);


                if (ds != null)
                {
                    dtgAux.DataSource = ds.Tables[0];
                    int rows = dtgFactura.Rows.Count - 2;
                    int encontrado = 0;

                    for (int i=0;i<=rows;i++) {
                        if (dtgFactura.Rows[i].Cells[0].Value.ToString() == combProductos.SelectedValue.ToString())
                        {
                            MessageBox.Show("Producto ya esta en la lista");
                            dtgFactura.Rows[i].Cells[3].Value = (Convert.ToInt32(dtgFactura.Rows[i].Cells[3].Value)+Convert.ToInt32(txtCantidad.Text)).ToString();

                            dtgFactura.Rows[i].Cells[4].Value = Convert.ToInt32(dtgFactura.Rows[i].Cells[4].Value) + Convert.ToInt32(dtgFactura.Rows[i].Cells[2].Value) * Convert.ToInt32(txtCantidad.Text);
                            totalVenta += Convert.ToInt32(dtgFactura.Rows[i].Cells[2].Value)* Convert.ToInt32(txtCantidad.Text);
                            txtTotal.Text = totalVenta.ToString();
                            encontrado++;
                            break;
                        }
                    }

                    if (encontrado == 0) {
                        int indice = dtgFactura.Rows.Add();
                        dtgFactura.Rows[indice].Cells[0].Value = dtgAux.Rows[0].Cells[0].Value;
                        dtgFactura.Rows[indice].Cells[1].Value = dtgAux.Rows[0].Cells[1].Value;
                        dtgFactura.Rows[indice].Cells[2].Value = dtgAux.Rows[0].Cells[2].Value;
                        dtgFactura.Rows[indice].Cells[3].Value = txtCantidad.Text;
                        dtgFactura.Rows[indice].Cells[4].Value = (Convert.ToInt32(dtgFactura.Rows[indice].Cells[2].Value) * Convert.ToInt32(txtCantidad.Text)).ToString();
                        totalVenta += Convert.ToInt32(dtgFactura.Rows[indice].Cells[4].Value);
                        txtTotal.Text = totalVenta.ToString();
                    }

                    
                }
            }
            else {
                MessageBox.Show("No ha dijitado la cantidad");
            }
        }

        private void llenarComboboxProductos()
        {
            string query = String.Format($"SELECT idproducto, nombre FROM productos");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                combProductos.DataSource = ds.Tables[0];
                combProductos.DisplayMember = "nombre";
                combProductos.ValueMember = "idproducto";
            }
            
        }

        private void llenarComboboxEmpleado()
        {
            string query = String.Format($"SELECT idempleado, nombre FROM empleados");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                combEmpleado.DataSource = ds.Tables[0];
                combEmpleado.DisplayMember = "nombre";
                combEmpleado.ValueMember = "idempleado";
            }
            
        }

        private void TxtBuscarId_TextChanged(object sender, EventArgs e)
        {
            string query = String.Format($"SELECT idcliente AS Identificacion, nombre AS Nombre, apellido AS Apellido FROM clientes WHERE idcliente LIKE '%{txtBuscarId.Text}%'");
            DataSet ds = Conexion.getQuery(query);
            if (ds != null)
            {
                dtgClientes.DataSource = ds.Tables[0];
            }
        }

        private void limpiarFormulario()
        {
            txtHoraInicio.Text = "";
            txtHoraEntrega.Text = "";
            txtHoraJugada.Text = "";

            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

            txtTotal.Text = "";
            dtgFactura.Rows.Clear();
        }
    }
}
