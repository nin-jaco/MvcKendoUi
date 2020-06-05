﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionRepository.ManualModels
{
    public class GetAreaListResult
    {

        public GetAreaListResult(Array _data, int _count)
        {
            this.Data = _data;
            this.Count = _count;
        }

        public Array Data { get; set; }
        public int Count { get; set; }
    }
}