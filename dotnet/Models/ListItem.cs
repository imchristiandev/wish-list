﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WishList.Models
{
    public class ListItem
    {
        public int? Id { get; set; }
        public string ProductId { get; set; }
        public string Sku { get; set; }
        public string Title { get; set; }
    }
}
