﻿using System.ComponentModel.DataAnnotations;

namespace CookingService.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
