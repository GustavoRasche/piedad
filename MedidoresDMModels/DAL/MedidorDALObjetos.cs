using MedidoresModels.DAL;
using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels
{
    public class MedidorDALObjetos : IMedidorDAL
    {
        private MEDIDORDBEntities1 eventoDB = new MEDIDORDBEntities1();

        public void AgregarMedidor(Medidor medidor)
        {
            this.eventoDB.Medidors.Add(medidor);
            this.eventoDB.SaveChanges();
        }
        public void EliminarMedidor(int numeroSerie)
        {
            Medidor medidor = this.eventoDB.Medidors.Find(numeroSerie);
            this.eventoDB.Medidors.Remove(medidor);
            this.eventoDB.SaveChanges();
        }
        public Medidor Obtener(int numeroSerie)
        {
            return this.eventoDB.Medidors.Find(numeroSerie);

        }
        public List<Medidor> ObtenerMedidores()
        {
            return this.eventoDB.Medidors.ToList();
        }

        public List<Medidor> ObtenerMedidores(int numeroSerie) 
        {
            var query = from a in this.eventoDB.Medidors where a.numeroSerie == numeroSerie select a;
            return query.ToList();

        }

       
    }
}