﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvolutionRepository.ManualModels
{
    public class DataTableModel
    {
        public string sEcho { get; set; }
        public string sSearch { get; set; }
        public int iDisplayLength { get; set; }
        public int iDisplayStart { get; set; }
        public int iColumns { get; set; }
        public int iSortingCols { get; set; }
        public string sColumns { get; set; }
    }
}
