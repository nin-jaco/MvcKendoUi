using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class PhotoLibrary
    {
        public int PhotoID { get; set; }
        public string Key_ { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public byte[] upsize_ts { get; set; }
    }
}
