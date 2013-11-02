using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;

namespace WcfSunat
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public List<Multa> GetMultasPorRuc(string ruc)
        {
            List<Multa> multas = new List<Multa>();

            Multa multa1 = new Multa();
            multa1.RUC = "20516755416";
            multa1.TipoPago = "Tributo";
            multa1.CodigoTributo = 1011;
            multa1.Periodo = "Sep-13";
            multa1.Importe = 859;

            Multa multa2 = new Multa();
            multa2.RUC = "20516755416";
            multa2.TipoPago = "Fraccionamiento";
            multa2.CodigoTributo = 8030;
            multa2.Periodo = "Sep-13";
            multa2.Importe = 490;
            multa2.Resolucion = "0230170512704";


            Multa multa3 = new Multa();
            multa3.RUC = "20543755401";
            multa3.TipoPago = "Fraccionamiento";
            multa3.CodigoTributo = 8790;
            multa3.Periodo = "Sep-13";
            multa3.Importe = 476;

            Multa multa4 = new Multa();
            multa4.RUC = "20543755401";
            multa4.TipoPago = "Fraccionamiento";
            multa4.CodigoTributo = 6789;
            multa4.Periodo = "Sep-13";
            multa4.Importe = 445;
            multa4.Resolucion = "5432170333897";

            multas.Add(multa1);
            multas.Add(multa2);
            multas.Add(multa3);
            multas.Add(multa4);


            var multasFiltradas = (from m in multas
                                   where m.RUC.Equals(ruc)
                                   select m).ToList();


            return multasFiltradas;
        }
    }

}
