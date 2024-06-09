using System;
using System.Collections;
using System.Linq;

// var fruits = new List<string>();
//
// fruits.Add("manzana");
// fruits.Add("pera");
// fruits.Add("banana");
// fruits.Add("uva");
// fruits.Add("coco");

// 1 Primero elemento o default - busca el primer item del array

// Console.WriteLine(fruits.First()); 

// Console.Write(fruits.FirstOrDefault("no encontrado"));


// 2 Verificar si existe - si lo encuentra de devuelve un booleano

// Console.WriteLine(fruits.Any(x=>x == "uva")); 


// 3 verificar si todos elementos son de un tipo - tambien te devuelovce un boolean (comprueba si todos elementios del array sean iguales)

// Console.WriteLine(fruits.All(x=> x == "uva")); 


// 4 Contar - cuenta cuantos items dentro del array coinciden con el que le pasamos " " 

// Console.WriteLine(fruits.Count(x=> x == "coco")); 


// 5 ElementAt  - indice en el array

// Console.WriteLine(fruits.ElementAt(5)); 


// 6 Take 

//(fruits.Take(3));  capturo los 3 primeros
//(fruits.Take(..3));  los 3 ultimos
//(fruits.Take(1..3)); del 1 al  2 (range operator)

//hacemos un foreach para recorrer la lista que nos devueolve el metodo Take

// foreach (var fruit in fruits.Take(3))
//     Console.WriteLine(fruit);
    
   
// 7 Where - 

// fruits.Where(x=> x == "manzana");
//
// foreach (var fruit in fruits.Where(x=> x == "manzana" || x == "banana")) // condicion que busca donde el elemento sea igual que la condicion que le pasamos y te devuelve una lista " || = o "
//     Console.WriteLine(fruit);


// 9 Last - es bastante obvio yo creo

// Console.WriteLine(fruits.Last());  
// Console.WriteLine(fruits.Last(x => x == "coco")); // tambien le puedes pasar una condicion ej: si existe dos items iguales dentro del array, te devolvera el ultimo (Matt: añadir otro elemento "coco" dentro del array)


// 10 Skip - salta los elementos que hayas puesto en la condicion y te devuelve una lista con esos items prrr

// foreach (var fruit in fruits.Skip(3))
// Console.WriteLine(fruit);


//segundo ejemplo ///////////////////////////////////////////////////////////////////////////////////////////


namespace LINQDemo
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Calificacion { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { Id = 1, Nombre = "Juan", Edad = 20, Calificacion = 8.5 },
                new Estudiante { Id = 2, Nombre = "Ana", Edad = 22, Calificacion = 9.0 },
                new Estudiante { Id = 3, Nombre = "Carlos", Edad = 19, Calificacion = 7.5 },
                new Estudiante { Id = 4, Nombre = "Lucía", Edad = 21, Calificacion = 8.8 },
                new Estudiante { Id = 5, Nombre = "Pedro", Edad = 23, Calificacion = 6.9 }
            };

            var estudiantesAltasCalificaciones = from estudiante in estudiantes
                                                 where estudiante.Calificacion > 8
                                                 select estudiante;

            Console.WriteLine("Estudiantes con calificaciones mayores a 8:");
            foreach (var estudiante in estudiantesAltasCalificaciones)
            {
                Console.WriteLine($"{estudiante.Nombre} - {estudiante.Calificacion}");
            }

            var estudiantesOrdenadosPorEdad = from estudiante in estudiantes
                                              orderby estudiante.Edad
                                              select estudiante;

            Console.WriteLine("\nEstudiantes ordenados por edad:");
            foreach (var estudiante in estudiantesOrdenadosPorEdad)
            {
                Console.WriteLine($"{estudiante.Nombre} - {estudiante.Edad} años");
            }

            var mejorEstudiante = estudiantes.OrderByDescending(patata => patata.Calificacion).FirstOrDefault();

            Console.WriteLine($"\nEl estudiante con la mejor calificación es: {mejorEstudiante.Nombre} con una calificación de {mejorEstudiante.Calificacion}");
        }
    }
}






