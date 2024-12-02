using JCarvajalProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCarvajalProgreso2.Interfaces
{
    public interface IRecargaRepos
    {
        IEnumerable<JCarvajalDatos> DevuelveRecarga();
        JCarvajalDatos DevuelveRecarga(int id);
        bool CrearRecarga(JCarvajalDatos recarga);
        bool ActualizarRecarga(JCarvajalDatos recarga);
        bool ElminarEstudianteUdla(int id);

    }
}
