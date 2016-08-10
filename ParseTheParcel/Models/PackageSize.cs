using ParseTheParcel.Entities;

namespace ParseTheParcel.Models
{
    public class PackageSize
    {
        public static PackageType GetPackageType(Package package)
        {
            Package smallPackage = PackageDimensions.GetPackageDimensions("Small");
            Package mediumPackage = PackageDimensions.GetPackageDimensions("Medium");
            Package largePackage = PackageDimensions.GetPackageDimensions("Large");

            if (package.Length <= smallPackage.Length && package.Breath <= smallPackage.Breath
                    && package.Height <= smallPackage.Height)
            {
                return PackageType.Small;
            }
            else if (package.Length <= mediumPackage.Length && package.Breath <= mediumPackage.Breath 
                && package.Height <= mediumPackage.Height)
            {
                return PackageType.Medium;
            }
            else if (package.Length <= largePackage.Length && package.Breath <= largePackage.Breath 
                && package.Height <= largePackage.Height)
            {
                return PackageType.Large;
            }
            else
            {
                return PackageType.None;
            }
            }
    }
}