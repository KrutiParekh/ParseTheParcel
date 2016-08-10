using System;
using System.Configuration;

namespace ParseTheParcel.Models
{
    public class PackageDimensions
    {
        public static Package GetPackageDimensions(string type)
        {
            var package = new Package();
            string[] minPackageDimensions;

            if (type.ToUpper() == "SMALL")
            {
                minPackageDimensions = ConfigurationManager.AppSettings["SmallPackageDimensions"].Split(',');
            }
            else if (type.ToUpper() == "MEDIUM")
            {
                minPackageDimensions = ConfigurationManager.AppSettings["MediumPackageDimensions"].Split(',');
            }
            else
            {
                minPackageDimensions = ConfigurationManager.AppSettings["LargePackageDimensions"].Split(',');
            }

            //Min package dimensions
            for (int i = 0; i < minPackageDimensions.Length; i++)
            {
                if (i == 0)
                {
                    package.Length = Convert.ToInt32(minPackageDimensions[0]);
                    package.Breath = Convert.ToInt32(minPackageDimensions[1]);
                    package.Height = Convert.ToInt32(minPackageDimensions[2]);
                }
            }
            return package;
        }
    }
}