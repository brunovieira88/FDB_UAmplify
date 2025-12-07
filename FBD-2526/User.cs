using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace FBD_2526
{

    [Serializable()]
    public class User
    {
        private String _userID;
        private String _userName;
        private String _userUserName;
        private String _userEmail;

        public String userID
        {
            get { return _userID; }
            set { _userID = value; }
        }


        public String Name
        {
            get { return _userName; }
            set
            {
                _userName = value;
            }
        }

        public String userName
        {
            get { return _userUserName; }
            set { _userUserName = value; }
        }

        public String userEmail
        {

            get { return _userEmail; }
            set { _userEmail = value; }
        }

        public override string ToString()
        {
            return $"{userID} | " +
           $"{Name} | " +
           $"{userName}" + $"{userEmail}";
        }
    }
}

