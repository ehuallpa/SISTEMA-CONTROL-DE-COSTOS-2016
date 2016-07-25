namespace ProyectoFacturas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioAPM = new System.Windows.Forms.RadioButton();
            this.radioUNIMAR = new System.Windows.Forms.RadioButton();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblFecEmision = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblServIntegral = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtFecEmision = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtServIntegral = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblAdjunto = new System.Windows.Forms.Label();
            this.txtRutaAdjunto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.lblMnsjAlerta = new System.Windows.Forms.Label();
            this.btnSubirFact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioAPM
            // 
            this.radioAPM.AutoSize = true;
            this.radioAPM.Checked = true;
            this.radioAPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAPM.Location = new System.Drawing.Point(45, 73);
            this.radioAPM.Name = "radioAPM";
            this.radioAPM.Size = new System.Drawing.Size(117, 20);
            this.radioAPM.TabIndex = 0;
            this.radioAPM.TabStop = true;
            this.radioAPM.Text = "APM INLAND";
            this.radioAPM.UseVisualStyleBackColor = true;
            this.radioAPM.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioUNIMAR
            // 
            this.radioUNIMAR.AutoSize = true;
            this.radioUNIMAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUNIMAR.Location = new System.Drawing.Point(45, 137);
            this.radioUNIMAR.Name = "radioUNIMAR";
            this.radioUNIMAR.Size = new System.Drawing.Size(85, 20);
            this.radioUNIMAR.TabIndex = 1;
            this.radioUNIMAR.Text = "UNIMAR";
            this.radioUNIMAR.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(238, 169);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(126, 34);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "PROCESAR";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            this.btnProcesar.MouseLeave += new System.EventHandler(this.btnProcesar_MouseLeave);
            this.btnProcesar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnProcesar_MouseMove);
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactura.Location = new System.Drawing.Point(238, 225);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(72, 13);
            this.lblFactura.TabIndex = 4;
            this.lblFactura.Text = "FACTURA :";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(238, 263);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(92, 13);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "PROVEEDOR :";
            // 
            // lblFecEmision
            // 
            this.lblFecEmision.AutoSize = true;
            this.lblFecEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecEmision.Location = new System.Drawing.Point(241, 302);
            this.lblFecEmision.Name = "lblFecEmision";
            this.lblFecEmision.Size = new System.Drawing.Size(111, 13);
            this.lblFecEmision.TabIndex = 6;
            this.lblFecEmision.Text = "FECHA EMISION :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(238, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "TOTAL :";
            // 
            // lblServIntegral
            // 
            this.lblServIntegral.AutoSize = true;
            this.lblServIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServIntegral.Location = new System.Drawing.Point(238, 389);
            this.lblServIntegral.Name = "lblServIntegral";
            this.lblServIntegral.Size = new System.Drawing.Size(147, 13);
            this.lblServIntegral.TabIndex = 8;
            this.lblServIntegral.Text = "SERVICIOS INTEGRAL :";
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(415, 225);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(216, 20);
            this.txtFactura.TabIndex = 9;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(415, 263);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(216, 20);
            this.txtProveedor.TabIndex = 10;
            // 
            // txtFecEmision
            // 
            this.txtFecEmision.Enabled = false;
            this.txtFecEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecEmision.Location = new System.Drawing.Point(415, 302);
            this.txtFecEmision.Name = "txtFecEmision";
            this.txtFecEmision.Size = new System.Drawing.Size(216, 20);
            this.txtFecEmision.TabIndex = 11;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(415, 343);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(216, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // txtServIntegral
            // 
            this.txtServIntegral.Enabled = false;
            this.txtServIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServIntegral.Location = new System.Drawing.Point(415, 389);
            this.txtServIntegral.Name = "txtServIntegral";
            this.txtServIntegral.Size = new System.Drawing.Size(216, 20);
            this.txtServIntegral.TabIndex = 13;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.Location = new System.Drawing.Point(659, 349);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(68, 13);
            this.lblMoneda.TabIndex = 14;
            this.lblMoneda.Text = "MONEDA :";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Enabled = false;
            this.txtMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(745, 346);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(109, 20);
            this.txtMoneda.TabIndex = 15;
            // 
            // lblAdjunto
            // 
            this.lblAdjunto.AutoSize = true;
            this.lblAdjunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjunto.Location = new System.Drawing.Point(241, 94);
            this.lblAdjunto.Name = "lblAdjunto";
            this.lblAdjunto.Size = new System.Drawing.Size(124, 13);
            this.lblAdjunto.TabIndex = 16;
            this.lblAdjunto.Text = "ARCHIVO ADJUNTO";
            // 
            // txtRutaAdjunto
            // 
            this.txtRutaAdjunto.Enabled = false;
            this.txtRutaAdjunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRutaAdjunto.Location = new System.Drawing.Point(245, 110);
            this.txtRutaAdjunto.Name = "txtRutaAdjunto";
            this.txtRutaAdjunto.Size = new System.Drawing.Size(535, 21);
            this.txtRutaAdjunto.TabIndex = 17;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(241, 429);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(59, 13);
            this.lblCliente.TabIndex = 18;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.Location = new System.Drawing.Point(241, 468);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(43, 13);
            this.lblLinea.TabIndex = 19;
            this.lblLinea.Text = "LINEA";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(415, 429);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(216, 20);
            this.txtCliente.TabIndex = 20;
            // 
            // txtLinea
            // 
            this.txtLinea.Enabled = false;
            this.txtLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinea.Location = new System.Drawing.Point(415, 468);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(216, 20);
            this.txtLinea.TabIndex = 21;
            // 
            // lblMnsjAlerta
            // 
            this.lblMnsjAlerta.AutoSize = true;
            this.lblMnsjAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMnsjAlerta.ForeColor = System.Drawing.Color.Red;
            this.lblMnsjAlerta.Location = new System.Drawing.Point(238, 13);
            this.lblMnsjAlerta.Name = "lblMnsjAlerta";
            this.lblMnsjAlerta.Size = new System.Drawing.Size(0, 25);
            this.lblMnsjAlerta.TabIndex = 22;
            // 
            // btnSubirFact
            // 
            this.btnSubirFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirFact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubirFact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubirFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirFact.Location = new System.Drawing.Point(392, 46);
            this.btnSubirFact.Name = "btnSubirFact";
            this.btnSubirFact.Size = new System.Drawing.Size(187, 44);
            this.btnSubirFact.TabIndex = 2;
            this.btnSubirFact.Text = "SUBIR FACTURA";
            this.btnSubirFact.UseVisualStyleBackColor = true;
            this.btnSubirFact.Click += new System.EventHandler(this.btnSubirFact_Click);
            this.btnSubirFact.MouseLeave += new System.EventHandler(this.btnSubirFact_MouseLeave);
            this.btnSubirFact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSubirFact_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 518);
            this.Controls.Add(this.lblMnsjAlerta);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblLinea);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtRutaAdjunto);
            this.Controls.Add(this.lblAdjunto);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.lblMoneda);
            this.Controls.Add(this.txtServIntegral);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtFecEmision);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblServIntegral);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFecEmision);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnSubirFact);
            this.Controls.Add(this.radioUNIMAR);
            this.Controls.Add(this.radioAPM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA FACTURA";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioAPM;
        private System.Windows.Forms.RadioButton radioUNIMAR;
        private System.Windows.Forms.Button btnSubirFact;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblFecEmision;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblServIntegral;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtFecEmision;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtServIntegral;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblAdjunto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox txtRutaAdjunto;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMnsjAlerta;
    }
}

