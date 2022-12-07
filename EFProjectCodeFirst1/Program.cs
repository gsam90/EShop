﻿using DatabaseFirst_Initial.Models;
using EFProjectCodeFirst1.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EFProjectCodeFirst1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext appDBContext = new AppDBContext();
            //appDBContext.ProductCategories.Add(new ProductCategory { Title = "Pen", Description = "A Pen" });
            //appDBContext.ProductCategories.Add(new ProductCategory { Title = "Pencil", Description = "A Pencil" });
            //appDBContext.ProductCategories.Add(new ProductCategory { Title = "Color Pen", Description = "A Colored Pen" });
            //appDBContext.ProductCategories.Add(new ProductCategory { Title = "Rubbed Eraser", Description = "A Rubbed Eraser" });
            //appDBContext.SaveChanges();

            //var productCategory = appDBContext.ProductCategories.Find(3);
            //Console.WriteLine(productCategory);
            //appDBContext.Products.Add(
            //    new Product("Blue Parker", "Blue Parker Description", 19.22, productCategory));
            //appDBContext.SaveChanges();

            //appDBContext.Products.Add(
            //    new Product
            //    {
            //        Title = "Awesome Pencil",
            //        Description = "Awesome Pencil description",
            //        Price = 20,
            //        Category = new ProductCategory { Title = "Awesome Pencils", Description = "Awesome Pencils" }
            //    });
            //appDBContext.SaveChanges();

            //appDBContext.Products.Add(
            //    new Product
            //    {
            //        Title = "Awesome Pencil 2",
            //        Description = "Awesome Pencil description",
            //        Price = 20,
            //        Category = 
            //            appDBContext.ProductCategories.Where(productCategory => 
            //            productCategory.Title == "Awesome Pencils" && productCategory.Description == "").SingleOrDefault()
            //    });

            //appDBContext.SaveChanges();

            // Query Syntax
            //var pCA = (from productCategory in appDBContext.ProductCategories
            //           where productCategory.Title == "Awesome Pencils"
            //           select productCategory).ElementAtOrDefault(0);

            //// Method Syntax
            //var pCB = appDBContext.ProductCategories.Where(productCategory =>
            //            productCategory.Title == "Awesome Pencils").SingleOrDefault();

            //Console.WriteLine(pCA == pCB);


            appDBContext.SomeTables.Add(new Models.SomeTable());
            appDBContext.SaveChanges();
            var myDateTime = new DateTime();
            Console.WriteLine(myDateTime);

            Console.ReadKey();
        }
    }
}
