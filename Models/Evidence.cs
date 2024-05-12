using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimelabHelper.Models
{
    // Клас моделі для таблиці evidences
    public class Evidence
    {
        [Key]
        public int EvidenceId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int CrimeId { get; set; }
    }
}
