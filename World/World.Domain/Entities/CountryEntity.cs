using System.Collections.Generic;

namespace World.Domain.Entities
{
    public class CountryEntity : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Region { get; set; }
        public double SurfaceArea { get; set; }
        public int IndepYear { get; set; }
        public int Population { get; set; }
        public double LifeExpectancy { get; set; }
        public double Gnp { get; set; }
        public double GnpOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int Capital { get; set; }
        public int Code2 { get; set; }

        public virtual IEnumerable<CityEntity> Cities { get; set; }
        public virtual IEnumerable<CountryLanguageEntity> CountryLanguages { get; set; }
    }
}
