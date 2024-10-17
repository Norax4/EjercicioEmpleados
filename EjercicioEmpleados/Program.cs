using EjercicioEmpleados;

EmpleadoPorHora eph = new EmpleadoPorHora("Liam", 45, 35);
EmpleadoTiempoCompleto etc = new EmpleadoTiempoCompleto("Jaime", 3400, 400);

Console.WriteLine(eph.Nombre + ", Salario: " + eph.CalcularSalario());
Console.WriteLine(etc.Nombre + ", Salario: " + etc.CalcularSalario());