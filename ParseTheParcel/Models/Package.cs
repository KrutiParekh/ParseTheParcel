using ParseTheParcel.Entities;

namespace ParseTheParcel.Models
{
    public class Package
    {
        public int Length { get; set; }

        public int Breath { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public decimal Cost { get; set; }

        public PackageType PackageType { get; set; }
    }
}