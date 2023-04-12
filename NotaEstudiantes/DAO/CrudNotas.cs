using NotaEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaEstudiantes.DAO
{
    public class CrudNotas
    {

        public void añadirNotas()
        {

            using(NotaEstudianteContext db = new NotaEstudianteContext())
            {

                Notum notas = new Notum();

                Console.WriteLine("\nIngresa el Nombre del Estudiante:");
                notas.NombreEstudiante = Console.ReadLine();

                Console.WriteLine("\nIngresa la nota del laboratorio 1:");
                notas.Lab1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa la nota del parcial 1:");
                notas.Par1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa la nota del laboratorio 2:");
                notas.Lab2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa la nota del parcial 2:");
                notas.Par2 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa la nota del laboratorio 3:");
                notas.Lab3 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nIngresa la nota del parcial 3:");
                notas.Par3 = decimal.Parse(Console.ReadLine());

                Console.WriteLine($"\nLa nota final es {(notas.Lab1+ notas.Par1+ notas.Lab2 + notas.Par2 + notas.Lab3 + notas.Par3)/6}");
                notas.Resultado = (notas.Lab1 + notas.Par1 + notas.Lab2 + notas.Par2 + notas.Lab3 + notas.Par3) / 6;

                db.Add(notas);
                db.SaveChanges();
                Console.WriteLine("Los datos se añadieron exitosamente\n");


            }

        }

        public void CambiarNotas(int id)
        {
            using(NotaEstudianteContext db = new NotaEstudianteContext())
            {

                
                var notas = db.Nota.FirstOrDefault(x => x.IdNotas == id);

                Console.WriteLine("Que deseas actualizar\n");
                Console.WriteLine("Coloca el numero de la opcion\n");
                Console.WriteLine("" +
                    "1.Cambiar nombre...\n" +
                    "2.Cambiar nota lab1...\n" +
                    "3.cambiar nota Parcial1...\n" +
                    "4.Cambiar nota lab2...\n" +
                    "5.Cambiar nota Parcial2...\n" +
                    "6.Cambiar nota lab3...\n" +
                    "7.Cambiar nota Parcial3...\n");

                int opcion = Int32.Parse(Console.ReadLine());

                foreach (var item in db.Nota)
                {

                    string? nombre = item.NombreEstudiante;
                    var labo1 = item.Lab1;
                    var par1 = item.Par1;
                    var labo2 = item.Lab2;
                    var par2 = item.Par2;
                    var labo3 = item.Lab3;
                    var par3 = item.Par3;
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Coloca el nuevo nombre");
                            nombre = Console.ReadLine();

                            break;

                        case 2:
                            Console.WriteLine("Coloca la nueva nota");
                            labo1 = decimal.Parse(Console.ReadLine());
                            break;

                        case 3:
                            Console.WriteLine("Coloca la nueva nota");
                            par1 = decimal.Parse(Console.ReadLine());
                            break;


                        case 4:
                            Console.WriteLine("Coloca la nueva nota");
                            labo2 = decimal.Parse(Console.ReadLine());
                            break;

                        case 5:
                            Console.WriteLine("Coloca la nueva nota");
                            par2 = decimal.Parse(Console.ReadLine());
                            break;

                        case 6:
                            Console.WriteLine("Coloca la nueva nota");
                            labo3 = decimal.Parse(Console.ReadLine());
                            break;

                        case 7:
                            Console.WriteLine("Coloca la nueva nota");
                            par3 = decimal.Parse(Console.ReadLine());
                            break;
                    }
                    notas.NombreEstudiante = nombre;
                    notas.Lab1 = labo1;
                    notas.Lab2 = labo2; 
                    notas.Lab3 = labo3;
                    notas.Par1 = par1;
                    notas.Par2 = par2;
                    notas.Par3 = par3;
                }


                db.Update(notas);
                db.SaveChanges();


            }
        }



    }
}
