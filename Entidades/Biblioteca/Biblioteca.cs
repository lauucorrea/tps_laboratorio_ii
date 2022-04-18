using System;
using System.Collections.Generic;
using System.Text;
namespace Biblioteca
{

    public class Calculadora
    {
        /// <summary>
        /// Recibe dos objetos de tipo operando, accede a su atributo y lo convierte en entero.
        /// depeniendo del operador recibido (char operador), calcula y devuelve el resultado segun el caso.
        /// </summary>
        /// <param name="num1">operando1</param>
        /// <param name="num2">operando2</param>
        /// <param name="operador"> + - / * </param>
        /// <returns> resultado </returns>
        public static double Operar(Operando num1,Operando num2,char operador) {
            double resultado;
            char operadorValidado = ValidarOperador(operador);

                switch (operadorValidado)
                {

                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        resultado = num1 / num2;
                        break;
                    default:
                        resultado = num1 + num2;
                        break;

                }
            return resultado;
        }

        /// <summary>
        /// recibe el operador desde la funcion operar. en caso de ser un char no esperado, por defecto
        /// devuelve el char correspondiente a la suma
        /// </summary>
        /// <param name="operador">operador ingresado por el usuario</param>
        /// <returns>operador</returns>
        private static char ValidarOperador(char operador)
        {
            char ret = operador;

            if (operador != '+' && operador != '-' && operador != '/' && operador != '*')
            {
                ret = '+';
            }
            return ret;

        }

        /// <summary>
        /// Evalua si el string recibido esta compuesto de 1 y 0, para cada "char" que compone a string binario
        /// </summary>
        /// <param name="binario">cadena hipoteticamente binaria</param>
        /// <returns>retorna true si es binario, y false si no es binario</returns>
        private static bool EsBinario(string binario)
        {
            bool ret = false;
            int cantidadIteraciones = 0;

            foreach (char c in binario)
            {
                if (c == '0' || c == '1')
                {
                    cantidadIteraciones++;
                }
            }
            //si las coincidencias , coinciden con la cantidad de caracteres de binario
            if (cantidadIteraciones == binario.Length)
            {
                ret = true;
            }
            return ret;

        }

        /// <summary>
        /// Convierte el string binario recibido como parametro, a decimal
        /// dentro del if validamos si se trata de un binario o no.
        /// </summary>
        /// <param name="binario">string binario</param>
        /// <returns>
        /// si funciona, devuelve el valor decimal en formato string
        /// si no funciona, devuelve mensaje de error
        /// </returns>
        public static string BinarioDecimal(string binario)
        {
            string ret;
            char[] array = binario.ToCharArray();
            Array.Reverse(array);
            decimal sum = 0;
            //evaluacion de si es binario o no es binario
            if (EsBinario(binario))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == '1')
                    {
                        //la potencia cuadrada del ultimo numero leido , se suma
                        sum += (decimal)Math.Pow(2, i);
                    }
                }
                ret = sum.ToString();
            }
            else
            {
                ret = "Valor invalido";
            }

            return ret;
        }
        /// <summary>
        /// Convierte el double recibido a Binario. 
        /// divide el valor por 2, y le concatena el resultado anterior al final del valor binario.
        /// de esta forma, se va escribiendo el resultado de derecha a izquierda
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string DecimalBinario(double numero)
        {
            string ret = "";
            //convierto el numero a entero para quedarme con el valor redondeado
            int valor = Convert.ToInt32(numero);
            StringBuilder cadena = new StringBuilder();

            if (valor > 0)
            {
                while (valor > 0)
                {
                    //divido el valor del numero por 2. concateno "ret" para escribir de derecha izquierda
                    ret = valor % 2 + ret; 
                    valor /= 2;
                }
            }
           if ( !EsBinario(ret) && numero != 0)
            {
                ret = "Valor invalido";
            }
            else if(!EsBinario(ret))
            {
                ret = "0";
          
            } 
            return ret;
        }
        /// <summary>
        /// Convierte un decimal ingresado como texto, convertirlo a valores binarios
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DecimalBinario(string numero)
        {
            string ret = "";
            int valor = Convert.ToInt32(numero);
            StringBuilder cadena = new StringBuilder();

            if (valor > 0)
            {
                while (valor > 0)
                {
                    ret = valor % 2 + ret;
                    valor /= 2;
                }
            }
            if (!EsBinario(ret) && numero != "0")
            {
                ret = "Valor invalido";
            }
            else if (!EsBinario(ret))
            {
                ret = "0";

            }
            return ret;
        }
    }
    public class Operando
    {
        private double numero;
        private string strNumero;
        /// <summary>
        /// set : si el numero, es distinto de 0, entonces se guarde en numero como un double.
        /// sino, el valor del numero se guarda como 0
        /// 
        ///get: convierte el numero a string y lo retorna
        /// </summary>
        public string Numero {
            set 
            {
                if (ValidarOperando(value) != 0)
                {
                    this.numero = Convert.ToDouble(value);
                }
                else
                {
                    this.numero = 0;
                }
            }
            get 
            {
                return this.numero.ToString();
            }
        
        }

        /// <summary>
        /// constructor del Operando por defecto.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// guarda en Operando, el valor parametrizado
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// guarda en Operando, el valor parametrizado
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
        {
            this.strNumero = strNumero;
        }

        /// <summary>
        /// sobrecarga. realiza la suma cuando identifica el "+"
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator +(Operando num1, Operando num2) {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// sobrecarga. realiza la resta cuando identifica el "-"
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// sobrecarga. realiza la muiltiplicacion cuando identifica el "*"
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }

        /// <summary>
        /// sobrecarga. realiza la division cuando identifica el "/", solo si el operando2 NO es 0.
        /// En caso de ser -. retorna el valor minimo posible de un double
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns> division exitosa, o double.MinValue</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            double ret = double.MinValue;

            if (num2.numero != 0) {
                ret = num1.numero / num2.numero;
            }

            return ret;
            
        }

        /// <summary>
        /// Valida que el operando ingresado realmente sea un numero. sino, retorna 0
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns></returns>
        public double ValidarOperando(string strNumero) {
            double ret = 0;
            double valor;

            if (double.TryParse(strNumero, out valor)) {
                ret = valor;
            }

            return ret;
        }

    }
}
