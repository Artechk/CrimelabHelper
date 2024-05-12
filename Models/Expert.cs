using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimelabHelper.Models
{
    // Клас моделі для таблиці experts
    public class Expert
    {
        [Key]
        public int ExpertId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
    }
}
