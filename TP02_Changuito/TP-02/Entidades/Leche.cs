using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        #region Enums
        public enum ETipo
        {
            Entera,
            Descremada
        } 
        #endregion

        #region Atributos
        ETipo _tipo; 
        #endregion

        #region Constructores
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color)
            : this(marca, codigo, color, ETipo.Entera)
        { }


        /// <summary>
        /// Contructor que recibe todos los datos del producto Leche.
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        /// <param name="tipo"></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo)
            : base(codigo, marca, color)
        {
            this._tipo = tipo;
        } 
        #endregion

        #region Propiedades
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        } 
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra todos los datos del Producto Leche
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}\n", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        } 
        #endregion
    }
}
