using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_Unidades
{
    class Conversion
    {
        //Clase que contiene los métodos que se utilizarán para realizar las conversiones 
        public void Convertir(double valor,out double valorf )     //Método con paso de parametros Out para convertir Metros a Cm. 
        {                                                       //El método out saca el valor de la cantidad ingresada para mostrarla en el resultado junto a la conversión
                                                            //Este método regresa dos valores
            valorf = valor / 100;                  
        }

        public double Convertir(double valor)       //Métodos sobrecargados  donde paso un valor int solo para evitar un error a la hora de ejecución
        {
            return valor * 39.370079;           //Regresa el resultado de la conversion de metros a plg
        }
        public double Convertir(double valor, int res )
        {
            return valor * 1000;            //Regresa el resultado de la conversion de litros a ml.
        }


    }
}
