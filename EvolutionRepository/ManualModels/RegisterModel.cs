using System;

namespace EvolutionRepository.ManualModels
{
    public class RegisterModel
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string RegisterResult { get; set; }
    }
}
