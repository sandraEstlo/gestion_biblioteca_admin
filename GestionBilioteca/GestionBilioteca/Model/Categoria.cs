using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Class
{
    [Serializable]
    public class Categoria
    {
        private int id;
        private string nombre;

        public Categoria() { }

        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"{Id} {Nombre}";
        }
    }
}
