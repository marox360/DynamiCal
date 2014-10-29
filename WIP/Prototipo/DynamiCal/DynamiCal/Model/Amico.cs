using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DynamiCal.Model
{
    public class Amico
    {
        private readonly string _email;

        public Amico(string email)
        {
            #region Precondizioni
            Debug.Assert(email != null, "Email is null");
            Debug.Assert(Regex.IsMatch(email, "^.+@.+\\..{2,}$"), "Email is invalid");
            #endregion

            _email = email.Trim();
        }
        
        public string Email
        {
            get
            {
                return _email;
            }
        }

        public override string ToString()
        {
            return this.Email;
        }
    }
}
