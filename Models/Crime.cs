using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimelabHelper.Models
{
    // Клас моделі для таблиці crimes
    public class Crime
    {
        [Key]
        public int CrimeId { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public string Type { get; set; }
    }
}
