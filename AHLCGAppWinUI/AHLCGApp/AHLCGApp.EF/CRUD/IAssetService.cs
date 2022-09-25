using AHLCGApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHLCGApp.EF.CRUD
{
    public interface IAssetService
    {
        public void GetAllAssets();
        public void AddOrUpdateAsset(Asset asset);
        public void DeleteAsset(Asset asset);
        public void DeleteAsset(int id);
        public void AssetExists(int id);

    }
}
