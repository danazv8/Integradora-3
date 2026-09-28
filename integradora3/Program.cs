using integradora3;

List<Alumno> listaAlumnos = new List<Alumno>();

int opcion;
do
{
    Console.WriteLine("---SISTEMA DE GESTIÓN DE ALUMNOS---");
    Console.WriteLine("1. Agregar alumno");
    Console.WriteLine("2. Listar alumnos");
    Console.WriteLine("3. Buscar alumno");
    Console.WriteLine("4. Promedio general");
    Console.WriteLine("5. Cantidad de aprobados");
    Console.WriteLine("6. Salir");
    Console.Write("Elegi una opción: ");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.Write("Ingrese el nombre del alumno: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese DNI del alumno: ");
            int dni = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el legajo del alumno: ");
            int legajo = int.Parse(Console.ReadLine());

            Alumno nuevoAlumno = new Alumno(nombre, dni, legajo);

            Console.WriteLine("Ingrese la primera nota del alumno: ");
            decimal nota1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota del alumno: ");
            decimal nota2 = decimal.Parse(Console.ReadLine());

            bool notasCargadas = nuevoAlumno.CargarNotas(nota1, nota2);
            if (notasCargadas)
            {
                listaAlumnos.Add(nuevoAlumno);
                Console.WriteLine("Alumno agregado correctamente.");
            }
            else
            {
                Console.WriteLine("Error.");
            }

            
            break;

        case 2:
            Console.WriteLine("Listado de alumnos:");
            foreach (Alumno alumno in listaAlumnos)
            {
                Console.WriteLine(alumno);
            }
            break;

        case 3:
            Console.Write("Ingrese legajo a buscar: ");
            int legajoBuscado = int.Parse(Console.ReadLine());
            bool encontrado = false;
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.Legajo == legajoBuscado)
                {
                    Console.WriteLine(alumno);
                    encontrado = true;
                    break;
                }
                
            }
            if (!encontrado)
            {
                Console.WriteLine("No exite alumno con ese legajo");
            }
            break;

        case 4:
            if (listaAlumnos.Count == 0)
            {
                Console.WriteLine("No hay alumnos cargaodr");

            }
            else
            {
                decimal sumaPromedios = 0;
                foreach (Alumno alumno in listaAlumnos)
                {
                    sumaPromedios += alumno.Promedio();

                }
                decimal promedioGeneral = sumaPromedios / listaAlumnos.Count;
                Console.WriteLine($"Promedio general: {promedioGeneral}");

            }
            break;

        case 5:
            int cantidadAprobados = 0;
            foreach (Alumno alumno in listaAlumnos)
            {
                if (alumno.EstaAprobado())
                {
                    cantidadAprobados++;
                }
            }
            Console.WriteLine($"Cantidad de aprobados: {cantidadAprobados}");

            break;

        case 6:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;

    }


}
while (opcion != 6);

List<Persona> personas = new List<Persona>();

personas.Add(new Alumno("Marta", 123321, 1234));
personas.Add(new Profesor("Marto", 321123, "Programacion"));
personas.Add(new Preceptor("Marti", 76543));

foreach (Persona persona in personas)
{
    Console.WriteLine(persona.Presentarse());

}

List<Materia> materias = new List<Materia>();
materias.Add(new Materia("PW1", "PROGRAMACION", 123));
materias.Add(new Materia("BD", "Bases de Datos", 321));

List<IExportable> exportables = new List<IExportable>();
exportables.AddRange(listaAlumnos);
Profesor profesor = new Profesor("Marta", 987654, "Programacion");
exportables.Add(profesor);
exportables.AddRange(materias);
Console.WriteLine("\n ---EXPORTACION---");

foreach (IExportable elemento in exportables)
{
    Console.WriteLine(elemento.ExportarLinea());

}
//Alumno alumno1 = new Alumno("Pepito", 1, 6, 6);
//Alumno alumno2 = new Alumno("Pepita", 2, 9, 9);
//Alumno alumno1 = new Alumno("Pepito", 1);
//Alumno alumno2 = new Alumno("Pepita", 2);

//Console.WriteLine($"Alumno: {alumno1.Nombre} - Legajo: {alumno1.Legajo}");
//  Console.WriteLine($"Alumno: {alumno2.Nombre} - Legajo: {alumno2.Legajo}");

//alumno1.Nombre = "Pepe";

//Console.WriteLine($"Alumno 1: {alumno1.Nombre} - Alumno 2: {alumno2.Nombre}");

//Alumno alumnoSinDatos = new Alumno(); 
// Error CS7036, por falta de argumentos en la instanciación.


//decimal promedioNotas = alumno1.Promedio();
//Console.WriteLine($"Promedio de notas del alumno {alumno1.Nombre}: {promedioNotas}");


//Console.WriteLine($"El alumno {alumno1.Nombre} está aprobado? {alumno1.EstaAprobado()}");

//alumno1.SubirNota();

//Console.WriteLine($"Nota nueva del alumno {alumno1.Nombre}: Nota1: {alumno1.Nota1}, Nota2: {alumno1.Nota2}");
//Console.WriteLine($"Promedio nuevo: {alumno1.Promedio()}");


//Console.WriteLine(alumno1);
//Console.WriteLine(alumno2);

// alumno1.Nota1 = 27; // Error CS0200, no se puede asignar a la propiedad Nota1 porque es de solo lectura.

//bool notasCargadas = alumno1.CargarNotas(8, 9);
//if  (notasCargadas)
//{
//    Console.WriteLine("Las notas se cargaron correctamente.");
//}
//else
//{
//    Console.WriteLine("Error, las notas no son válidas.");
//}

//listaAlumnos.Add(alumno1);
//listaAlumnos.Add(alumno2);
