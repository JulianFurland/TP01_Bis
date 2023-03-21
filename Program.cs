string ingreso = IngresoStringToLower("Ingresa *C* para agregar un curso, *S* para las estadísticas, u otra cosa para terminar");
Dictionary<string,int> DicCursos = new Dictionary<string,int>();
while(ingreso == "c" || ingreso == "s")
{
switch(ingreso)
{
    case "c":
    string nombreCurso = IngresoStringToLower("Ingresa el nombre del curso, o -1 para terminar");
    while (nombreCurso != "-1")
    {
        DicCursos.Add(nombreCurso, 0);
        int cantEst = int.Parse(IngresoStringToLower("Ingresa la cantidad de alumnos en el curso"));
        for(int i = 0; i < cantEst; i++)
        {  
            int plata = int.Parse(IngresoStringToLower("Ingresa la cantidad de plata que ingreso el alumno " + (i+1).ToString()));
            DicCursos[nombreCurso] += plata;
        }
        nombreCurso = IngresoStringToLower("Ingresa el nombre de otro curso, o -1 para terminar");
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
ingreso = IngresoStringToLower("Ingresa *C* seguir agregando cursos, *S* para las estadísticas, u otra cosa para terminar");
}
string IngresoStringToLower(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine().ToLower();
}