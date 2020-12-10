using System;
using System.Collections.Generic;
using System.Text;

 namespace CapaLogica_ClassLibrary_
{
    public class Contabilidad
    {
        public double getSaldos(double saldoInicial)
        {
            double aux = saldoInicial + 1000 + saldoInicial * 0.1;
            return aux;
        }
        //Paremtros opcionales
        public string Saludos(string nombre="Ken Bastidas")
        {
            return "Hola " + nombre + ", welcome to Sytem of Contability!!!";
        }





    }
}
