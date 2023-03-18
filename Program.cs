using System;

namespace HistoriaClinicaDigital
{
    class program
    {

        static void Main(string[] args)
        {
            List<Paciente> pacienteEps = new List<Paciente>();
            pacienteEps.Add(new Paciente("Jose", "Rojas", 123, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 123, 206748, 0, new DateTime(2008, 12, 2),
                new DateTime(2020, 12, 2), 10));
            pacienteEps.Add(new Paciente("Pepe", "Rojas", 111, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 243, 34236, 0, new DateTime(2008, 12, 2),
                new DateTime(2020, 12, 2), 10));
            pacienteEps.Add(new Paciente("Monica", "Rojas", 345, "beneficiario", "subsidiado", "savia", "Esta es mi historia clinica", "cancer", 32234, 0, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 14));
            pacienteEps.Add(new Paciente("Carmen", "Rojas", 234, "beneficiario", "subsidiado", "savia", "Esta es mi historia clinica", "cancer", 234567, 0, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 17));
            pacienteEps.Add(new Paciente("Jose", "Caraballo", 567, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 7654343, 20, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 20));
            pacienteEps.Add(new Paciente("Pepe", "Bolillo", 765, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 43, 20343, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 30));
            pacienteEps.Add(new Paciente("Pepe", "Rolo", 765, "beneficiario", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 43, 3435, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 33));
            pacienteEps.Add(new Paciente("Pepe", "Cereno", 765, "beneficiario", "contributivo", "savia", "Esta es mi historia clinica", "cancer", 32, 7654, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 50));
            pacienteEps.Add(new Paciente("Julio", "Bolillo", 890, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 20, 6454, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 60));
            pacienteEps.Add(new Paciente("Rosa", "Bolillo", 098, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 654, 22340, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 70));
            pacienteEps.Add(new Paciente("Cristo", "rey", 9765, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 0, 2320, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 80));
            pacienteEps.Add(new Paciente("Arnulfo", "chonto perea", 67899, "cotizante", "contributivo", "sura", "Esta es mi historia clinica", "cancer", 0, 20, 2, new DateTime(2008, 12, 2),
                new DateTime(2008, 12, 2), 99));
            Boolean menu = true;
            do
            {
                Console.WriteLine("Seleccione la opción que desea: ");
                Console.WriteLine("1. Para ingresar persona \n2. Cambiar eps \n3. Mostrar estadisticas");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ingresarpaciente(pacienteEps);
                        break;

                    case 2:
                        ConsultarPacienteYModificar(pacienteEps);
                        break;

                    case 3:
                        estadisticas(pacienteEps);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear(); //Limpiar la consola

            } while (menu);

        }

