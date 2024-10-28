using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionBilioteca.Controller;

namespace GestionBilioteca.Class
{
    
    [Serializable]
    public class Libro
    {
        public static List<Libro> libros = new List<Libro>();

        private string idLibro;
        private string titulo;
        private string autor;
        private int categoria;
        private DateTime fechaPublicacion;
        private long isbn;
        private string descripcion;
        private int ejemplares;
        private int disponibles;
        private string imagen;

        //Constructos vacio
        public Libro() { }

        //Constructor sin imagen
        public Libro(string titulo, string autor, int categoria, DateTime fechaPublicacion, long isbn, string descripcion, int ejemplares, string imagen)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Categoria = categoria;
            this.FechaPublicacion = fechaPublicacion;
            this.Isbn = isbn;
            this.Descripcion = descripcion;
            this.Ejemplares = ejemplares;
            this.Disponibles = ejemplares;
            this.Imagen = imagen;
            this.IdLibro = Controlador_GestionBiblioteca.generarCodigoLibro(categoria,titulo,autor);
        }

        public string IdLibro { get => idLibro; set => idLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public long Isbn { get => isbn; set => isbn = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Ejemplares { get => ejemplares; set => ejemplares = value; }
        public int Disponibles { get => disponibles; set => disponibles = value; }
        public string Imagen { get => imagen; set => imagen = value; }

        public override string ToString()
        {
            return $"{IdLibro,-10} {Titulo,-40} {Autor,-30} {Categoria,-3} {FechaPublicacion.ToString("dd/MM/yyyy"),-10} {Isbn,-15} {Ejemplares,-3} {Disponibles,-3} {Imagen}";
        }
    }
}
