using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class Contact
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        public String FirstName { get; set; }

        public String MiddleName { get; set; }

        public String LastName { get; set; }

        [DisplayFormat(DataFormatString = "{0: yyyy/MM/dd}")]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String MobileNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String TelephoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        public String FaxNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }
    }
}