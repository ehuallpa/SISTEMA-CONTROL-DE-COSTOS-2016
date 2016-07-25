using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml.Linq;
using System.Text;
using System.Xml;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using LIB_DATOS;


namespace LIB_NEGOCIO
{
    public class ClsExpo_BL
    {
       public static XNamespace ext = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
       public static XNamespace sac = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1";
       public static XNamespace cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
       public static XNamespace cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
       public static XmlDocument doc1 = new XmlDocument();

        public static string Consulta_Integral(string booking)
        {
            return ClsExpo_DAL.IntegralExpo_APM(booking);
             
     }
        public static string Consulta_Integral_Impo(string blMaster)
        {
            return ClsExpo_DAL.IntegralImpo_APM(blMaster);
        }
        public static DataTable Linea_Cliente(string CodIntegral)
        {
            return ClsExpo_DAL.Linea_Cliente(CodIntegral);
        }

        public static void CARGA_DATOS_APM(TextBox txtRutaAdjunto,TextBox txtTotal,
            TextBox txtFactura,TextBox txtFecEmision,TextBox txtMoneda,
            TextBox txtProveedor, TextBox txtServIntegral,TextBox txtCliente,TextBox txtLinea, ErrorProvider errorProvider1,Label lblMnsjAlerta)
        {            
            
            XElement xmlElemen = XElement.Load(txtRutaAdjunto.Text);
            var msn = new XmlNamespaceManager(doc1.NameTable);
            var Elemsucursal = from c in xmlElemen.Descendants(ext + "UBLExtension")
             .Descendants(ext + "ExtensionContent").Descendants(sac + "branch")
                           select c.Element(cbc + "address").Value;
            string sucursal = Elemsucursal.ElementAt(0);
            if (sucursal == "Km. 4.5 Mza. L Lote 3 Z.I.II De Paita, Paita, Piura")
            {
                lblMnsjAlerta.Text = "Esta factura es de la sucursal de Paita";
                
            }else
            {
                    if (txtRutaAdjunto.Text == "")
            {
                errorProvider1.SetError(txtRutaAdjunto, "ADJUNTE UNA FACTURA");
                      }
            else
            {  
                doc1.Load((txtRutaAdjunto.Text));
                var ElementAll =
          from c in xmlElemen.Descendants(ext + "UBLExtension")
              .Descendants(ext + "ExtensionContent")
              .Descendants(sac + "AdditionalInformation")
              .Descendants(sac + "AdditionalMonetaryTotal")
          select c.Element(cbc + "PayableAmount").Value;
                var blMaster = from d in xmlElemen.Descendants(ext + "UBLExtension")
                             .Descendants(ext + "ExtensionContent")
                             .Descendants(cac + "AdditionalInformationComex")
                               select d.Element(cbc + "Trip").Value;
                string booking_BL = blMaster.ElementAt(0).ToString();


                txtServIntegral.Text = ClsExpo_BL.Consulta_Integral(booking_BL);
                if (txtServIntegral.Text == "")
                {
                    txtServIntegral.Text = ClsExpo_BL.Consulta_Integral_Impo(booking_BL);
                    txtTotal.Text = ElementAll.ElementAt(0);
                    txtFactura.Text = xmlElemen.Element(cbc + "ID").Value;
                    txtFecEmision.Text = xmlElemen.Element(cbc + "IssueDate").Value;
                    txtMoneda.Text = xmlElemen.Element(cbc + "DocumentCurrencyCode").Value;

                    var prov = from p in xmlElemen.Descendants(cac + "AccountingSupplierParty")
                               select p.Element(cbc + "CustomerAssignedAccountID").Value;
                    txtProveedor.Text = prov.ElementAt(0);

                    DataTable dt = new DataTable();
                    dt = ClsExpo_BL.Linea_Cliente(txtServIntegral.Text);
                    if (dt.Rows.Count != 0)
                    {
                        txtCliente.Text = dt.Rows[0][0].ToString();
                        txtLinea.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        txtCliente.Text = "";
                        txtLinea.Text = "";
                    }
                }
                else
                {
                    txtTotal.Text = ElementAll.ElementAt(0);
                    txtFactura.Text = xmlElemen.Element(cbc + "ID").Value;
                    txtFecEmision.Text = xmlElemen.Element(cbc + "IssueDate").Value;
                    txtMoneda.Text = xmlElemen.Element(cbc + "DocumentCurrencyCode").Value;

                    var prov = from p in xmlElemen.Descendants(cac + "AccountingSupplierParty")
                               select p.Element(cbc + "CustomerAssignedAccountID").Value;
                    txtProveedor.Text = prov.ElementAt(0);

                    DataTable dt = new DataTable();
                    dt = ClsExpo_BL.Linea_Cliente(txtServIntegral.Text);
                    if (dt.Rows.Count != 0)
                    {
                        txtCliente.Text = dt.Rows[0][0].ToString();
                        txtLinea.Text = dt.Rows[0][2].ToString();
                    }
                    else
                        {
                        txtCliente.Text = "";
                        txtLinea.Text = "";
                        }
                    }
                }
            }
        }


