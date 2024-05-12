using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimelabHelper.Models
{
    // Клас моделі для таблиці suspects
    public class Suspect
    {
        [Key]
        public int SuspectId { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public int CrimeId { get; set; }
    }
}
