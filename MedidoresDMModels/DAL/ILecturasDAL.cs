    using MedidoresModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModels.DAL
{
    public interface ILecturasDAL
    {
        List<Lectura> ObtenerLecturas();
        void AgregarLectura(Lectura lectura);

        List<Lectura> Obtener(int numeroSerie);

    }
}
