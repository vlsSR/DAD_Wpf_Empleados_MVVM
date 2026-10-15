using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.Models;

namespace WpfApp1.Services
{
    internal class EmpleadoService : IEmpleadoService
    {
        public List<Empleado> ObtenerEmpleadosMockup()
        {
            return new List<Empleado>
            {
                new Empleado { Id = 1, Nombre = "Juan Pérez", Departamento = "Frontend", Salario = 30000.00m, JornadaCompleta = true },
                new Empleado { Id = 2, Nombre = "María López", Departamento = "Backend", Salario = 36000.00m, JornadaCompleta = false },
                new Empleado { Id = 3, Nombre = "Carlos García", Departamento = "RRHH", Salario = 32000.00m, JornadaCompleta = true },
                new Empleado { Id = 4, Nombre = "Ana Martínez", Departamento = "Finanzas", Salario = 35000.00m, JornadaCompleta = true },
                new Empleado { Id = 5, Nombre = "Luis Fernández", Departamento = "Marketing", Salario = 25000.00m, JornadaCompleta = false }
            };
        }
    }
}
