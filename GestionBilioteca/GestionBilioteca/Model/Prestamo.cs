using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Class
{
    [Serializable]
    public class Prestamo
    {
        public static List<Prestamo> prestamos = new List<Prestamo>();

        private string idPrestamo;
        private string idLibro;
        private string idUsuario;
        private DateTime fechaPrestamo;
        private DateTime fechaDevolucion;
        private bool devuelto;
        public Prestamo() { }

        public Prestamo(string idPrestamo, string idLibro, string idUsuario, DateTime fechaPrestamo, DateTime fechaDevolucion, bool devuelto)
        {
            this.IdPrestamo = idPrestamo;
            this.IdLibro = idLibro;
            this.IdUsuario = idUsuario;
            this.FechaPrestamo = fechaPrestamo;
            this.FechaDevolucion = fechaDevolucion;
            this.Devuelto = devuelto;
        }

        public string IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public string IdLibro { get => idLibro; set => idLibro = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public bool Devuelto { get => devuelto; set => devuelto = value; }


        public override string ToString()
        {
            return $"{IdPrestamo.Trim(), 15} {IdLibro, -5} {IdUsuario, -5} {FechaPrestamo.ToString("dd/MM/yyyy"),-10} {FechaDevolucion} {Devuelto}";
        }
    }
}
