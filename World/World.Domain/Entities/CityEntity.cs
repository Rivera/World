namespace World.Domain.Entities
{
    public class CityEntity : BaseEntity
    {
        public string Name { get; set; }
        public int CountryID { get; set; }
        public string District { get; set; }
        public int Population { get; set; }

        public CountryEntity Country { get; set; }
    }
}
