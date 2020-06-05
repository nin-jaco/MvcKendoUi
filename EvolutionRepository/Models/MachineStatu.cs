using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class MachineStatu
    {
        public long MachineID { get; set; }
        public short MachineStatus { get; set; }
        public int PlayerCredit { get; set; }
        public int PlayerBet { get; set; }
        public int PlayerWin { get; set; }
        public byte DoorOpenStatus { get; set; }
        public byte MachineMode { get; set; }
        public short CurrentQueueSize { get; set; }
        public short MaximumQueueSize { get; set; }
        public System.DateTime StatusTime { get; set; }
    }
}
