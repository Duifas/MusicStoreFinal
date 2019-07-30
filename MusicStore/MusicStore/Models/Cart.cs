using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Cart
    {
        public virtual int RecordId { get; set; }
        public virtual string CartId { get; set; }
        public virtual int AlbumId { get; set; }
        public virtual int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Album Album { get; set; }
    }
}