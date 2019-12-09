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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void llenarGrafica1() {
            string query = String.Format($"SELECT COUNT(idfactura) AS cantidad , empleados.nombre FROM factura Inner JOIN empleados ON empleados.idempleado = factura.empleado_id GROUP BY empleados.nombre");
            DataSet ds = Conexion.getQuery(query);

            chart1.Series["Series1"].LegendText = "Grafica";
            chart1.Series["Series1"].XValueMember = "nombre";
            chart1.Series["Series1"].YValueMembers = "cantidad";
            chart1.DataSource = ds.Tables[0];
        }

        private void llenarGrafica2()
        {
            string query = String.Format($"SELECT (cantidad/COUNT(idfactura)) * 100 AS Porcentaje, pistas.nombre AS Pista FROM factura, (SELECT COUNT(idfactura) AS cantidad,pista_id FROM factura GROUP BY pista_id) AS tabla1 INNER JOIN pistas ON pistas.idpista = tabla1.pista_id GROUP BY Pista");
            DataSet ds = Conexion.getQuery(query);

            chart2.Series["Series1"].LegendText = "Pista";
            chart2.Series["Series1"].XValueMember = "Pista";
            chart2.Series["Series1"].YValueMembers = "Porcentaje";
            chart2.DataSource = ds.Tables[0];
        }

        private void llenarLbFacturasTotales() {
            string query = String.Format($"SELECT COUNT(*) AS Facturas FROM factura");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null) {
                lbTotalFactura.Text = ds.Tables[0].Rows[0]["Facturas"].ToString();
            }
        }

        private void llenarLbNumEmpleados()
        {
            string query = String.Format($"SELECT COUNT(*) AS empleados FROM empleados");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                lbNumEmpleados.Text = ds.Tables[0].Rows[0]["empleados"].ToString();
            }
        }

        private void llenarLbTotalVendido()
        {
            string query = String.Format($"SELECT SUM(total) AS total From factura");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                lbTotalRecaudado.Text = "$"+ds.Tables[0].Rows[0]["total"].ToString();
            }
        }
        


        private void llenarLbNumClientes()
        {
            string query = String.Format($"SELECT COUNT(*) AS clientes FROM clientes");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                lbNumClientes.Text = ds.Tables[0].Rows[0]["clientes"].ToString();
            }
        }

        private void llenarLbEmpleadoMayorVenta()
        {
            string query = String.Format($"SELECT MAX(total) AS total, empleados.nombre AS empleado FROM factura INNER JOIN empleados ON empleados.idempleado = factura.empleado_id");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                lbNomEmpleMayVen.Text = ds.Tables[0].Rows[0]["empleado"].ToString();
                lbMayorMonto.Text = ds.Tables[0].Rows[0]["total"].ToString();
            }
        }

        private void llenarLbClientMAyorVenta()
        {
            string query = String.Format($"SELECT MAX(total) AS total, clientes.nombre AS cliente FROM factura INNER JOIN clientes ON clientes.idcliente = factura.cliente_id");
            DataSet ds = Conexion.getQuery(query);

            if (ds != null)
            {
                lbClienteMayorVen.Text = ds.Tables[0].Rows[0]["cliente"].ToString();
                lbMontoMayorCli.Text = ds.Tables[0].Rows[0]["total"].ToString();
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            llenarGrafica1();
            llenarGrafica2();
            llenarLbFacturasTotales();
            llenarLbNumEmpleados();
            llenarLbTotalVendido();
            llenarLbNumClientes();
            llenarLbEmpleadoMayorVenta();
            llenarLbClientMAyorVenta();
        }
    }
}
