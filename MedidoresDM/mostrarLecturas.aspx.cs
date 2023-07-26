using MedidoresModels;
using MedidoresModels.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


namespace MedidoresGR2
{
    public partial class MostrarLecturas : Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjetos();
        private ILecturasDAL lecturasDAL = new LecturasDALObjetos();

        private void cargarGrilla(List<Lectura> lecturas)
        {

            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                this.cargarGrilla(this.lecturasDAL.ObtenerLecturas());

            }
        }


    }
}
