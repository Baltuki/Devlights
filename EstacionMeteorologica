using POO_TP;

namespace POO_TP
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

        protected Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }


    public class Pasante : Persona
    {
        public int numeroLegajo { get; set; }

        public Pasante(string nombre, string apellido, int numeroLegajo) : base(nombre, apellido)
        {
            this.numeroLegajo = numeroLegajo;
        }
    }
    public class Profesional : Persona
    {
        public int numeroMatricula { get; set; }

        public Profesional(string nombre, string apellido, int numeroMatricula) : base(nombre, apellido)
        {
            this.numeroMatricula = numeroMatricula;
        }


    }


    public class RegistroTemperatura
    {
        public int Temperatura { get; set; }
        public Persona PersonaDeTurno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraRegistro { get; set; }


        public RegistroTemperatura(int temperatura, Persona personaDeTurno, DateTime fechaRegistro, TimeSpan horaRegistro)
        {
            Temperatura = temperatura;
            PersonaDeTurno = personaDeTurno;
            FechaRegistro = fechaRegistro;
            HoraRegistro = horaRegistro;

        }
    }

    public class EstacionMeteorologica
    {
        public RegistroTemperatura[,] registros;

        public List<Profesional> Profesionales { get; set; }
        public List<Pasante> Pasantes { get; set; }

        public EstacionMeteorologica()
        {
            registros = new RegistroTemperatura[5, 7];
            Profesionales = new List<Profesional>();
            Pasantes = new List<Pasante>();
            CargarTemperaturas();
        }

        public void RegistrarTemperatura(RegistroTemperatura registro, int semana, int dia)
        {
            registros[semana - 1, dia - 1] = registro;
        }

        public void VerTemperaturas(int semana, int dia)
        {
            var registro = registros[semana - 1, dia - 1];
            Console.WriteLine($"Temperatura: {registro.Temperatura}°C, Registrada por: {registro.PersonaDeTurno.nombre} {registro.PersonaDeTurno.apellido} a las {registro.HoraRegistro}");


        }

        public void CargarTemperaturas()
        {

            Random rnd = new Random();
            Profesionales.Add(new Profesional("Fernando", "Lujan", 7733));
            Pasantes.Add(new Pasante("Baltazar", "Sanchez", 4921));

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    registros[i, j] = new RegistroTemperatura(
                        rnd.Next(-10, 35),
                        (i + j) % 2 == 0 ? (Persona)Profesionales[0] : (Persona)Pasantes[0],
                        DateTime.Now,
                        new TimeSpan(rnd.Next(0, 24), rnd.Next(0, 60), 0)
                    );
                }
            }
        }

        public double verPromedioTotal()
        {
            int suma = 0;
            int cantidadCargadas = 0;

            foreach (RegistroTemperatura registro in registros)
            {
                suma += registro.Temperatura;
                cantidadCargadas++;
            }

            return suma / cantidadCargadas;

        }

        public double verPromedioSemanal(int semana)
        {
            int suma = 0;
            int cantidadCargadas = 0;
            for (int i = 0; i < 5; i++) 
            {
                if (i == semana - 1) 
                {
                    for (int j = 0; j < 7; j++)
                    {
                        var registro = registros[i, j];
                  
                        suma += registro.Temperatura; 
                        
                        cantidadCargadas++; 
                        
                    }
                    
                }
            }
            return suma / cantidadCargadas;
        }


    }
}
