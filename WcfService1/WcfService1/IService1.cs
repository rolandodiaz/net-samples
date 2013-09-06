using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Add your service operations here

        [OperationContract]
        IList<Categoria> ObtenerCategorias();

        
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Categoria
    {
        [DataMember]
        public int IdCategoria { set; get; }

        [DataMember]
        public String Nombre { set; get; }
    }
}
