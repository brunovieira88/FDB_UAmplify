using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace FBD_2526
{

    [Serializable()]
    public class Album
    {
        private String _albumID;
        private String _albumName;
        private String _artistId;

        public String albumID
        {
            get { return _albumID; }
            set { _albumID = value; }
        }


        public String Name
        {
            get { return _albumName; }
            set
            {
                _albumName = value;
            }
        }

        public String AlbumIdArtist
        {
            get { return _artistId; }
            set { _artistId = value; }
        }

        public override string ToString()
        {
            return $"{albumID.PadRight(4)} | " +
           $"{Name.PadRight(30)} | " +
           $"{AlbumIdArtist.PadRight(4)}";
        }
    }
}

