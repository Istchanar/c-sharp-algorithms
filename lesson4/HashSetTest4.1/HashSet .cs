using System;
using System.Collections.Generic;
using System.Text;

namespace HashSetTest4._1
{
    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as User;

            if (user == null)
                return false;

            return FirstName == user.FirstName && SecondName == user.SecondName;
        }

        public override int GetHashCode()
        {
            int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;

            int secondNameHashCode = SecondName?.GetHashCode() ?? 0;

            return firtsNameHashCode ^ secondNameHashCode;
        }
    }

}
