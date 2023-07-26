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
    public partial class Default : Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Medidor medidor = new Medidor();
            medidor.numeroSerie = Convert.ToInt32(this.txtnumeroSerie.Text.Trim());
            medidor.tipo = this.txttipo.Text.Trim();

            this.medidoresDAL.AgregarMedidor(medidor);
            Response.Redirect("MostrarMedidores.aspx");
               
           
        }
    }
}