using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Entidades
{
    public sealed class Suv : Vehiculo
    {
        public Suv(EMarca marca, string chasis, ConsoleColor color): base(chasis, marca, color)
        {
            
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        public sealed override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
          //  sb.AppendLine($"TIPO : {this.tipo}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
