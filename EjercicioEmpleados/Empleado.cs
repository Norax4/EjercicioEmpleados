using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal abstract class Empleado
    {
        public string? Nombre {  get; set; }
        public decimal SalarioBase { get; set; }

        public Empleado() { }
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }
        public Empleado(string nombre, decimal salarioBase) : this(nombre)
        {
            SalarioBase = salarioBase;
        }

        public abstract decimal CalcularSalario();
    }
}
