﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }

        public virtual int OrderId { get; set; }

        public virtual int AlbumId { get; set; }

        public virtual int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public virtual Album Album { get; set; }

        public virtual Order Order { get; set; }
    }
}