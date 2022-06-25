using System;

namespace Desafio_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {            
            int cantidadPersonas;            
            decimal porcentajePropina, porcentajeImpuesto;
            decimal importe, montoTotalPagar, montoTotalPagarxPorsona;

            try
            {
                Console.WriteLine("========= DASAFIO - EJERCICIO 2 ====================");
                Console.WriteLine("A continuación debe ingresar los 4 datos requeridos:"); 
                Console.Write("1. Ingrese el monto Total a pagar: ");
                importe = Convert.ToDecimal(Console.ReadLine());

                Console.Write("2. ¿Entre cuantas personas se divirá la cuenta?: ");
                cantidadPersonas = Convert.ToInt32(Console.ReadLine());

                Console.Write("3. Ingrese porcentaje de propina a incluir: ");
                porcentajePropina = Convert.ToDecimal(Console.ReadLine());

                Console.Write("4. Ingrese porcentaje del impuesto: ");
                porcentajeImpuesto = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("========= RESULTADOS ====================");
                var propina = importe * (porcentajePropina / 100);
                var impuesto = importe * (porcentajeImpuesto / 100);

                montoTotalPagar = Math.Round(importe + propina + impuesto, 2);
                Console.WriteLine(String.Format("El monto total a pagar es: {0}", montoTotalPagar));

                montoTotalPagarxPorsona = Math.Round(montoTotalPagar / cantidadPersonas, 2);
                Console.WriteLine(String.Format("El total a pagar por persona es: {0}", montoTotalPagarxPorsona));
                Console.WriteLine("------------ FIN ------------------------");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
