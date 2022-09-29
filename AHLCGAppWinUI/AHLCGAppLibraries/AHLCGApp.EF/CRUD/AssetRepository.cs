using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AHLCGApp.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AHLCGApp.EF.CRUD
{
    public class AssetRepository : IAssetService
    {
        public void GetAllAssets()
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                List<Asset> allInvestigators = context.Assets.ToList();
            }
        }

        public void AddOrUpdateAsset(Asset asset)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                if (AssetExists(asset.Id))
                {
                    Asset currentAsset = context.Assets.Where(a => a.Id == asset.Id).SingleOrDefault();
                    context.Update(currentAsset);
                }
                else
                {
                    Asset newAsset = asset;
                    context.Add(newAsset);
                }

                context.SaveChanges();
            }
        }

        public void DeleteAsset(Asset asset)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Asset delAsset = context.Assets.Where(a => a.Id == asset.Id).SingleOrDefault();
                int id = asset.Id;
                DeleteAsset(id);
            }
        }

        public void DeleteAsset(int id)
        {
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                Asset delAsset = context.Assets.Where(a => a.Id == id).SingleOrDefault();
                context.Remove(delAsset);
                context.SaveChanges();
            }
        }

        public bool AssetExists(int id)
        {
            bool exists = false;
            using (AHLCGDBContext context = new AHLCGDBContext(new DbContextOptions<AHLCGDBContext>()))
            {
                exists = context.Assets.Any(a => a.Id == id);
            }
            return exists;
        }
    }
}
