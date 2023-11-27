namespace MadForInputsREVAMPED.Models
{
    public class Madlib
    {
        public string Name { get; set; } = "Seth";
        public string Location { get; set; } = "Place";
        public string Verb { get; set; } = "Vomit";
        public string Adverb { get; set; } = "freely";
        public string Adjective { get; set; } = "deadly";

        public Madlib()
        {

        }

        public Madlib(string name, string location, string verb, string adverb, string adjective)
        {
            this.Name = name;
            this.Location = location;
            this.Verb = verb;
            this.Adverb = adverb;
            this.Adjective = adjective;
        }
    }
}