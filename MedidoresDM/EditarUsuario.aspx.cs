using MedidoresModels.DAL;
using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidoresGR2
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuarioDALObjetos();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Obtener el ID del usuario de la URL
                if (Request.QueryString["idUsuario"] != null)
                {
                    int idUsuario = Convert.ToInt32(Request.QueryString["idUsuario"]);
                    // Obtener el usuario por su ID
                    Usuario usuario = usuariosDAL.Obtener(idUsuario);

                    // Cargar la información del usuario en los TextBox
                    txtNombre.Text = usuario.nombre;
                    txtRut.Text = usuario.rut;
                    txtCorreo.Text = usuario.correoElectronico;
                    txtContrasena.Text = usuario.contrasena;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario de la URL
            if (Request.QueryString["idUsuario"] != null)
            {
                int idUsuario = Convert.ToInt32(Request.QueryString["idUsuario"]);
                // Obtener el usuario por su ID
                Usuario usuario = usuariosDAL.Obtener(idUsuario);

                // Actualizar la información del usuario con los valores de los TextBox
                usuario.nombre = txtNombre.Text;
                usuario.correoElectronico = txtCorreo.Text;
                usuario.contrasena = txtContrasena.Text;

                // Llamar al método Actualizar del DAL para guardar los cambios en la base de datos
                usuariosDAL.Actualizar(usuario);

                // Mostrar mensaje de éxito
                lblMensaje.Text = "Usuario actualizado correctamente.";
                lblError.Text = "";
            }
        }
    }
}