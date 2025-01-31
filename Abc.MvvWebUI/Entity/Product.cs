﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abc.MvvWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Ürün Fiyatı")]
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}