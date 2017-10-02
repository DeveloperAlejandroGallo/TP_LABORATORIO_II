using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades_2017
{
    public class Dulce : Producto
    {
        #region Constructores
        public Dulce(EMarca marca, string codigo, ConsoleColor color)
            : base(codigo, marca, color)
        {
        }
        
        #endregion

        #region Propiedades
        /// <summary>
        /// Los dulces tienen 80 calorías. Propiedad de solo lectura.
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }
        
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los datos del Producto Dulce
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar()); 
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        
        #endregion
    }
}
