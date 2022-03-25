Console.Clear();
Curso c1 = new Curso();
c1.Calcular();
c1.Mostrar();

class Curso
{
    // CONSTANTES
    const float MAX_NOTA = 7.0F;
    const float MIN_NOTA = 1.0F;

    // VARIABLES
    int cantAlumnos = 0;
    float[] notas;
    float promedio;
    float minimo = MAX_NOTA;
    float maximo = MIN_NOTA;

    public Curso()
    {
        do
        {
            Console.Write("Ingrese la cantidad de alumnos: ");
            cantAlumnos = int.Parse(Console.ReadLine());
            if (cantAlumnos < 1)
            {
                Console.Clear();
                Console.WriteLine("*****************************************************");
                Console.WriteLine("** La cantidad de alumnos no puede ser menor que 1 **");
                Console.WriteLine("*****************************************************");
                Console.Write("Cualquier tecla para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        } while (cantAlumnos < 1);

        notas = new float[cantAlumnos];
        for (int i = 1; i <= cantAlumnos; i++)
        {
            float notaActual;
            do
            {
                Console.Write("Ingrese la nota para el alumno {0}: ", i);
                notaActual = int.Parse(Console.ReadLine());
                if ((notaActual < 1) || (notaActual > 7))
                {
                    // Console.Clear();
                    Console.WriteLine("*********************************************");
                    Console.WriteLine("** La nota debe estar en el rango de 1 a 7 **");
                    Console.WriteLine("*********************************************");
                    Console.Write("Cualquier tecla para continuar...");
                    Console.ReadLine();
                    // Console.Clear();
                }
                else
                {
                    notas[i - 1] = notaActual;
                }
            } while ((notaActual < 1) || (notaActual > 7));
        }
    }

    public void Calcular()
    {
        float suma = 0;
        foreach (float nota in notas)
        {
            suma += nota;
            if (nota > maximo)
            {
                maximo = nota;
            }
            ;

            if (nota < minimo)
            {
                minimo = nota;
            }
            ;
        }
        promedio = suma / cantAlumnos;
    }

    public void Mostrar()
    {
        Console.WriteLine("***************************************");
        Console.WriteLine("El promedio de las {1} notas es: {0}", promedio, cantAlumnos);
        Console.WriteLine("La mayor nota es: {0}", maximo);
        Console.WriteLine("La menor nota es: {0}", minimo);
    }
}
