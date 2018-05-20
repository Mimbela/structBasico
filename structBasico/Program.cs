using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structBasico
{
    class Program
    {
        struct TipoPersona
        {
            public string nombre;
            public char inicial;
            public int edad;
            public float nota;
        }
        static void Main(string[] args)
        {
            //lo instancio
            TipoPersona persona;
            persona.nombre = "Sandra";
            persona.inicial = 'S';
            persona.edad = 33;
            persona.nota = 7.5f;

            Console.WriteLine("La edad de{0} es  {1}", persona.nombre, persona.edad);
            Console.ReadKey();
        }
    }
}