        public static void CARGA_DATOS_UNIMAR(TextBox txtRutaAdjunto, TextBox txtTotal,
           TextBox txtFactura, TextBox txtFecEmision, TextBox txtMoneda,
           TextBox txtProveedor, TextBox txtServIntegral, TextBox txtCliente, TextBox txtLinea, ErrorProvider errorProvider1, Label lblMnsjAlerta)
        {

            XElement xmlElemen = XElement.Load(txtRutaAdjunto.Text);
            var msn = new XmlNamespaceManager(doc1.NameTable);
            var Elemsucursal = from c in xmlElemen.Descendants(ext + "UBLExtension")
             .Descendants(ext + "ExtensionContent").Descendants(sac + "branch")
                               select c.Element(cbc + "address").Value;
            string sucursal = Elemsucursal.ElementAt(0);
            if (sucursal == "Km. 4.5 Mza. L Lote 3 Z.I.II De Paita, Paita, Piura")
            {
                lblMnsjAlerta.Text = "Esta factura es de la sucursal de Paita";

            }
            else
            {
                if (txtRutaAdjunto.Text == "")
                {
                    errorProvider1.SetError(txtRutaAdjunto, "ADJUNTE UNA FACTURA");
                }
                else
                {
                    doc1.Load((txtRutaAdjunto.Text));
                    var ElementAll =
              from c in xmlElemen.Descendants(ext + "UBLExtension")
                  .Descendants(ext + "ExtensionContent")
                  .Descendants(sac + "AdditionalInformation")
                  .Descendants(sac + "AdditionalMonetaryTotal")
              select c.Element(cbc + "PayableAmount").Value;
                    var blMaster = from d in xmlElemen.Descendants(ext + "UBLExtension")
                                 .Descendants(ext + "ExtensionContent")
                                 .Descendants(cac + "AdditionalInformationComex")
                                   select d.Element(cbc + "Trip").Value;
                    string booking_BL = blMaster.ElementAt(0).ToString();


                    txtServIntegral.Text = ClsExpo_BL.Consulta_Integral(booking_BL);
                    if (txtServIntegral.Text == "")
                    {
                        txtServIntegral.Text = ClsExpo_BL.Consulta_Integral_Impo(booking_BL);
                        txtTotal.Text = ElementAll.ElementAt(0);
                        txtFactura.Text = xmlElemen.Element(cbc + "ID").Value;
                        txtFecEmision.Text = xmlElemen.Element(cbc + "IssueDate").Value;
                        txtMoneda.Text = xmlElemen.Element(cbc + "DocumentCurrencyCode").Value;

                        var prov = from p in xmlElemen.Descendants(cac + "AccountingSupplierParty")
                                   select p.Element(cbc + "CustomerAssignedAccountID").Value;
                        txtProveedor.Text = prov.ElementAt(0);

                        DataTable dt = new DataTable();
                        dt = ClsExpo_BL.Linea_Cliente(txtServIntegral.Text);
                        if (dt.Rows.Count != 0)
                        {
                            txtCliente.Text = dt.Rows[0][0].ToString();
                            txtLinea.Text = dt.Rows[0][2].ToString();
                        }
                        else
                        {
                            txtCliente.Text = "";
                            txtLinea.Text = "";
                        }
                    }
                    else
                    {
                        txtTotal.Text = ElementAll.ElementAt(0);
                        txtFactura.Text = xmlElemen.Element(cbc + "ID").Value;
                        txtFecEmision.Text = xmlElemen.Element(cbc + "IssueDate").Value;
                        txtMoneda.Text = xmlElemen.Element(cbc + "DocumentCurrencyCode").Value;

                        var prov = from p in xmlElemen.Descendants(cac + "AccountingSupplierParty")
                                   select p.Element(cbc + "CustomerAssignedAccountID").Value;
                        txtProveedor.Text = prov.ElementAt(0);

                        DataTable dt = new DataTable();
                        dt = ClsExpo_BL.Linea_Cliente(txtServIntegral.Text);
                        if (dt.Rows.Count != 0)
                        {
                            txtCliente.Text = dt.Rows[0][0].ToString();
                            txtLinea.Text = dt.Rows[0][2].ToString();
                        }
                        else
                        {
                            txtCliente.Text = "";
                            txtLinea.Text = "";
                        }
                    }
                }
            }
        }










    }
}
