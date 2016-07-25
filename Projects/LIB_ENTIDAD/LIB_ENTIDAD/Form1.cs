using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.Data;
using LIB_DATOS;
using LIB_NEGOCIO;
namespace ProyectoFacturas
{
    public partial class Form1 : Form
    {
        public  Form1()
        {
            InitializeComponent();
        }
     
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubirFact_Click(object sender, EventArgs e)
        {
            lblMnsjAlerta.Text = "";
            foreach (Control c in Controls)
            {
                if (c is TextBox) c.Text = "";
            
            }
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.ShowDialog();
            txtRutaAdjunto.Text = openFileDialog1.FileName;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (radioAPM.Checked==true)
            {
                ClsExpo_BL.CARGA_DATOS_APM(txtRutaAdjunto, txtTotal,
                  txtFactura, txtFecEmision, txtMoneda,
                  txtProveedor, txtServIntegral, txtCliente, txtLinea, errorProvider1, lblMnsjAlerta);
            }
            else if(radioUNIMAR.Checked==true)
                {
                    
                              
                }

        }

        private void btnSubirFact_MouseMove(object sender, MouseEventArgs e)
        {
            btnSubirFact.ForeColor = Color.Blue;
            btnSubirFact.BackColor = Color.SkyBlue;
           
        }

        private void btnSubirFact_MouseLeave(object sender, EventArgs e)
        {
            btnSubirFact.BackColor = Color.White;
            btnSubirFact.ForeColor = Color.Black;
          
        }

        private void btnProcesar_MouseLeave(object sender, EventArgs e)
        {
            btnProcesar.BackColor = Color.White;
            btnProcesar.ForeColor = Color.Black;
        }

        private void btnProcesar_MouseMove(object sender, MouseEventArgs e)
        {
            btnProcesar.ForeColor = Color.Blue;
            btnProcesar.BackColor = Color.SkyBlue;

        }
        
        }


}
