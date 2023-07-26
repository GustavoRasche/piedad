using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels.DAL
{
    public interface IUsuarioDAL
    {
        List<Usuario> ObtenerUsuarios();

        List<Usuario> ObtenerUsuarios(int idUsuario);

        Usuario Obtener(int idUsuario);

        void AgregarUsuario(Usuario usuario);   

        void EliminarUsuario(int idUsuario);
        void Actualizar(Usuario usuario);
    }
}
