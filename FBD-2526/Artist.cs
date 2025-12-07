using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace FBD_2526
{

    [Serializable()]
    public class Artist
    {
        private String _artistID;
        private String _artistName;
        private String _description;
        private String _artistVerified;
        private String _artistIdGenre;
        private String _artistNameGenre;

        public String artistID
        {
            get { return _artistID; }
            set { _artistID = value; }
        }


        public String Name
        {
            get { return _artistName; }
            set
            {
                _artistName = value;
            }
        }

        public String Description
        {
            get { return _description; }
            set
            {
                _description = value;
            }
        }

        public String Verified
        {
            get {
                return _artistVerified.Equals( "True") ? "Sim" : "Não";
            }
            set {
                _artistVerified = value;
            }
        }

        public String IdGenre
        {
            get { return _artistIdGenre; }
            set { _artistIdGenre = value; }
        }

        public String NameGenre
        {
            get { return _artistNameGenre; }
            set { _artistNameGenre = value; }
        }

        public override string ToString()
        {
            return $"{artistID.PadRight(4)} | " +
           $"{Name.PadRight(20)} | " +
           $"{Verified.PadRight(4)} | " +
           $"{IdGenre.PadRight(4)}";
        }
    }
}

