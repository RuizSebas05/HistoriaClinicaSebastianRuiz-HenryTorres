using System;

namespace HistoriaClinicaDigital
{
    struct Paciente
    {
        private string nombre;
        private string apellidos;
        private int cedula;
        private string afiliacion;
        private string regimen;
        private string eps;
        private string historiaClinica;
        private string enfermedadRelevante;
        private int semanascotizadas;
        private int costotratamiento;
        private int cantidadenfermedades;
        public DateTime FechaIngresoAlsistema;
        public DateTime FechaingresoActualEps;
        public int edad;

        public Paciente(string nombre, string apellidos, int cedula, string afiliacion, string regimen, string eps, string historiaClinica, string enfermedadRelevante, int semanascotizadas, int costotratamiento, int cantidadenfermedades, DateTime fechaIngresoAlsistema, DateTime fechaingresoActualEps, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.cedula = cedula;
            this.afiliacion = afiliacion;
            this.regimen = regimen;
            this.eps = eps;
            this.historiaClinica = historiaClinica;
            this.enfermedadRelevante = enfermedadRelevante;
            this.semanascotizadas = semanascotizadas;
            this.costotratamiento = costotratamiento;
            this.cantidadenfermedades = cantidadenfermedades;
            this.FechaIngresoAlsistema = fechaIngresoAlsistema;
            this.FechaingresoActualEps = fechaingresoActualEps;
            this.edad = edad;
        }

        public DateTime fechaIngresoAlsistema
        {
            get { return FechaIngresoAlsistema; }
            set { FechaIngresoAlsistema = value; }
        }

        public DateTime fechaingresoactualeps
        {
            get { return fechaingresoactualeps; }
            set { fechaingresoactualeps = value; }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Regimen { get => regimen; set => regimen = value; }
        public string HistoriaClinica { get => historiaClinica; set => historiaClinica = value; }
        public string EnfermedadRelevante { get => enfermedadRelevante; set => enfermedadRelevante = value; }
        public string Afiliacion { get => afiliacion; set => afiliacion = value; }
        public string EPS { get => eps; set => eps = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public int Semanascotizadas { get => semanascotizadas; set => semanascotizadas = value; }
        public int Cantidadenfermedades { get => cantidadenfermedades; set => cantidadenfermedades = value; }
        public int Costostratamiento { get => costotratamiento; set => costotratamiento = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}