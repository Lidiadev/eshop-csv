﻿using System.Collections.Generic;

namespace EShop.Domain.Models
{
    public class Description : Attribute
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
