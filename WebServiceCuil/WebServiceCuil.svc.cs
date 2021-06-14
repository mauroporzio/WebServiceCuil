using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceCuil
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IWebServiceCuil
    {
        public void DoWork()
        {
        }
        public string getCuil(String apellidoYNombre, String genero)
        {
            try
            {
                Random rnd = new Random();
                int dni = rnd.Next(9999999, 100000000);
                int numeroVerif = rnd.Next(0, 10);

                if (genero.Equals("Masculino"))
                {
                    return 20 + "-" + dni + "-" + numeroVerif;
                }
                else
                {
                    return 27 + "-" + dni + "-" + numeroVerif;
                }
            }
            catch
            {
                throw new FaultException("No se encontro un CUIL correspondiente a los datos recibidos.");
            }

        }
    }
}
