using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {

        public string titulo {get;set;}
        public  Int16 año {get;set;}
        public string pais {get;set;}
         public string director {get;set;}

    

        
        private List<Actor> actores = new List<Actor>();
         
        

        //Constructores
          public Pelicula ( string titulo , Int16 año)
          {
             this.titulo= titulo;
             this.año = año;
              
          }



        //Métodos
     
        public void Imprimepe()
        {
         //Console.WriteLine($"{titulo} ({año})");
            
        }
        
    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
           // Console.WriteLine($"{titulo} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
          
             Pelicula p1 = new Pelicula ("avatar", 2023);
             Console.WriteLine ( p1 );

             
             

        }
    }
}
