namespace ProyectoBolera
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotalFactura = new System.Windows.Forms.Label();
            this.lbNumEmpleados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTotalRecaudado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumClientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMayorMonto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbNomEmpleMayVen = new System.Windows.Forms.Label();
            this.lbClienteMayorVen = new System.Windows.Forms.Label();
            this.lbMontoMayorCli = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea3.AxisY.LineColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            legend3.Enabled = false;
            legend3.ForeColor = System.Drawing.Color.White;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(15, 24);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(274, 165);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(15, 21);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(274, 167);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(25, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 65;
            this.label8.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(29, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 198);
            this.panel3.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.chart2);
            this.panel1.Location = new System.Drawing.Point(29, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 198);
            this.panel1.TabIndex = 68;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel4.Controls.Add(this.lbTotalFactura);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(400, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 81);
            this.panel4.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de facturas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel5.Controls.Add(this.lbNumEmpleados);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(586, 62);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 81);
            this.panel5.TabIndex = 70;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel6.Controls.Add(this.lbNumClientes);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(586, 166);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 81);
            this.panel6.TabIndex = 72;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.lbTotalRecaudado);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(400, 166);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(164, 81);
            this.panel7.TabIndex = 71;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel8.Controls.Add(this.lbClienteMayorVen);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.lbMontoMayorCli);
            this.panel8.Location = new System.Drawing.Point(586, 269);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 81);
            this.panel8.TabIndex = 72;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel9.Controls.Add(this.lbNomEmpleMayVen);
            this.panel9.Controls.Add(this.lbMayorMonto);
            this.panel9.Controls.Add(this.label6);
            this.panel9.Location = new System.Drawing.Point(400, 269);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(164, 81);
            this.panel9.TabIndex = 71;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Numero de pistas vendidas por empleado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(15, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Porcentaje de alquiler por pista";
            // 
            // lbTotalFactura
            // 
            this.lbTotalFactura.AutoSize = true;
            this.lbTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalFactura.Location = new System.Drawing.Point(70, 46);
            this.lbTotalFactura.Name = "lbTotalFactura";
            this.lbTotalFactura.Size = new System.Drawing.Size(20, 20);
            this.lbTotalFactura.TabIndex = 1;
            this.lbTotalFactura.Text = "N";
            // 
            // lbNumEmpleados
            // 
            this.lbNumEmpleados.AutoSize = true;
            this.lbNumEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumEmpleados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumEmpleados.Location = new System.Drawing.Point(71, 46);
            this.lbNumEmpleados.Name = "lbNumEmpleados";
            this.lbNumEmpleados.Size = new System.Drawing.Size(20, 20);
            this.lbNumEmpleados.TabIndex = 3;
            this.lbNumEmpleados.Text = "N";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(25, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Numero de empleados";
            // 
            // lbTotalRecaudado
            // 
            this.lbTotalRecaudado.AutoSize = true;
            this.lbTotalRecaudado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRecaudado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotalRecaudado.Location = new System.Drawing.Point(47, 46);
            this.lbTotalRecaudado.Name = "lbTotalRecaudado";
            this.lbTotalRecaudado.Size = new System.Drawing.Size(20, 20);
            this.lbTotalRecaudado.TabIndex = 3;
            this.lbTotalRecaudado.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(35, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Recaudado";
            // 
            // lbNumClientes
            // 
            this.lbNumClientes.AutoSize = true;
            this.lbNumClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNumClientes.Location = new System.Drawing.Point(71, 50);
            this.lbNumClientes.Name = "lbNumClientes";
            this.lbNumClientes.Size = new System.Drawing.Size(20, 20);
            this.lbNumClientes.TabIndex = 5;
            this.lbNumClientes.Text = "N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(34, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de clientes";
            // 
            // lbMayorMonto
            // 
            this.lbMayorMonto.AutoSize = true;
            this.lbMayorMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMayorMonto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMayorMonto.Location = new System.Drawing.Point(47, 57);
            this.lbMayorMonto.Name = "lbMayorMonto";
            this.lbMayorMonto.Size = new System.Drawing.Size(20, 20);
            this.lbMayorMonto.TabIndex = 5;
            this.lbMayorMonto.Text = "N";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(3, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Empleado con la vanta mas alta";
            // 
            // lbNomEmpleMayVen
            // 
            this.lbNomEmpleMayVen.AutoSize = true;
            this.lbNomEmpleMayVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomEmpleMayVen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNomEmpleMayVen.Location = new System.Drawing.Point(57, 32);
            this.lbNomEmpleMayVen.Name = "lbNomEmpleMayVen";
            this.lbNomEmpleMayVen.Size = new System.Drawing.Size(20, 20);
            this.lbNomEmpleMayVen.TabIndex = 2;
            this.lbNomEmpleMayVen.Text = "N";
            // 
            // lbClienteMayorVen
            // 
            this.lbClienteMayorVen.AutoSize = true;
            this.lbClienteMayorVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClienteMayorVen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbClienteMayorVen.Location = new System.Drawing.Point(58, 32);
            this.lbClienteMayorVen.Name = "lbClienteMayorVen";
            this.lbClienteMayorVen.Size = new System.Drawing.Size(20, 20);
            this.lbClienteMayorVen.TabIndex = 6;
            this.lbClienteMayorVen.Text = "N";
            // 
            // lbMontoMayorCli
            // 
            this.lbMontoMayorCli.AutoSize = true;
            this.lbMontoMayorCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoMayorCli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMontoMayorCli.Location = new System.Drawing.Point(48, 57);
            this.lbMontoMayorCli.Name = "lbMontoMayorCli";
            this.lbMontoMayorCli.Size = new System.Drawing.Size(20, 20);
            this.lbMontoMayorCli.TabIndex = 8;
            this.lbMontoMayorCli.Text = "N";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(7, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Cliente con la compra mas alta";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalFactura;
        private System.Windows.Forms.Label lbNumEmpleados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTotalRecaudado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNomEmpleMayVen;
        private System.Windows.Forms.Label lbMayorMonto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbClienteMayorVen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbMontoMayorCli;
    }
}