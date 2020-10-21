namespace World.Domain.Entities
{
    public class CountryLanguageEntity : BaseEntity
    {
        public int CountryID { get; set; }
        public string Language { get; set; }
        public bool IsOfficial { get; set; }
        public double Percentage { get; set; }

        public CountryEntity Country { get; set; }
    }
}
