using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Community> Communities { get; set; }
    }
}