using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> ObtenerMedidores();

        Medidor Obtener(int numeroSerie);

        void AgregarMedidor(Medidor medidor);

        void EliminarMedidor(int numeroSerie);
    }
}