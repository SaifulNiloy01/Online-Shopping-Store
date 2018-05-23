using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using shoppingstore.Models;

namespace shoppingstore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ShoppingStoreEntities>
    {
        protected override void Seed(ShoppingStoreEntities context)
        {


            var categories = new List<Category>
            {
                new Category { Name = "Elctronics" },
                new Category { Name = "Accessories" },
                new Category { Name = "Home Appliances" },
                new Category { Name = "Hardware" },
                new Category { Name = "Clothes" },
                new Category { Name = "Children Toys" },
                new Category { Name = "Fitness Equipments" },
                new Category { Name = "Furniture" },
                new Category { Name = "Others" }
            };

            var producers = new List<Producer>
            {
                new Producer { Name = "Beats" },
                new Producer { Name = "Ray Ban" },
                new Producer { Name = "Ikea" },
                new Producer { Name = "Cannon" },
                new Producer { Name = "Philips" },
                new Producer { Name = "Precor" },
                new Producer { Name = "Local Dist" },
                
                new Producer { Name = "Zara" },
                new Producer { Name = "Apple" },
                new Producer { Name = "Brawn" },
                new Producer { Name = "Zeca Pagodinho" }
            };

            new List<Item>
            {
                new Item { Title = "Speaker", Category = categories.Single(g => g.Name == "Electronics"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Beats"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Sun Glasse", Category = categories.Single(g => g.Name == "Personal Accessories"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Ray Ban"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Table", Category = categories.Single(g => g.Name == "Furniture"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Ikea"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Billow", Category = categories.Single(g => g.Name == "Furniture"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Ikea"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Camera", Category = categories.Single(g => g.Name == "Electronics"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Cannon"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Lights", Category = categories.Single(g => g.Name == "Furniture"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Philips"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Necklace", Category = categories.Single(g => g.Name == "Personal Accessories"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Local Dist"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Suits", Category = categories.Single(g => g.Name == "Clothes"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Zara"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "10kg Dumbles", Category = categories.Single(g => g.Name == "Fitness Equipments"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Precor"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Iphone7 Cover", Category = categories.Single(g => g.Name == "Electronic Accessories"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Apple"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Toaster", Category = categories.Single(g => g.Name == "Home Appliances"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Brawn"), ItemArtUrl = "/Content/Images/itemart.png" },
                new Item { Title = "Hummer", Category = categories.Single(g => g.Name == "Hardware"), Price = 8.99M, Producer = producers.Single(a => a.Name == "Local distr"), ItemArtUrl = "/Content/Images/itemart.png" },

            }.ForEach(a => context.Items.Add(a));
        }
    }
}