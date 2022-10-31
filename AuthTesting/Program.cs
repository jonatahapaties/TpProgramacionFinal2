using System;
using System.Runtime.Serialization;

namespace AuthTesting
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        //GENERALIDADES
        // 1)Crear una función que devuelva la suma de dos números recibidos por parámetros
        public static int Addition(int num1, int num2)
        {
            
            return num1 + num2;
        }

        // 2)Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres.
        public static bool  GetTheFirst4CharactersIfTheStringHas8Characters(String cadena)
        {

            if (cadena.Substring(0, 4).Length == 8)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        // 3)Crear una función que devuelva la fecha y hora actual
        public DateTime getActualDate()
        {
            DateTime fecha = DateTime.Now;
            return DateTime.Now;
        }

        // 4)Escribir un comentario con //
        // Comentario


        // 5)Escribir un comentario con /*   */
        /*
         * Comentario
         */

        /* 1) Realizar la conversión de true, false, 
       * 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. 
       * 
       * Explique cómo responde en cada caso cada uno de los métodos indicados.
       * convert
       * bool.Parse
       * bool.TryParse
       */

        public static bool ConvertIntToBoolean(int number)
        {
            return Convert.ToBoolean(number); // convierte un número en booleano
        }

        public static int ConvertBooleanToInt(bool boolean)
        {
            return Convert.ToInt32(boolean); // convierte el valor booleano en uno numero entero de 32 bits
        }

        public static bool ParseStringToBool(string stringVariable)
        {
            return bool.Parse(stringVariable); // convierte un string en un booleano
        }

        public static bool checkIfAStringIsBoolean(string stringVariable)
        {
            bool flag;
            return bool.TryParse(stringVariable, out flag); // retorna un valor booleano true, si el string puede convertirse en booleano con el metodo bool.Parse(string) 
        }

        /* 
       * 2) Explique que sucede en los siguientes intentos de casteos de datos.
       * a) int a = (int)344.4; // Asigna el número a una variable int eliminando los decimales
       * b) decimal a = 10;     // Asigna el número 10 a una variable decimal
       * c) int a=443444;       // Asigna el número 443444 a una variable int
       * short b = (short)a;    // Asigna el valor de la variable "a" una variable "b" short
       */

        /*
         * 3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada 
         * caso indicar un mensaje de cual es el color informado.
         */
        public enum Color
        {
            Blanco,
            Azul,
            Negro
        }
        public void SelectAColor(Color color)
        {
            switch (color)
            {
                case Color.Blanco:
                    Console.WriteLine("El color seleccionado es Blanco");
                    break;
                case Color.Azul:
                    Console.WriteLine("El color seleccionado es Azul");
                    break;
                case Color.Negro:
                    Console.WriteLine("El color seleccionado es Negro");
                    break;
                default:
                    Console.WriteLine("No se conoce que color seleccionado");
                    break;
            }
        }

        /* 
         * 4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. 
         * Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10. 
         * 5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error.
         */

        public void InformIfANumberIsGreaterThan10(int a)
        {
            if (a > 10)
            {
                Console.WriteLine("El valor {0} es mayor a 10", a);
            }
            else
            {
                Console.WriteLine("ERROR - valor {0} no es mayor a 10", a);
            }
        }

        /*
         * 6) ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas?
         * 
         * La diferencia es que for permite ejecutar repetidamente un bloque de instrucción si se cumple una determinada condicion,
         * mientras que forech ejecuta un bloque de instrucciones por cada elemento de una colección. También, se diferencia en que 
         * for necesita de una variable int y actualiza su valor por cada repetición, mientras que el forech necesita una variable
         * del elemento y actualiza su valor por cada repetición por el siguiente de la colección.
         * 
         * Si se desea recorrer todos los elementos de una coleccion es aconsejable utilizar forech, si se desea
         * ejecutar repetidamente un bloque de instrucciones con una condición booleana es aconsejable utilizar for.
         */

        /*
         * 7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable 
         * a exceda el valor de 50, el ciclo while debe finalizar.
         */

        public void IncreaseBy5UntilTheNumberIsGreaterThan50(int num)
        {
            while (num > 50)
            {
                num = num + 5;
            }
        }
        // 1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1.
        // 2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana

        enum DiaSemana
        {
            [EnumMember(Value = "Felicidades es Domingo")]
            Domingo,
            [EnumMember(Value = "Felicidades es Lunes")]
            Lunes,
            [EnumMember(Value = "Felicidades es Martes")]
            Martes,
            [EnumMember(Value = "Felicidades es Miércoles")]
            Miercoles,
            [EnumMember(Value = "Felicidades es Jueves")]
            Jueves,
            [EnumMember(Value = "Felicidades es Viernes")]
            Viernes,
            [EnumMember(Value = "Felicidades es Sábado")]
            Sabado
        }



    }
}
