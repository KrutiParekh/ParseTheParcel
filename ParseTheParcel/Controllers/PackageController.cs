using System;
using System.Configuration;
using System.Web.Mvc;
using ParseTheParcel.Entities;
using ParseTheParcel.Models;

namespace ParseTheParcel.Controllers
{
    public class PackageController : Controller
    {
        private readonly PackageCost _packageCost = new PackageCost();
        //GET: Package Details
        public ActionResult Index()
        {
            Package model = new Package();
            return View(model);
        }

        [HttpPost]
        public ActionResult Result(Package model)
        {
            if (IsItOverWeight(model))
            {
                return View("OverWeightPackage");
            }

            PackageType packageType = PackageSize.GetPackageType(model);

            model.PackageType = packageType;

            var packageDeliveryCost = _packageCost.GetPackageDeliveryCost(packageType);

            decimal cost = packageDeliveryCost;

            model.Cost = cost;

            return View(model);

        }

        private bool IsItOverWeight(Package model)
        {
            int maxWeightAllowed = Convert.ToInt32(ConfigurationManager.AppSettings["MaxWeight"]);

            if (model.Weight > maxWeightAllowed)
            {
                return true;
            }
            return false;
        }
    }
}