namespace Empresa
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.Write("Cuantos Empleados desea registrar?");
            int Respuesta = Convert.ToInt32(Console.ReadLine());
            Empleados[] e = new Empleados[Respuesta];
            for (int i = 0; i < Respuesta; i++)
            { 
                Console.WriteLine("Empleado N/" + (1 + i));
                Console.WriteLine("---------------------");
                int id =(01+i);
                Console.WriteLine("Ingrese el Nombre");
                var nombre = Console.ReadLine();
                Console.WriteLine("Es Hombre?");
                var genero = Console.ReadLine();
                if (genero == "no")
                {
                    genero = "Mujer";
                }
                else if (genero == "si")
                {
                    genero = "Hombre";
                }
                Console.WriteLine("Ingrese el Sueldo que ganara");
                var sueldo =Convert.ToInt32(Console.ReadLine());
                e[i] = new Empleados(id,nombre,genero,sueldo);
                Console.WriteLine("                                    ");
                //e[i].mostrar();
            }
            int Mujeres=0;
            int Hombres = 0;
            for(int i = 0; i < Respuesta; i++)
            {
                if (e[i].getSueldo() >= 500 && e[i].getGenero() == "Mujer")
                {
                    Mujeres++;
                 
                }
                
               if (e[i].getSueldo() <= 400 && e[i].getGenero() == "Hombre")
                {
                    Hombres++;

                }
                
               
            }
            Console.WriteLine("Hay " + Mujeres + " Mujeres ganando mas de 500 dolares en la empresa");
            Console.WriteLine("Hay " + Hombres + " Hombres ganando menos de 400 dolares en la empresa");



            /* Console.WriteLine("---------------------------------");
             Console.WriteLine("Hombres con un sueldo menor a 400");
             Console.WriteLine("---------------------------------");
             e[i].mostrardatos();

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Mujeres con un sueldo mayor a 500");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(Mujeres[i].getSueldo());*/

        }
    }
}