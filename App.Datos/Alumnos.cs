//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumnos
    {
        public Alumnos()
        {
            this.Asistencias = new HashSet<Asistencias>();
            this.Notas = new HashSet<Notas>();
            this.Alumnos_Cursos = new HashSet<Alumnos_Cursos>();
        }
    
        public int id { get; set; }
        public string rut { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string sexo { get; set; }
    
        public virtual ICollection<Asistencias> Asistencias { get; set; }
        public virtual ICollection<Notas> Notas { get; set; }
        public virtual ICollection<Alumnos_Cursos> Alumnos_Cursos { get; set; }
    }
}