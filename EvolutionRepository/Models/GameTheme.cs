using System;
using System.Collections.Generic;

namespace EvolutionRepository.Models
{
    public partial class GameTheme
    {
        public GameTheme()
        {
            this.GameThemesCertifiedModels = new List<CertifiedModel>();
        }

        public int GameThemeID { get; set; }
        public string GameThemeName { get; set; }
        public Nullable<int> ManufacturerID { get; set; }
        public virtual ICollection<CertifiedModel> GameThemesCertifiedModels { get; set; }
    }
}
