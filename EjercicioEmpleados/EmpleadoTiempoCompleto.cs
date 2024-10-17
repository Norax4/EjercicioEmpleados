using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal class EmpleadoTiempoCompleto : Empleado
    {
        public decimal Bono {  get; set; }

        public EmpleadoTiempoCompleto(string nombre, decimal salario, decimal bono) : base(nombre, salario)
        {
            this.Bono = bono;
        } 

        public override decimal CalcularSalario()
        {
            return SalarioBase + Bono;
        }
    }
}
