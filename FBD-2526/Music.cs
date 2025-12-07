using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace FBD_2526
{

    [Serializable()]
    public class Music
    {
        private String _musicID;
        private String _musicName;
        private String _musicDuration;
        private String _musicReleaseDate;
        private String _musicIdAlbum;
        private String _musicAlbum;
        private String _musicIdGenre;
        private String _musicGenre;
        private String _musicLanguage;
        private String _musicLyrics;

        private String _fax;
        public String musicID
        {
            get { return _musicID; }
            set { _musicID = value; }
        }


        public String Name
        {
            get { return _musicName; }
            set
            {
                _musicName = value;
            }
        }

        public String Duration
        {
            get { return _musicDuration; }
            set { _musicDuration = value; }
        }

        public String ReleaseDate
        {
            get { return _musicReleaseDate; }
            set { _musicReleaseDate = value; }
        }
        public String Album
        {
            get { return _musicAlbum; }
            set { _musicAlbum = value; }
        }

        public String IdAlbum
        {
            get { return _musicIdAlbum; }
            set { _musicIdAlbum = value; }
        }
        public String Genre
        {
            get { return _musicGenre; }
            set { _musicGenre = value; }
        }

        public String IdGenre
        {
            get { return _musicIdGenre; }
            set { _musicIdGenre = value; }
        }

        public String Language
        {
            get { return _musicLanguage; }
            set { _musicLanguage = value; }
        }

        public String Lyrics
        {
            get { return _musicLyrics; }
            set { _musicLyrics = value; }
        }
        public override string ToString()
        {
            return $"{musicID.PadRight(4)} | " +
           $"{Name.PadRight(20)} | " +
           $"{IdAlbum.PadRight(4)} | " +
           $"{IdGenre.PadRight(4)} | " +
           $"{Language}";
        }
    }
}

