using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica33
{
    class Materia
    {
        Estudiante estudiante;


        private string nombreMateria;
        private double nota1;
        private double nota2;
        private double nota3;
        private double definitiva;


        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Definitiva { get => definitiva; set => definitiva = value; }
        internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }
    }
}
