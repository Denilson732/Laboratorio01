using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] persona = new Persona[0];
            persona[0] = new Persona[];


            string[] SanSalvador = { "Apopa", "Aguilares", "Cuscatancingo", "El Paisnal", "Guazapa", "Mejicanos" };
            string[] Chalatenango = { "San Antonio los Ranchos", "San Antonio de la Cruz", "Arcatao" };
            string[] Morazan = { "Cacaopera", "Jocoro", "San Carlos", "San Fernando", "San Isidro", "Perquin", "Torola" };
            string[] SantaAna = { "El Congo", "Masauat", "Chalcuapa", "Coatepeque", "Santa Ana" };
            string[] SanMiguel = { "Carolina", "Chapeltique", "Chinameca", "Chirilagua", "Ciudad Barrios", "Comacarán", "El Tránsito", "Lolotique" };
        }
    }
}


public class Persona
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string Departamento { get; set; }
    public string Municipio { get; set; }
}



Console.Write("Ingrese el nombre de la persona: ");
string nombre = Console.ReadLine();





