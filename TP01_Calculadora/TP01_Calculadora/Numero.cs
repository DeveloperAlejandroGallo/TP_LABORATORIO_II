﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01_Calculadora
{
    public class Numero
    {

        double numero;

        #region Constructores
        //CONSTRUCTORES
        /// <summary>
        /// El constructor por defecto el inicializará el atributo numero en cero en 0
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Recibe un numero y carga un numero
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Recibirá un String que validará y cargará en número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.numero = SetNumero(numero);

        }
        #endregion


        #region Metodos
        /// <summary>
        /// Valida un string y lo devuelve
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve el string convertido a double.</returns>
        private double SetNumero(string numero)
        {
            return ValidarNumero(numero);
        }
        /// <summary>
        /// Valida si un string es numero y lo devuelve. Caso contrario devuelve 0.
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns>Devuelve el nro convertido a double si es valido, sino 0</returns>
        private static double ValidarNumero(string numeroString)
        {
            double ret = 0;

            double.TryParse(numeroString, out ret);

            return ret;

        }
        /// <summary>
        /// Metodo publico que devuelve el nro de la instancia.
        /// </summary>
        /// <returns>El numero de la instancia.</returns>
        public double GetNumero()
        {
            return this.numero;
        }

        #endregion
    }
}
