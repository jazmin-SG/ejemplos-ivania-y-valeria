class ejemploAdmid
    {
    public static void Main(String[] args)
    {

        string nombre;
        int op;
        Console.WriteLine(" 1 admin");
        Console.WriteLine(" 2 estudiante");
        op=int.Parse(Console.ReadLine());
        switch (op)
        {
            case 1:
                Console.WriteLine("Ingrese su usuario");
                string usuario = Console.ReadLine();
                Console.WriteLine(" Ingrese su contraseña");
                string pasw = (Console.ReadLine());
                if (usuario == "admin")
                {
                    if (pasw == "123")
                    {
                        Console.WriteLine("Acceso corecto");



                        Console.WriteLine(" 1 nota");
                        Console.WriteLine(" 2 lista de estudiante");
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {

                        }
                    }

                    else
                    {

                        Console.WriteLine(" contraseña incorecta");
                    }
                }

                else
                {
                    Console.WriteLine("usuario incorecta");
                }


                break;
            case 2:
                Console.WriteLine(" ingrese su usuario");
                string alumno = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña");
                string cont = Console.ReadLine();
                if (alumno == "alumno")
                {
                    if (cont =="1234")
                    {
                        Console.WriteLine("Acceso corecto");

                        Console.WriteLine(" 1 ver notas ");
                        Console.WriteLine(" 2 salir");
                        op = int.Parse(Console.ReadLine());
                        switch (op)
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }
                }
                else
                {
                    Console.WriteLine("Usuario incorrecto");
                }
                break;
            default:
                Console.WriteLine("opcion invalida");
                break;
        }
    
    }

}
