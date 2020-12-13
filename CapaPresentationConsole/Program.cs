using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variables
            double saldo;
            string nombre, fecha;
            int numeroMes;

            CapaLogica_ClassLibrary_.Contabilidad conta = new CapaLogica_ClassLibrary_.Contabilidad();
            //Capa.Contabilidad conta = new CapaLogica.Contabilidad();

            Console.WriteLine("Ingrese los siguientes valores:");
            Console.WriteLine();

            //Llenando Variables
            Console.Write("El Saldo inicial es: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Numero del mes: ");
            numeroMes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fecha: ");
            fecha = Console.ReadLine();

            //Aplicando funciones
            Console.WriteLine();
            Console.WriteLine("Resultado sueldo: {0}", conta.getSaldos(saldo));
            Console.WriteLine(conta.Saludos(nombre));
            Console.WriteLine(CapaLogica_ClassLibrary_.Utilidades.getNombreDelMes(numeroMes));
            Console.WriteLine(CapaLogica_ClassLibrary_.Utilidades.FECHA(fecha));

            Console.ReadKey();
        }
    }
}
