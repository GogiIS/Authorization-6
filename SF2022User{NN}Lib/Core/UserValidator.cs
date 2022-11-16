using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_NN_Lib.Core
{
    public class UserValidator
    {
        public static bool Validate(string login, string password) =>
            login == "admin" && password == "admin";
    }
}
