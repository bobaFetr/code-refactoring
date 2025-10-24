namespace Animal.Models
{
    public class Animal //: AnimalDetails.Models.AnimalDetails
    {
        public int Id;
        public string Names = string.Empty;
        public string Owner = string.Empty;
        public int Age;
        public string Type = string.Empty;
        public bool sickOrNot = false;
        public string Notes = "";

        public void MakeOlder()
        {
            Age += 3;
        }

        public void Heal()
        {
            sickOrNot = false;
            Notes = "feeling ok i guess";
        }
    }
}