        public static void ingresarpaciente(List<Paciente> pacientes)
        {
            string nombre, apellido, regimen, afiliacion, eps, historiaClinica, enfermedadRelevante;
            Console.WriteLine("Ingrese su nomnre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su cedula: ");
            int cedula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el tipo de afiliación: cotizante \n beneficiario");
            afiliacion = Console.ReadLine();
            Console.WriteLine("Ingrese tipo de regimen: contributivo \n subsidiado");
            regimen = Console.ReadLine();
            Console.WriteLine("Ingresa a que EPS pertenece: Sura \n savia");
            eps = Console.ReadLine();
            Console.WriteLine("ingresa tu historia clinica: ");
            historiaClinica = Console.ReadLine();
            Console.WriteLine("Ingresa tu enfermedad mas relevante: ");
            enfermedadRelevante = Console.ReadLine();
            Console.WriteLine("Digite el costo de su tratamiento: ");
            int costotratamiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese semanas cotizadas: ");
            int semanascotizadas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de enfermedeade que padece: ");
            int cantidadenfermedades = Convert.ToInt32(Console.ReadLine());
            DateTime FechaIngresoAlsistema = new DateTime(2014, 10, 23);
            DateTime FechaIngresoActualEps = new DateTime(2015, 10, 23);
            Console.WriteLine("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Paciente paciente = new Paciente(nombre, apellido, cedula, afiliacion, regimen, eps, historiaClinica, enfermedadRelevante, semanascotizadas, costotratamiento, cantidadenfermedades, FechaIngresoAlsistema, FechaIngresoActualEps, edad);
            pacientes.Add(paciente);
        }

        public static void ConsultarPacienteYModificar(List<Paciente> pacientes)
        {
            Console.WriteLine("Ingrese la cedula de la persona a modificar la EPS: ");
            int cedula = Convert.ToInt32(Console.ReadLine());
            bool encontrado = false;

            foreach (Paciente paciente in pacientes)
            {
                if (paciente.Cedula == cedula)
                {
                    Console.WriteLine("Paciente encontrado:");
                    Console.WriteLine("Cedula: {0}\n Nombre: {1}\n EPS: {2}", paciente.Cedula, paciente.Nombre, paciente.EPS);
                    Console.WriteLine("Modificar? (si/no)");
                    if (Console.ReadLine().ToLower().Trim() == "si")
                    {
                        ModificarEPS(paciente);
                    }
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Paciente no encontrado.");
            }
        }

        public static void ModificarEPS(Paciente paciente)
        {
            Console.WriteLine("Ingrese la nueva EPS: ");
            string nuevaEPS = Console.ReadLine();
            paciente.EPS = nuevaEPS;
            Console.WriteLine("EPS modificada exitosamente.");
        }


        static string ObtenerRangoEdad(int edad)
        {
            if (edad >= 0 && edad <= 12)
            {
                return "Niño";
            }
            else if (edad >= 12 && edad <= 18)
            {
                return "Adolescente";
            }
            else if (edad >= 18 && edad <= 30)
            {
                return "Joven";
            }
            else if (edad >= 30 && edad <= 55)
            {
                return "Adulto";
            }
            else if (edad >= 55 && edad <= 75)
            {
                return "Adulto Mayor";
            }
            else
            {
                return "Anciano";
            }
        }


    public static void estadisticas(List<Paciente> pacientes)
        {

            //PORCENTAJE DE COSTOS POR EPS
            var promediosPorEps = pacientes
            .GroupBy(p => p.EPS)
            .Select(g => new
            {
                Eps = g.Key,
                PromedioCostoTratamiento = g.Average(p => p.Costostratamiento)
            });
            foreach (var promedio in promediosPorEps)
            {
                Console.WriteLine("El promedio de costo de tratamiento de la EPS {0} es: {1}", promedio.Eps, promedio.PromedioCostoTratamiento);
            }
            Console.WriteLine("\n");


            //COSTOS TOTALES POR EPS
            var totalesPorEps = pacientes
            .GroupBy(p => p.EPS)
            .Select(g => new
            {
                Eps = g.Key,
                TotalCostoTratamiento = g.Sum(p => p.Costostratamiento)
            });

            foreach (var total in totalesPorEps)
            {
                Console.WriteLine("El total de costo de tratamiento de la EPS {0} es: {1}", total.Eps, total.TotalCostoTratamiento);
            }

            //PORCENTAJE DE PERSONAS SIN ENFERMEADES
            int totalPacientes = pacientes.Count();
            int pacientesConCeroEnfermedades = pacientes.Count(p => p.Cantidadenfermedades == 0);

            double porcentajePacientesConCeroEnfermedades = (double)pacientesConCeroEnfermedades / totalPacientes * 100;

            Console.WriteLine("El porcentaje de pacientes sin enfermedades es: {0}%", porcentajePacientesConCeroEnfermedades);
            Console.WriteLine("\n");


            //MAYOR COSTO EN TRATAMIENTOS
            Paciente personamayor = pacientes.OrderByDescending(p => p.Costostratamiento).First();
            Console.WriteLine("La persona con el costo de tratamiento mas costoso es: " + personamayor.Nombre + " Con cedula: " + personamayor.Cedula);
            Console.WriteLine("\n");

            //EDADES
            Console.WriteLine("PROMEDIO POR EDADES \n");
            int pacientestotal = pacientes.Count();
            var pacientesPorRangoEdad = pacientes.GroupBy(p => ObtenerRangoEdad(p.edad))
                                                 .Select(g => new
                                                 {
                                                     RangoEdad = g.Key,
                                                     Cantidad = g.Count(),
                                                     Porcentaje = (double)g.Count() / pacientestotal * 100
                                                 });
            foreach (var grupo in pacientesPorRangoEdad)
            {
                Console.WriteLine("Rango de edad: {0}, Cantidad: {1}, Porcentaje: {2}%", grupo.RangoEdad, grupo.Cantidad, grupo.Porcentaje);
            }
            Console.WriteLine("\n");

            //PORCENTAJE DE PACIENTES POR REGIMEN
            Console.WriteLine("PORCENTAJE DE PACIENTES POR REGIMEN");
            var pacientesPorRegimen = pacientes.GroupBy(p => p.Regimen)
                                           .Select(g => new { Regimen = g.Key, NumeroPacientes = g.Count(), PorcentajePacientes = (double)g.Count() / pacientes.Count * 100 });

            foreach (var grupo in pacientesPorRegimen)
            {
                Console.WriteLine("Regimen: {0}, Pacientes: {1}, Porcentaje: {2}%", grupo.Regimen, grupo.NumeroPacientes, grupo.PorcentajePacientes);
            }

            //PACIENTES CON CANCER
            Console.WriteLine("\n");
            int totalPacientesConCancer = pacientes.Count(p => p.EnfermedadRelevante.Contains("cancer"));

            Console.WriteLine("Total de pacientes con enfermedades cancer: {0}", totalPacientesConCancer);

        }
    }
}