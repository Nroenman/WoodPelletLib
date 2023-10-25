using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace WoodPelletLib
{
    public class WoodPelletRepository
    {



        private List<WoodPellet> woodPellets = new List<WoodPellet>()
        {
            new WoodPellet(1, 4100, 4, "BioWood") ,
            new WoodPellet(2, 4000, 4, "BioWood") ,
            new WoodPellet(3, 3000, 1, "BilligPille"),
            new WoodPellet(4, 8000, 5, "GoldenWoodPellet"),
            new WoodPellet(5, 7500, 5, "GoldenWoodPellet")


        };

        public List<WoodPellet> GetAllWoodPellet()
        {
            return new List<WoodPellet>(woodPellets);

        }

        public WoodPellet GetById(int id)
        {
            foreach (WoodPellet woodPellet in woodPellets)
            {
                if ( woodPellet.Id == id )
                   return woodPellet;

            }
            return null;
         }
        public WoodPellet Add(WoodPellet woodPellet)
        {
            int newId = woodPellets.Count > 0 ? woodPellets.Max(b => b.Id) + 1 : 1;
            woodPellet.Id = newId;
            woodPellets.Add(woodPellet);
            return woodPellet;
        }
        public WoodPellet Update(int id, WoodPellet updateWoodPallet)
        {
            WoodPellet? existingWoodPallet = woodPellets.Find(x => x.Id == id);
            if (existingWoodPallet != null)
            {
               existingWoodPallet.Brand = updateWoodPallet.Brand;
                existingWoodPallet.Price = updateWoodPallet.Price;
                return existingWoodPallet;
            }
            return null;
        }


    }



















}