using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor_de_Unidades
{
    class Principal     //Clase que contiene el Menú y el List<> que interaccionan con el usuario
    {
        double valor, valorf;           //Variables globales donde se guardará la cantidad a convertir y el resultado de la conversión respectivamente
       
        List<double> Lista1 = new List<double>();       //En esta lista guardaré los resultados de las conversiones para que funcione...
                                                        //...como un tipo de historial que el usuario puede consultar       
        Conversion c = new Conversion();    //Instanciación de la clase que contiene los métodos y que en el menú se van a utilizar
        public Principal()      //Constructor que muestra un mensaje al ejecutar el programa la primera vez
        {
            Console.WriteLine("Bienvenido al convertidor de unidades");
        }



        public void Menu()      //Método que interacciona con el usuario y permite elegir la conversión a realizar asi como otras funciones
        {
            int res;        //Variable utilizada en este método para elegir la opción que el usuario desee por medio de un switch
            Console.WriteLine("Convertidor de Unidades\n" +
                "Seleccione la conversión a realizar");
            Console.WriteLine("1.- Centimétros a Metros\n" +
                "2.- Metros a Pulgadas\n" +
                "3.- Litros a Mililitros.\n" +
                "4.- Mostrar Historial de conversiones\n" +
                "5.- Eliminar Historial de conversiones\n" +
                "6.- Salir");
            res = Convert.ToInt32(Console.ReadLine());

            if (res != 6)
            {         //Condición que permite terminar el programa si el usario ingresa 6, en caso contrario se evalua el switch
                
                switch (res)
                {
                    case 1:
                        Console.WriteLine("Ingrese el valor a convertir\n");            //Se pide al usuario la cantidad a convertir y se guarda en la variable valor
                        valor = Convert.ToDouble(Console.ReadLine());
                        c.Convertir(valor, out valorf);          //Método out que regresa dos valores, el primero "valor" se usará para mostrar la cantidad a convertir mientras que "x" sirve para mostrar el resultado
                        Console.WriteLine("\n" + valor.ToString("N2") + " cm es igual a : " + valorf.ToString("N2") + " Metros\n\n");      
                        AgregarConversion();        //Cada que se realice una conversión se agregará el resultado a una lista para guardarse como historial
                        break;

                    case 2:
                        Console.WriteLine("Ingrese el valor a convertir\n");        //Se pide al usuario la cantidad a convertir y se guarda en la variable valor
                        valor = Convert.ToDouble(Console.ReadLine());       
                        valorf = c.Convertir(valor);                        //Método sobrecargado que solo regresa un valor que es el resultado
                        Console.WriteLine("\n" + valor.ToString("N2") + " Metros es igual a : " + valorf.ToString("N2") + " Pulgadas\n\n");
                        AgregarConversion();
                        break;

                    case 3:
                        Console.WriteLine("Ingrese el valor a convertir\n");        //Se pide al usuario la cantidad a convertir y se guarda en la variable valor
                        valor = Convert.ToDouble(Console.ReadLine());
                        valorf = c.Convertir(valor, res);       //Método sobrecargado donde paso un parametro extra inutil y vació solo para evitar errores
                        Console.WriteLine("\n" + valor.ToString("N2") + " Litros es igual a : " + valorf.ToString("N2") + " Mililitros\n\n");
                        AgregarConversion();
                        break;

                    case 4:
                        MostrarHistorial();     //Método que muestra todos los resultados guardados en el List<>
                        break;

                    case 5:
                        EliminarHistorial();        //Elimina los datos guardado en el List<>
                        break;

                    default:
                        Console.WriteLine("\nDebe elegir una opción valida\n");     //En caso de ingresar un valor erroneo se mostrará este mensaje
                        break;
                }

                Menu();     //El menú se vuelve a ejecutar hasta que el usuario decida

            }
            Console.WriteLine("Adios");     //Mensaje de despedida al elegir "Salir"
            Console.ReadKey();


        }



        public void AgregarConversion()     //Método que agrega el resultado de la conversión a la lista
        {
            Lista1.Add(valorf);

        }
        public void MostrarHistorial()          //Método que imprime el total de valores guardados hasta el momento
        {                           
                Console.WriteLine("-----------HISTORIAL-------------------");
                foreach (double x in Lista1)        //Utilizo un foreach para mostrar cada valor guardado en el list
                {
                    Console.WriteLine("\n" + x.ToString("N2"));
                }
                          
        }

        public void EliminarHistorial()     //Método que elimina todos los valores guardados en el list hasta ese momento
        {

            Lista1.Clear();
            Console.WriteLine("\nEl historial ah sido eliminado\n");
        }
        
    }
}

