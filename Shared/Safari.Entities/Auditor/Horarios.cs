using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
namespace Safari.Entities.Auditor
{
    [Serializable]
    [DataContract]
   public class Horarios : EntityBase
    {
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo numeros")]
        [Required]
        [DataMember]
        [DisplayName("Dia de la semana")]
        public int dia_semana { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo numeros")]
        [Required]
        [DataMember]
        [DisplayName("Hora de inicio")]
        public int hora_inicio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo numeros")]
        [Required]
        [DataMember]
        [DisplayName("Hora de salida")]
        public int hora_salida { get; set; }

        [DataMember]
        public override int Id { get; set; }
    }
}
