using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels.DAL
{
    public class UsuarioDALObjetos : IUsuarioDAL
    {
        private MEDIDORDBEntities1 eventoDB = new MEDIDORDBEntities1();

        public void AgregarUsuario(Usuario usuario)
        {
            this.eventoDB.Usuarios.Add(usuario);
            this.eventoDB.SaveChanges();

        }

        public void EliminarUsuario(int idUsuario)
        {
            Usuario usuario = this.eventoDB.Usuarios.Find(idUsuario);
            if (usuario != null)
            {
                this.eventoDB.Usuarios.Remove(usuario);
                this.eventoDB.SaveChanges();
            }
        }

        public Usuario Obtener(int idUsuario)
        {
            return this.eventoDB.Usuarios.Find(idUsuario);

        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.eventoDB.Usuarios.ToList();

        }

        public void Actualizar(Usuario a)
        {
            Usuario aOriginal = this.eventoDB.Usuarios.Find(a.idUsuario);
            aOriginal.rut = a.rut;
            aOriginal.nombre = a.nombre;
            aOriginal.correoElectronico = a.correoElectronico;
            aOriginal.contrasena = a.contrasena;
            this.eventoDB.SaveChanges();
        }

        public List<Usuario> ObtenerUsuarios(int idUsuario)
        {
            var query = from a in this.eventoDB.Usuarios where a.idUsuario == idUsuario select a;
            return query.ToList();
        }
    }
}
