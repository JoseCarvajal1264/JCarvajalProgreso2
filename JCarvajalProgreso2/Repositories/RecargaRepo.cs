using JCarvajalProgreso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JCarvajalProgreso2.Repositories
{
    public class RecargaRepo : IRecargaRepos
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "JCarvajal.txt");
        public bool ActualizarRecarga(JCarvajalDatos recarga)
        {
            throw new NotImplementedException();
        }

        public bool CrearRecarga(JCarvajalDatos recarga)
        {
            try
            {
                string json_data = JsonConvert.SerializeObject(recarga);
                File.WriteAllText(_fileName, json_data);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}

