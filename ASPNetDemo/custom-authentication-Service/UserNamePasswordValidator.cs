using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace custom_authentication_Service
{
    abstract class UserNamePasswordValidator
    {
        public abstract void Validate(string userName, string password);
    }
}
