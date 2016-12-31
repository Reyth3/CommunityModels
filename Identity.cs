using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class Identity
    {
        public Identity() { }

        public Identity(User user, Post post)
        {
            Nickname = GenerateNickname();
            User = user;
            Post = post;
        }

        public int Id { get; set; }
        public string Nickname { get; set; }

        public virtual User User { get; set; }
        public virtual Post Post { get; set; }

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