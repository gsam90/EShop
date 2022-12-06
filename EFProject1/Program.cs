﻿using DatabaseFirst_Initial.Models;
using EFProject1.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDBContext appDBContext = new AppDBContext(); // SqlConnection.Open()
            
            // CREATE
            // creates a new record
            ProductCategory productCategory2 = appDBContext.ProductCategories.Add(new ProductCategory("Work Telephone XKB22-AN Pro",
                "Pro Series of the most expensive telephone in house"));
            // object of a model productCategory becomes an entity == has a record in a db table

            // saves any pending changes
            appDBContext.SaveChanges();
            Console.WriteLine($"productCategory2 after add: {productCategory2}");

            // UPDATE
            // changes the actual (for the GOD shake!!!!) OBJECT in C#
            // and then this is saved to DB!!!!!!
            productCategory2.Description += " MAX TURBO EXTRA SUPER NICE!!";
            appDBContext.SaveChanges();

            // DELETE (REMOVE)
            // deletes an entity - must already exists
            var pd3 = appDBContext.ProductCategories.Remove(productCategory2);
            // can I undo the marking of deletion???
            

            // what happens when I try to remove a non entity
            //try
            //{
            //    ProductCategory productCategory = new ProductCategory("Work Telephone XKB22-AN Pro",
            //            "Pro Series of the most expensive telephone in house"); // an object typeof(ProductCategory)
            //    appDBContext.ProductCategories.Remove(productCategory);
            //    appDBContext.SaveChanges();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            // READ
        }
    }
}