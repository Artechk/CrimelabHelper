using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimelabHelper.Models
{
    // Клас моделі для таблиці investigation_reports
    public class InvestigationReport
    {
        [Key]
        public int ReportId { get; set; }
        public int CrimeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Conclusions { get; set; }
        public int ExpertId { get; set; } // Зміна Expert на ExpertId
    }
}
