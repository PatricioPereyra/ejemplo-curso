using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico aD1 = new AnimalDomestico();
            aD1.Nombre = "Caracú";

            Console.WriteLine(aD1.ToString());
            
            Gato g1 = new Gato();
            g1.Nombre = "Carolina";

            Perro p1 = new Perro();
            p1.Nombre = "Cachi";

            
            Console.WriteLine("El gato hace " + g1.comunicarse() + ".");
            Console.WriteLine("El perro hace " + p1.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            animales.Add(new Pez());
            animales.Add(new Aguila());
            animales.Add(new Tigre());
            animales.Add(new Canario());

            Animal a1 = g1;
            Gato g8 = (Gato)a1;
            Console.WriteLine("¿Quién es el gato que está guardado adentro de esta variable? Es " + g8.Nombre);

            g8.Nombre = "Pini";

            Console.WriteLine("Ahora el gato es " + g1.Nombre);
            
            Console.WriteLine("A continuación, todos los animales de mi lista van a comunicarse... Comenzando YA: ");

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());





            Console.ReadKey();
        }
    }
}
