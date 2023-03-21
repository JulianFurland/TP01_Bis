Console.WriteLine("Ingresa *C* para agregar un curso, *S* para las estadísticas, u otra cosa para terminar");
string ingreso = Console.ReadLine().ToLower();
Dictionary<string,int> DicCursos = new Dictionary<string,int>();
while(ingreso == "c" || ingreso == "s")
{
switch(ingreso)
{
    case "c":
    Console.WriteLine("Ingresa el nombre del curso, o -1 para terminar");
    string nombreCurso = Console.ReadLine();
    while (nombreCurso != "-1")
    {
        DicCursos.Add(nombreCurso, 0);
        Console.WriteLine("Ingresa la cantidad de alumnos en el curso");
        int cantEst = int.Parse(Console.ReadLine());
        for(int i = 0; i < cantEst; i++)
        {  
            Console.WriteLine("Ingresa la cantidad de plata que ingreso el alumno " + (i+1).ToString());
            int plata = int.Parse(Console.ReadLine());
            DicCursos[nombreCurso] += plata;
        }
        Console.WriteLine("Ingresa el nombre de otro curso, o -1 para terminar");
        nombreCurso = Console.ReadLine();
    }
    break;
    case "s":
    string mayorRecS = "";
    int mayorRecI = 0;
    double promedioRec = 0;
    int recaudacionTotal = 0;
    foreach (string curso in DicCursos.Keys)
    {
        if(DicCursos[curso] > mayorRecI)
        {
            mayorRecI = DicCursos[curso];
            mayorRecS = curso;
        }
        recaudacionTotal += DicCursos[curso];
    }
    promedioRec = recaudacionTotal / DicCursos.Count;
    Console.WriteLine("El curso que mas aporto fue: " + mayorRecS);
    Console.WriteLine("El promedio de plata recaudada por curso es: " + promedioRec);
    Console.WriteLine("La recaudacion total es: " + recaudacionTotal);
    Console.WriteLine("La cantidad de cursos que aportaron fue: " + DicCursos.Count);
    break;
}
Console.WriteLine("Ingresa *C* seguir agregando cursos, *S* para las estadísticas, u otra cosa para terminar");
ingreso = Console.ReadLine().ToLower();
}