using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public String Nombre { get; set; } = string.Empty; 
        public String Departamento { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public bool JornadaCompleta { get; set; }
    }
}
