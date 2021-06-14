using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServiceCuil
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWebServiceCuil
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string getCuil(String apellidoYNombre, String genero);
    }
}
