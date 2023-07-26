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
    public partial class AgregarUsuario : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuarioDALObjetos();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ingresaBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.rut = this.rutTXT.Text.Trim();
            usuario.nombre = this.nombreTXT.Text.Trim();
            usuario.contrasena = this.contrasenaTXT.Text.Trim();
            usuario.correoElectronico = this.correoTXT.Text.Trim();

            this.usuariosDAL.AgregarUsuario(usuario);
            Response.Redirect("MostrarUsuarios.aspx");


        }
    }
}