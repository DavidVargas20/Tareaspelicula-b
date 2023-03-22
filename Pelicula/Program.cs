using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {

        private string titulo;
        private  Int16 año;
        private string pais;
        private string director;

    

        
        private List<Actor> actores = new List<Actor>();
         
        

        //Constructores
          public Pelicula ( string titulo , Int16 año)
          {
             this.titulo= titulo;
             this.año = año;
              
          }
        //Métodos

          public string Gettitulo(){
            return titulo; }
          public void  setTitulo( string t ){ 
            titulo= t;}

          public Int16 GetAño ( ){
            return año; }
          public void setAño ( Int16 y ){
             año = y;}

          public string getdirector(){ 
            return director;}
          public void setdirector(string dr){ 
            director= dr;}

          public string getpais( ){
             return pais;}
          public void setpais( string p){
            pais= p;}


        public void Imprimep()
        {
         Console.WriteLine($"{titulo} ({año})");
            
        }
        
    }

    public class Actor
    {
        string nombre;
        Int16 año;
        
        public Actor(){}
        public Actor (string nombre , Int16 año )
        {
            this.nombre=nombre;
            this.año=año;

        }
        //Propiedades
        //Constructores
        //Metodos 
        
         public string getNombre ()
         {
            return nombre;
         }
         public void setNombre ( string name )
         { 
            nombre= name;
         }
         
         public Int16 getaño()
         { 
            return año;
         }
         public void setAño( Int16 year )
         { 
            año = year;
         }
        
        
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
          
             Pelicula p1 = new Pelicula();
             Pelicula p2 = new Pelicula();

             p1.setTitulo(" La La Land");
             p1 .setAño (2018);
             Console.WriteLine("{0}({1}))" , p1.Gettitulo() , p1.GetAño());
              p1.Imprimep();


             
             

        }
    }
}
