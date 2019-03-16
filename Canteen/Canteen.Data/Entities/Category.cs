﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Canteen.Data.Entities
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public Guid CookShopId { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
