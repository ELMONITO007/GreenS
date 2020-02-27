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
   public class Auditor : Persona
    {

        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo numeros")]
        [Required]
        [DataMember]
        [DisplayName("Numero de credencial")]
        public int numero_Credencial { get; set; }

    }
}
