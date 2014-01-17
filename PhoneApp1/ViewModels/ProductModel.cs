using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp1.ViewModels
{
    public class ProductModel
    {
        public ProductGroup OtherProducts { get; set; }
        public ProductGroup Meat { get; set; }
        public ProductGroup Baby_Food { get; set; }
        public ProductGroup Seafood { get; set; }
        public ProductGroup Drinks { get; set; }

        public bool IsDataLoaded { get; set; }

        public void LoadData()
        {
            Meat = CreateMeatGroup();
            Drinks = CreateDrinksGroup();
            Baby_Food = CreateBabyFoodGroup();
            Seafood = CreateSeafoodGroup();

            IsDataLoaded = true;
        }

        private ProductGroup CreateMeatGroup()
        {
            ProductGroup data = new ProductGroup();
            data.Title = "Meat";
            string basePath = "assets/ProductImages/";

            data.Items.Add(new ProductData
            {
                Title = "Xoz",
                FilePath = basePath + "finlandia.png"
            });

            return data;
        }

        private ProductGroup CreateBabyFoodGroup()
        {
            ProductGroup data = new ProductGroup();
            data.Title = "Baby food";
            string basePath = "assets/ProductImages/baby_food/";

            data.Items.Add(new ProductData
            {
                Title = "Kasha",
                FilePath = basePath + "kasha.jpg"
            });

            return data;
        }

        private ProductGroup CreateDrinksGroup()
        {
            ProductGroup data = new ProductGroup();
            data.Title = "Drinks";
            string basePath = "assets/ProductImages/";

            for (int i = 0; i < 10; i++)
            {
                if(i%2==0)
                data.Items.Add(new ProductData
                {
                    Title = "Finlandia",
                    FilePath = basePath + "finlandia.png"
                });

                data.Items.Add(new ProductData
                {
                    Title = "Sandora",
                    FilePath = basePath + "sandora.png"
                });

                data.Items.Add(new ProductData
                {
                    Title = "Jermuk",
                    FilePath = basePath + "jermuk.png"
                });
            }

            return data;
        }

        private ProductGroup CreateSeafoodGroup()
        {
            ProductGroup data = new ProductGroup();
            data.Title = "Seafood";
            string basePath = "assets/ProductImages/seafood/";

            data.Items.Add(new ProductData
            {
                Title = "Siga",
                FilePath = basePath + "siga.jpg"
            });

            return data;
        }
    }
}
