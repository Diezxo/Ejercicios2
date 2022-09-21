using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Empleados
    {
        private int id;
        private string? nombre;
        private string? genero;
        private int sueldo;

        public Empleados(int Id, string? Nombre, string? IsMale, int Sueldo)
        {
         id = Id;
         nombre = Nombre;
         sueldo = Sueldo;
         genero = IsMale;
        }
        public int getSueldo()
        {
         return sueldo;
        }
        public string? getGenero()
        {
         return genero;
        }
        public string? getNombre()
        {
         return nombre;
        }
        public void mostrardatos()
        {
         Console.WriteLine("Numero de Legajo: 00" + id);
         Console.WriteLine("Nombre: " + nombre);
         Console.WriteLine("Genero: " + genero);
         Console.WriteLine("Sueldo: " + sueldo);
        }
    }
}
