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
         
          public string Gettitulo(){return titulo; }
          public void  setTitulo( string t ){ titulo= t;}

          public Int16 GetAño ( ){return año; }
          public void setAño ( Int16 y ){ año = y;}

          public string getdirector(){ return director;}
          public void setdirector(string dr){ director= dr;}

          public string getpais( ){ return pais;}
          public void setpais( string p){pais= p;}
          

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
          
             

             
             

        }
    }
}
