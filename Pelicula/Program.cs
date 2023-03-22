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


        public void Imprime()
        {
         Console.WriteLine($"{titulo} ({año})");
            
        }
        public void AgregaActor ( Actor actor)
        {
            actores.Add(actor);
        }
        public void ImprimeActores()
        {
          
          foreach (Actor p in actores )

          {
             Console.WriteLine($"{p.getNombre()})({ p.getaño()}");

          }

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
          
             Pelicula p1 = new Pelicula("lalaland",2003);
            p1.AgregaActor(new Actor ("ryan Goslin" , 1900 ));
            p1.AgregaActor(new Actor ( "emma stone" , 1905 ));
            p1.Imprime();
            p1.ImprimeActores();
            
             Pelicula p2 = new Pelicula("ellas hablan ", 2022);
             p2.AgregaActor(new Actor("Clayre Foy", 2014));
             p2.AgregaActor(new Actor ( "Rooney Mara ", 1985));
             p2.Imprime();
             p2.ImprimeActores(); 


              

             List<Pelicula> peliculas = new List<Pelicula>();
             peliculas.Add (new Pelicula("ellas hablan", 2022));
            peliculas.Add (new Pelicula("ellas hablan", 2022));
            peliculas.Add (new Pelicula("ellas hablan", 2022));
            peliculas.Add (new Pelicula("ellas hablan", 2022));
            peliculas.Add (new Pelicula("ellas hablan", 2022));
            

               

             
             

        }
    }
}
