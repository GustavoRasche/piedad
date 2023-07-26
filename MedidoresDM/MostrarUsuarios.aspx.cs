using MedidoresModels;
using MedidoresModels.DAL;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresGR2
{
    public partial class MostrarUsuarios : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuarioDALObjetos();

        private void cargarGrilla(List<Usuario> usuarios)
        {
            this.grillaUsuarios.DataSource = usuarios;
            this.grillaUsuarios.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarGrilla(this.usuariosDAL.ObtenerUsuarios());
            }
        }
        protected void grillaUsuarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Obtener el ID del usuario seleccionado en la fila y pasarlo como parámetro en la URL
            int idUsuario = Convert.ToInt32(grillaUsuarios.DataKeys[e.NewEditIndex].Value);
            Response.Redirect($"EditarUsuario.aspx?idUsuario={idUsuario}");
        }

        protected void grillaUsuarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // Obtener el ID del usuario seleccionado en la fila
            int idUsuario = Convert.ToInt32(grillaUsuarios.DataKeys[e.RowIndex].Value);

            // Llamar al método para eliminar el usuario de la base de datos
            usuariosDAL.EliminarUsuario(idUsuario);

            // Recargar la grilla para mostrar los cambios actualizados
            cargarGrilla(usuariosDAL.ObtenerUsuarios());
        }
    }

}