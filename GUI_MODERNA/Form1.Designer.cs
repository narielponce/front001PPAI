
namespace GUI_MODERNA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnRes = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.PictureBox();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelSubMenuReport = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReportPagos = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportCompras = new System.Windows.Forms.Button();
            this.btnReporVtas = new System.Windows.Forms.Button();
            this.panelBtnRepor = new System.Windows.Forms.Panel();
            this.panelBtnPagos = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.panelBtnEmpl = new System.Windows.Forms.Panel();
            this.btnPagos = new System.Windows.Forms.Button();
            this.panelBtnComp = new System.Windows.Forms.Panel();
            this.btnEmple = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelBtnClie = new System.Windows.Forms.Panel();
            this.btnClient = new System.Windows.Forms.Button();
            this.panelBtnVent = new System.Windows.Forms.Panel();
            this.panelBtnProd = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnConsultaEncuesta = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.panelSubMenuReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.panelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barraTitulo.Controls.Add(this.btnRes);
            this.barraTitulo.Controls.Add(this.btnMin);
            this.barraTitulo.Controls.Add(this.btnMax);
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.barraTitulo.TabIndex = 0;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(1232, 7);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(25, 25);
            this.btnRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRes.TabIndex = 1;
            this.btnRes.TabStop = false;
            this.btnRes.Visible = false;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1202, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 23);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(1233, 7);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1263, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuVertical.Controls.Add(this.btnSalir);
            this.menuVertical.Controls.Add(this.panelSubMenuReport);
            this.menuVertical.Controls.Add(this.panelBtnRepor);
            this.menuVertical.Controls.Add(this.panelBtnPagos);
            this.menuVertical.Controls.Add(this.btnReports);
            this.menuVertical.Controls.Add(this.panelBtnEmpl);
            this.menuVertical.Controls.Add(this.btnPagos);
            this.menuVertical.Controls.Add(this.panelBtnComp);
            this.menuVertical.Controls.Add(this.btnEmple);
            this.menuVertical.Controls.Add(this.btnCompras);
            this.menuVertical.Controls.Add(this.panelBtnClie);
            this.menuVertical.Controls.Add(this.btnClient);
            this.menuVertical.Controls.Add(this.panelBtnVent);
            this.menuVertical.Controls.Add(this.panelBtnProd);
            this.menuVertical.Controls.Add(this.btnVentas);
            this.menuVertical.Controls.Add(this.btnConsultaEncuesta);
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 38);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(257, 612);
            this.menuVertical.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(18, 537);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(177, 63);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelSubMenuReport
            // 
            this.panelSubMenuReport.Controls.Add(this.panel5);
            this.panelSubMenuReport.Controls.Add(this.panel4);
            this.panelSubMenuReport.Controls.Add(this.btnReportPagos);
            this.panelSubMenuReport.Controls.Add(this.panel3);
            this.panelSubMenuReport.Controls.Add(this.btnReportCompras);
            this.panelSubMenuReport.Controls.Add(this.btnReporVtas);
            this.panelSubMenuReport.Location = new System.Drawing.Point(38, 367);
            this.panelSubMenuReport.Name = "panelSubMenuReport";
            this.panelSubMenuReport.Size = new System.Drawing.Size(176, 100);
            this.panelSubMenuReport.TabIndex = 0;
            this.panelSubMenuReport.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(3, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 28);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(3, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 28);
            this.panel4.TabIndex = 12;
            // 
            // btnReportPagos
            // 
            this.btnReportPagos.FlatAppearance.BorderSize = 0;
            this.btnReportPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportPagos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportPagos.ForeColor = System.Drawing.Color.White;
            this.btnReportPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportPagos.Location = new System.Drawing.Point(3, 72);
            this.btnReportPagos.Name = "btnReportPagos";
            this.btnReportPagos.Size = new System.Drawing.Size(176, 28);
            this.btnReportPagos.TabIndex = 11;
            this.btnReportPagos.Text = "Reporte Pagos";
            this.btnReportPagos.UseVisualStyleBackColor = true;
            this.btnReportPagos.Click += new System.EventHandler(this.btnReportPagos_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 28);
            this.panel3.TabIndex = 10;
            // 
            // btnReportCompras
            // 
            this.btnReportCompras.FlatAppearance.BorderSize = 0;
            this.btnReportCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReportCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportCompras.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportCompras.ForeColor = System.Drawing.Color.White;
            this.btnReportCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportCompras.Location = new System.Drawing.Point(3, 37);
            this.btnReportCompras.Name = "btnReportCompras";
            this.btnReportCompras.Size = new System.Drawing.Size(176, 28);
            this.btnReportCompras.TabIndex = 11;
            this.btnReportCompras.Text = "Reporte Compras";
            this.btnReportCompras.UseVisualStyleBackColor = true;
            this.btnReportCompras.Click += new System.EventHandler(this.btnReportCompras_Click);
            // 
            // btnReporVtas
            // 
            this.btnReporVtas.FlatAppearance.BorderSize = 0;
            this.btnReporVtas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReporVtas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporVtas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporVtas.ForeColor = System.Drawing.Color.White;
            this.btnReporVtas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporVtas.Location = new System.Drawing.Point(3, 3);
            this.btnReporVtas.Name = "btnReporVtas";
            this.btnReporVtas.Size = new System.Drawing.Size(176, 28);
            this.btnReporVtas.TabIndex = 9;
            this.btnReporVtas.Text = "Reporte Ventas";
            this.btnReporVtas.UseVisualStyleBackColor = true;
            this.btnReporVtas.Click += new System.EventHandler(this.btnReporVtas_Click);
            // 
            // panelBtnRepor
            // 
            this.panelBtnRepor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnRepor.Location = new System.Drawing.Point(15, 329);
            this.panelBtnRepor.Name = "panelBtnRepor";
            this.panelBtnRepor.Size = new System.Drawing.Size(5, 32);
            this.panelBtnRepor.TabIndex = 9;
            // 
            // panelBtnPagos
            // 
            this.panelBtnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnPagos.Location = new System.Drawing.Point(15, 291);
            this.panelBtnPagos.Name = "panelBtnPagos";
            this.panelBtnPagos.Size = new System.Drawing.Size(5, 32);
            this.panelBtnPagos.TabIndex = 7;
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(26, 329);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(225, 32);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "Reportes";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panelBtnEmpl
            // 
            this.panelBtnEmpl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnEmpl.Location = new System.Drawing.Point(15, 253);
            this.panelBtnEmpl.Name = "panelBtnEmpl";
            this.panelBtnEmpl.Size = new System.Drawing.Size(5, 32);
            this.panelBtnEmpl.TabIndex = 7;
            // 
            // btnPagos
            // 
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagos.Location = new System.Drawing.Point(26, 291);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(225, 32);
            this.btnPagos.TabIndex = 8;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            // 
            // panelBtnComp
            // 
            this.panelBtnComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnComp.Location = new System.Drawing.Point(15, 215);
            this.panelBtnComp.Name = "panelBtnComp";
            this.panelBtnComp.Size = new System.Drawing.Size(5, 32);
            this.panelBtnComp.TabIndex = 5;
            // 
            // btnEmple
            // 
            this.btnEmple.FlatAppearance.BorderSize = 0;
            this.btnEmple.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnEmple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmple.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmple.ForeColor = System.Drawing.Color.White;
            this.btnEmple.Image = ((System.Drawing.Image)(resources.GetObject("btnEmple.Image")));
            this.btnEmple.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmple.Location = new System.Drawing.Point(26, 253);
            this.btnEmple.Name = "btnEmple";
            this.btnEmple.Size = new System.Drawing.Size(225, 32);
            this.btnEmple.TabIndex = 8;
            this.btnEmple.Text = "Empleados";
            this.btnEmple.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(26, 215);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(225, 32);
            this.btnCompras.TabIndex = 6;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // panelBtnClie
            // 
            this.panelBtnClie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnClie.Location = new System.Drawing.Point(15, 177);
            this.panelBtnClie.Name = "panelBtnClie";
            this.panelBtnClie.Size = new System.Drawing.Size(5, 32);
            this.panelBtnClie.TabIndex = 3;
            // 
            // btnClient
            // 
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(26, 177);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(225, 32);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "Clientes";
            this.btnClient.UseVisualStyleBackColor = true;
            // 
            // panelBtnVent
            // 
            this.panelBtnVent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnVent.Location = new System.Drawing.Point(15, 139);
            this.panelBtnVent.Name = "panelBtnVent";
            this.panelBtnVent.Size = new System.Drawing.Size(5, 32);
            this.panelBtnVent.TabIndex = 1;
            // 
            // panelBtnProd
            // 
            this.panelBtnProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panelBtnProd.Location = new System.Drawing.Point(15, 101);
            this.panelBtnProd.Name = "panelBtnProd";
            this.panelBtnProd.Size = new System.Drawing.Size(5, 32);
            this.panelBtnProd.TabIndex = 0;
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(26, 139);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(225, 32);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnConsultaEncuesta
            // 
            this.btnConsultaEncuesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultaEncuesta.FlatAppearance.BorderSize = 0;
            this.btnConsultaEncuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnConsultaEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaEncuesta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaEncuesta.ForeColor = System.Drawing.Color.White;
            this.btnConsultaEncuesta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaEncuesta.Image")));
            this.btnConsultaEncuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaEncuesta.Location = new System.Drawing.Point(26, 101);
            this.btnConsultaEncuesta.Name = "btnConsultaEncuesta";
            this.btnConsultaEncuesta.Size = new System.Drawing.Size(225, 32);
            this.btnConsultaEncuesta.TabIndex = 0;
            this.btnConsultaEncuesta.Text = "Consultar encuesta";
            this.btnConsultaEncuesta.UseVisualStyleBackColor = true;
            this.btnConsultaEncuesta.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(12, 6);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(239, 75);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Controls.Add(this.panel1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(257, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1043, 612);
            this.panelContenedor.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 612);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.barraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.panelSubMenuReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Panel panelContenedor;
        //private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMin;
        private System.Windows.Forms.PictureBox btnRes;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Button btnConsultaEncuesta;
        private System.Windows.Forms.Panel panelBtnProd;
        private System.Windows.Forms.Panel panelBtnComp;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panelBtnClie;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Panel panelBtnVent;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelBtnPagos;
        private System.Windows.Forms.Panel panelBtnEmpl;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnEmple;
        private System.Windows.Forms.Panel panelBtnRepor;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panelSubMenuReport;
        private System.Windows.Forms.Button btnReporVtas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReportPagos;
        private System.Windows.Forms.Button btnReportCompras;
        private System.Windows.Forms.Button btnSalir;
    }
}

