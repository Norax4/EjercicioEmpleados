using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEmpleados
{
    internal class EmpleadoPorHora : Empleado
    {

        public int HorasTrabajadas {  get; set; }
        public decimal TarifaPorHora { get; set; }

        public EmpleadoPorHora(string nombre, int horasTrabajadas, decimal tarifaHora) : base(nombre)
        {
            HorasTrabajadas = horasTrabajadas;
            TarifaPorHora = tarifaHora;
        }

        public override decimal CalcularSalario()
        {
            return SalarioBase = HorasTrabajadas * TarifaPorHora;
        }
    }
}
