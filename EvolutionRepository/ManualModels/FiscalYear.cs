using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EvolutionRepository.ManualModels
{
    public class FiscalYear
    {
        [Key]
        public Int32 Id { get; set; }

        public String Description { get; set; }

        public virtual FiscalPeriodType FiscalperiodType { get; set; }

        public Int32 Year { get; set; }

        public Int32 StartPeriodMonth { get; set; }

        public Int32 StartperiodDay { get; set; }

        public Int32 NumberofDaysGrace { get; set; }
    }
}