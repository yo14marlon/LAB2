
using NotaEstudiantes.DAO;


CrudNotas notas = new CrudNotas();

while (true)
{
    Console.Clear();
    Console.WriteLine("\n" +
        "Coloca el numero de la opcion:\n" +
        "1.Añadir notas\n" +
        "2.Cambiar notas\n" +
        "3.Ver todas las notas");

    int opcion = Int32.Parse(Console.ReadLine());

    Console.Clear();

    switch (opcion)
    {
        case 1:
            notas.añadirNotas();
            break;

        case 2:
            Console.WriteLine("Ingresa el id del estudiante: \n");
            notas.CambiarNotas(Int32.Parse(Console.ReadLine()));
            break;
            
            /*
             * No se porque da error
            case 3:
                var verNotas = notas.listarNotas();
                foreach (var ver in verNotas)
                {
                    Console.WriteLine($"\n" +
                        $"Nombre: {ver.NombreEstudiante}\n" +
                        $"Nota de laboratorio 1: {ver.Lab1}\n" +
                        $"Nota de Parcial 1: {ver.Par1}\n" +
                        $"Nota de laboratorio 2: {ver.Lab2}\n" +
                        $"Nota de Parcial 2: {ver.Par2}\n" +
                        $"Nota de laboratorio 3: {ver.Lab3}\n" +
                        $"Nota de Parcial 3: {ver.Par3}\n" +
                        $"Nota final:  {ver.Resultado}");
                }
               break;
            */
            
    }
}






