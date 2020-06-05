using System;

namespace EvolutionRepository.ManualModels
{
    public class LogOnModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string LogOnResult { get; set; }
    }
}
