using Consola_CS.Clases;
using Microsoft.VisualBasic;

static class Program
{
    private static int nn = 0;
    private static Contacto[] personas = new Contacto[1000];
    private static StreamReader leerArchivo;
    private static StreamWriter escribirArchivo;
    private static string path;

    // este programa se hizo para crear y leer un mismo archiv, este recopila los daatos del usuario para almacenarlos en un archivo txt
    public static void Main(string[] args)
    {
        bool x = false;
        while (x == false)
        {
            personas[nn] = new Contacto();
            try
            {
                // ubicacion dentro de la misma carpeta del programa
                path = @"C:\Users\axel1\source\Repos\Consola_CS\Consola_CS";
                Console.WriteLine("// ingresa los siguientes datos" + Constants.vbCrLf);
                Console.WriteLine("[1]- Ingresa tu nombre completo:");
                personas[nn].Nombre = Console.ReadLine();

                Console.WriteLine("[2]- Ingresa tu telefono:");
                personas[nn].Telefono = Console.ReadLine();

                Console.WriteLine("[3]- Ingresa tu correo:");
                personas[nn].Correo = Console.ReadLine();

                Console.WriteLine("[4]- Ingresa tu fecha de nacimiento (DD/MM/AAAA):");
                personas[nn].FechaNacimiento = Convert.ToDateTime(Console.ReadLine());


                int opc = 0;
                while (opc == 0)
                {
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("// escoge lo que quieres hacer");
                        Console.WriteLine("[1]- continuar agregando");
                        Console.WriteLine("[2]- leer archivo creado");
                        Console.WriteLine("[3]- salir");
                        opc = System.Convert.ToInt32(Console.ReadLine());
                        switch (opc)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    break;
                                }

                            case 2:
                                {
                                    using (var escribirArchivo = new StreamWriter(path))
                                    {
                                        for (int i = 0; i <= nn; i += 1)
                                            escribirArchivo.WriteLine(personas[i].Nombre + Constants.vbTab + personas[i].Telefono + Constants.vbTab + personas[i].Correo + Constants.vbTab + personas[i].Edad + Constants.vbTab);
                                        escribirArchivo.Close();
                                    }
                                    using (var leerArchivo = new StreamReader(path))
                                    {
                                        string linea = leerArchivo.ReadLine();
                                        while (linea != null)
                                        {
                                            Console.WriteLine(linea);
                                            linea = leerArchivo.ReadLine();
                                        }
                                    }

                                    break;
                                }

                            case 3:
                                {
                                    x = true;
                                    Console.WriteLine("// saliendo de la aplicacion...");
                                    break;
                                }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine("// eso no es una opcion, vuelvelo a intentar");
                        Console.ReadKey();
                    }
                }
                opc = 0;
                nn += 1;
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("// llena los datos de la manera correcta la proxima vez");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
