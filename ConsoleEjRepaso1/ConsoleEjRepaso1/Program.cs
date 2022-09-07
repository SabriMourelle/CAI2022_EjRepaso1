using System;

namespace ConsoleEjRepaso1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I
            //Crear una aplicación que cuente desde el número 1 hasta los últimos tres dígitos del
            //propio número de registro(en caso de ser comenzar con 0, sumarle 100), todos los
            //números deben mostrarse por pantalla y, con los múltiplos de 3 se debera agregar
            //“Foo”, con los múltiplos de 5, “Bar”, y, por último, con los múltiplos de ambos, “FooBar”.
            //Por ejemplo, con el número mostrará “15 – FooBar”. 

            //registro 866644

            int _registro;
            string _pantalla;
            int _numero;

            _pantalla = "";
            _numero = 0;

            Console.WriteLine("Ingrese últimos 3 numeros del nro de registro");
            _registro = Int32.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                _numero = _numero + 1;
                if (_numero%3==0)
                {
                    if (_numero%5==0)
                    {
                        _pantalla = _pantalla + _numero + "FooBar" + "\n";
                    }
                    else
                    {
                        _pantalla = _pantalla + _numero + "Foo" + "\n";
                    }
                }
                else
                { if (_numero % 5 == 0)
                    {
                        _pantalla = _pantalla + _numero + "Bar" + "\n";
                    }
                else
                    {
                        _pantalla = _pantalla + _numero + "\n";
                    }
                        
                }
            }
            while (_numero < _registro);

            Console.WriteLine(_pantalla);
            Console.ReadKey();
        }
    }
}
