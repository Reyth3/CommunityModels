using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class Category
    {
        public Category() { }
        public Category(string name)
        {
            Name = name;
            Communities = new List<Community>();
            Users = new List<Profile>();
        }

        public int Id { get; set; }
        [MaxLength(64)]
        public string Name { get; set; }

        public virtual List<Community> Communities { get; set; }
        public virtual List<Profile> Users { get; set; }
    }
}