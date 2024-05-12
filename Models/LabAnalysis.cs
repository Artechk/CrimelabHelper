using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimelabHelper.Models
{
    // Клас моделі для таблиці lab_analyses
    public class LabAnalysis
    {
        [Key]
        public int AnalysisId { get; set; }
        public int EvidenceId { get; set; }
        public DateTime Date { get; set; }
        public string Results { get; set; }
    }
}
