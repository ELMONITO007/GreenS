using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Safari.Entities
{
    [Serializable]
    [DataContract]
    public abstract class Persona : EntityBase
    {
        [DataMember]
        public override int Id { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        [DataMember]
        [DisplayName("Nombre")]
        public string nombre { get; set; }

        [DataType(DataType.Text, ErrorMessage = "Ingrese texto")]
        [Required]
        [DataMember]
        [DisplayName("Apellido")]
        public string apellido { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo numeros")]
        [Required]
        [DataMember]
        [DisplayName("DNI")]
        public int dni { get; set; }



        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un email valido")]
        [Required]
        [DataMember]
        [DisplayName("Email")]
        public string email { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Ingrese solo numeros")]
        [Required]
        [DataMember]
        [DisplayName("Numero de Teléfono")]
        public int telefono { get; set; }


    }
}
