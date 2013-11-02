using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Multa
    {

        private string tipoPago = string.Empty;
        private string ruc = string.Empty;
        private string periodo = string.Empty;

        private int codigoTributo = 0;
        private decimal importe = 0;
        private string resolucion = string.Empty;

        [DataMember]
        public string TipoPago
        {
            get { return tipoPago; }
            set { tipoPago = value; }
        }


        [DataMember]
        public string RUC
        {
            get { return ruc; }
            set { ruc = value; }
        }


        [DataMember]
        public string Periodo
        {
            get { return periodo; }
            set { periodo = value; }
        }


        [DataMember]
        public int CodigoTributo
        {
            get { return codigoTributo; }
            set { codigoTributo = value; }
        }


        [DataMember]
        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        [DataMember]
        public string Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }
    }
}
