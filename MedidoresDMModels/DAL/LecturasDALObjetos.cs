using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels.DAL
{
    public class LecturasDALObjetos : ILecturasDAL
    {
        private MEDIDORDBEntities1 eventoDB = new MEDIDORDBEntities1();


        public List<Lectura> ObtenerLecturas()
        {
            return this.eventoDB.Lecturas.ToList();
        }

        public void AgregarLectura(Lectura lectura)
        {
            this.eventoDB.Lecturas.Add(lectura);
            this.eventoDB.SaveChanges();
        }

        public List<Lectura> Obtener(int numeroSerie)
        {
            var query = from lectura in this.eventoDB.Lecturas
                        where lectura.numeroSerie == numeroSerie
                        select lectura;
            return query.ToList();
        }

    }
}
