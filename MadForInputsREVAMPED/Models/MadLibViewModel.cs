namespace MadForInputsREVAMPED.Models
{
    public class MadLibViewModel
    {
        public int SelectedGenre { get; set; }
        public RandomTemplate? RandomTemplate { get; set; }
        public AdventureTemplate? AdventureTemplate { get; set; }
        public ComedyTemplate? ComedyTemplate { get; set; }
        public HorrorTemplate? HorrorTemplate { get; set; }
        public RomanceTemplate? RomanceTemplate { get; set; }
    }
}
