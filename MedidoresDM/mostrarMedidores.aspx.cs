using MedidoresModels;
using MedidoresModels.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresGR2
{
    public partial class MostrarMedidores : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                CargarMedidores();
            }
        }

        protected void ddlTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargarMedidores();
        }

        private void CargarMedidores()
        {

            IMedidorDAL medidorDAL = new MedidorDALObjetos();
            var medidores = medidorDAL.ObtenerMedidores();

  
            if (!string.IsNullOrEmpty(ddlTipo.SelectedValue))
            {
                medidores = medidores.Where(m => m.tipo == ddlTipo.SelectedValue).ToList();
            }


            gridMedidores.DataSource = medidores;
            gridMedidores.DataBind();
        }
    }
}