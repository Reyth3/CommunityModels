using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class Profile
    {
        public Profile() { }
        public Profile(User user)
        {
            this.User = user;
            Friends = new List<Profile>();
            Subscriptions = new List<Community>();
            Owned = new List<Community>();
            Posts = new List<Post>();
            Comments = new List<Comment>();
            Interests = new List<Category>();
        }

        [Key, ForeignKey("User")]
        public int Id { get; set; }
        public int Reputation { get; set; }

        public virtual User User { get; set; }
        public virtual List<Profile> Friends { get; set; }
        public virtual List<Community> Subscriptions { get; set; }
        public virtual List<Community> Owned { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Category> Interests { get; set; }

        #region Private Methods
        private string GenerateNickname()
        {
            var r = new Random();
            var length = r.Next(4, 9);
            var c = "bcdfghjklmnpqrstvwxz".ToCharArray();
            var v = "aeiouy";
            var name = "";
            for (int i = 0; i < length; i++)
                if (i == 0)
                    name += c[r.Next(0, c.Length)].ToString().ToUpper();
                else if (i < length - 1)
                    if (i % 2 == 1)
                        name += v[r.Next(0, v.Length)];
                    else name += c[r.Next(0, c.Length)];
                else name += c[r.Next(0, c.Length)];
            var special = "0123456789_@#$%X";
            var spLength = r.Next(0, 4);
            for (int i = 0; i < spLength; i++)
                name += special[r.Next(0, special.Length)];
            return name;
        }
        #endregion
    }
}