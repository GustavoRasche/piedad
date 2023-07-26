using MedidoresModels.DAL;
using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresGR2
{
    public partial class IngresarLectura : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarMedidores();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                try
                {
                    int numeroSerie = int.Parse(ddlMedidor.SelectedValue);
                    DateTime fecha = DateTime.Parse(txtFecha.Value);
                    TimeSpan hora = TimeSpan.Parse(txtHora.Text);
                    decimal valorConsumo = decimal.Parse(txtValorConsumo.Text);

                    Lectura lectura = new Lectura
                    {
                        numeroSerie = numeroSerie,
                        fecha = fecha,
                        hora = hora,
                        valorConsumo = valorConsumo
                    };


                    ILecturasDAL lecturasDAL = new LecturasDALObjetos();
                    lecturasDAL.AgregarLectura(lectura);

                    Response.Redirect("MostrarLecturas.aspx");
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void CargarMedidores()
        {

            IMedidorDAL medidorDAL = new MedidorDALObjetos();
            var medidores = medidorDAL.ObtenerMedidores();

            ddlMedidor.DataSource = medidores;
            ddlMedidor.DataTextField = "NumeroSerie";
            ddlMedidor.DataValueField = "NumeroSerie";
            ddlMedidor.DataBind();
        }

    }
}