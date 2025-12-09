using Accessibility;
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
        private String _duration;
        private String _releaseDate;
        private String _artistId;
        private String _artist;


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

        public String Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public String ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }

        public String AlbumIdArtist
        {
            get { return _artistId; }
            set { _artistId = value; }
        }

        public String AlbumNameArtist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        public override string ToString()
        {
            return $"{albumID.PadRight(4)} | " +
           $"{Name.PadRight(30)} | " +
           $"{AlbumIdArtist.PadRight(4)}";
        }
    }
}

