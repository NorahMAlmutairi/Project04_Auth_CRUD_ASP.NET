﻿using GreenLifeStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreenLifeStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<BranchModel> Branches { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderProductModel> OrderProduct { get; set; }
        public DbSet<BranchProductModel> BranchProduct { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderProductModel>().HasKey(op => new { op.OrderId, op.ProductId });
            modelBuilder.Entity<BranchProductModel>().HasKey(bp => new { bp.BranchId, bp.ProductId });

            


            //insert branches
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { BranchId = 1, Name = "Green Life Store", City = "Riyadh" , Address = "Takhassusi Street, Al Nakheel District" , Telephone= "011 629 4056", Mobile= "0507076701", Email= "info@GreenLife.com" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { BranchId = 2, Name = "Green Life Store", City = "Dammam", Address = "Omar ibn Al Khattab Street, Al Faisaliyah District", Telephone = "013 634 4742", Mobile = "0557889843", Email = "info@GreenLife.com" });
            modelBuilder.Entity<BranchModel>().HasData(new BranchModel
            { BranchId = 3, Name = "Green Life Store", City = "Jeddah", Address = "Abdullah Al Khayl Street, Al Khalidiyyah District", Telephone = "012 645 4344", Mobile = "0567584822", Email = "info@GreenLife.com" });

            
           
            //insert Products
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 1, Name = "Naturya Organic Wheatgrass Powder", ProductDetails = "High in protein which contributes to the growth and maintenance of muscle mass Rich in iron which contributes to the normal transport of oxygen around the body and the reduction of tiredness and fatigue Natural source of vitamin A which contributes to the maintenance of normal skin and vision", Price = 97.00f, Image = "https://www.l-organic.com/wp-content/uploads/2018/05/naturya-wheatgrass-1-600x600.jpg"});
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 2, Name = "Clearspring Matcha Pouch", ProductDetails = "Matcha is a finely milled vibrant green tea powder made from the highest quality Japanese tea leaves. Clearspring Organic Premium Matcha comes from Uji, a region high in the hills around Kyoto, renowned for producing the best Japanese teas. Only accessibly by foot, this remote area is unpolluted and rich in friendly bugs such as spiders, ladybirds, praying mantis and dragonflies to keep the pests under control (best to use organic matcha as non-organic matcha is grown using excessive amounts of agricultural fertilisers and pesticides).", Price = 90.50f, Image = "https://www.l-organic.com/wp-content/uploads/2021/03/51BStX6N-L._AC_SS450_.jpg" });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 3, Name = "Hampstead Organic Peppermint Tea", ProductDetails = "Hampsteads organic peppermint infusion is a full flavoured, and heady. It is a unique blend of the two best loved mints, peppermint and spearmint. This gives added depth, and a fresh, tangy finish with a lingering sweet after taste. Deliciously refreshing hot or iced as a cooling summer cocktail, it is the perfect pick-me-up during the day or after a meal to cleanse the palate and aid digestion.", Price = 17.00f, Image = "https://www.l-organic.com/wp-content/uploads/2018/09/hampstead-peppermint.jpg"  });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 4, Name = "Bear Alphabites Cocoa Cereal", ProductDetails = "Alphabites are a delicious healthy breakfast with no refined sugar or salt. Grrr. We use coconut blossom nectar, which low GI** and naturally high in calcium.", Price = 32.00f, Image = "https://www.l-organic.com/wp-content/uploads/2018/04/alphabites-600x600.jpg"});
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 5, Name = "Nature’s Path Crispy Rice Cereal", ProductDetails = "Nature’s Path Organic Gluten Free Crispy Rice Cereal is a delicious, crunchy cereal that has been wonderfully made with organic brown rice.", Price = 30.00f, Image = "https://www.l-organic.com/wp-content/uploads/2018/10/natures-path-crispy-rice.jpg" });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 6, Name = "Doves Farm Organic Corn Flakes", ProductDetails = "Doves Farm Organic Corn Flakes are gluten free and low in fat. Start your day with a bowl of our delicious golden flakes which are grown under the Italian sun. We’ve added malted rice syrup to create our delicious breakfast suitable for all the family.", Price = 29.00f, Image = "https://www.l-organic.com/wp-content/uploads/2018/03/Doves-Farm-Organic-Corn-Flakes-325g-1-600x600.jpg"});
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 7, Name = "Amisa Fruity Oat Muesli Cranberry & Strawberry", ProductDetails = "Amisa Organic Gluten Free Fruity Oat Muesli is a delicious gluten free muesli, with tangy cranberries, juicy strawberries, and sunflower seeds.", Price = 29.00f, Image = "https://www.l-organic.com/wp-content/uploads/2019/01/amisa-fruity-oat-600x600.png"  });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 8, Name = "Biona Maple Syrup Waffles", ProductDetails = "Organic wholegrain waffles with rich maple syrup filling. Perfect for dunking, crunching or munching on the go!", Price = 21.00f, Image = "https://www.l-organic.com/wp-content/uploads/2018/02/88.jpg"  });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 9, Name = "Biona Organic Pressed Apple Juice", ProductDetails = "Unfiltered pure organic apple juice, with the bits. Biona organic cloudy Apple Juice is simply pressed, so more of its goodness reaches your glass.", Price = 27.00f, Image = "https://www.l-organic.com/wp-content/uploads/2019/01/biona-apple-juice-1l.jpg"  });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel
            { ProductId = 10, Name = "Biona Organic Peach Halves", ProductDetails = "Naturally sweet and delicious, Peach Halves in Rice Syrup contains no added beet or cane sugar. Picked at the peak of ripeness and minimally processed,", Price = 40.00f, Image = "https://www.l-organic.com/wp-content/uploads/2020/05/Biona-Organic-Peach-Halves-in-Rice-Syrup-550g--600x600.jpg"});
            

            
            //insert Orders
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel
            { OrderId = 1, OrderDate = DateTime.Now, TotalPrice = 236.5f, UserId = "12e2ec6e-45f1-4ac4-bcec-6aca5cd56456" });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel
            { OrderId = 2, OrderDate = DateTime.Now, TotalPrice = 216.5f, UserId = "9846fc6d-733e-4f26-90f6-0599199363be" });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel
            { OrderId = 3, OrderDate = DateTime.Now, TotalPrice = 67.00f, UserId = "bb091c98-1b17-4907-bcae-5eb8141f6195" });

           
            //insert BranchProduct
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 1, ProductId =1});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 1, ProductId = 2});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 1, ProductId = 3});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 1, ProductId = 4});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 2, ProductId = 5});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 2, ProductId = 6});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 2, ProductId = 7});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 2, ProductId = 8});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 2, ProductId = 1 });
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 3, ProductId = 9});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 3, ProductId = 10});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 3, ProductId = 1});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 3, ProductId = 2});
            modelBuilder.Entity<BranchProductModel>().HasData(new BranchProductModel
            { BranchId = 3, ProductId = 3 });

            

            //insert OrderProduct
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 1, ProductId = 1});
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 1, ProductId = 2 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 1, ProductId = 3 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 1, ProductId = 4 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 2, ProductId = 1 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 2, ProductId = 2});
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 2, ProductId = 7 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 3, ProductId = 6 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 3, ProductId = 8 });
            modelBuilder.Entity<OrderProductModel>().HasData(new OrderProductModel
            { OrderId = 3, ProductId = 3 });
           
            
        }
    }
}

    

 