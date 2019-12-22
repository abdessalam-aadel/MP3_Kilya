using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3_Kilya
{
    public class FactoryMp3
    {
        string filenameaddress;
        string song;
        string artist;
        string album;
        string year;

        int pos_song;
        int pos_artist;
        int pos_album;
        int pos_year;

        byte[] fileinbyte;

        System.IO.FileStream fs;

        public FactoryMp3(string filename)
        {
            filenameaddress = "";
            song = "";
            artist = "";
            album = "";
            year = "";

            pos_song = 0;
            pos_artist = 0;
            pos_album = 0;
            pos_year = 0;

            fileinbyte = System.IO.File.ReadAllBytes(filename);

            fs = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);

        }

        public string GetArtist()
        {
            for (int i = 0; i < fileinbyte.Count(); i++)
            {
                char tmpchar = Convert.ToChar(fileinbyte[i]);
                if (tmpchar == 'T')
                {
                    int j = i + 1;
                    char tmpchar_ = Convert.ToChar(fileinbyte[j]);
                    if (tmpchar_ == 'P')
                    {
                       int k = j + 1;
                        char _tmpchar = Convert.ToChar(fileinbyte[k]);
                        if (_tmpchar == 'E')
                        {
                            int l = k + 1;
                                char _tmpchar_ = Convert.ToChar(fileinbyte[l]);
                                if (_tmpchar_ == '1')
                                 {
                                    pos_artist = l + 8;
                                 } 
                         } 
                    
                     }
                 }
            }
            int nextbyte;
            fs.Seek(pos_artist, System.IO.SeekOrigin.Begin);
            while ((nextbyte = fs.ReadByte()) > 0)
            { 
                artist += Convert.ToChar(nextbyte);
            }
            return artist;
        }

        public string GetSong()
        {
            for (int i = 0; i < fileinbyte.Count(); i++)
            {
                char tmpchar = Convert.ToChar(fileinbyte[i]);
                if (tmpchar == 'T')
                {
                    int j = i + 1;
                    char tmpchar_ = Convert.ToChar(fileinbyte[j]);
                    if (tmpchar_ == 'I')
                    {
                        int k = j + 1;
                        char _tmpchar = Convert.ToChar(fileinbyte[k]);
                        if (_tmpchar == 'T')
                        {
                            int l = k + 1;
                            char _tmpchar_ = Convert.ToChar(fileinbyte[l]);
                            if (_tmpchar_ == '2')
                            {
                                pos_song = l + 8;
                            }
                        }

                    }
                }
            }
            int nextbyte;
            fs.Seek(pos_song, System.IO.SeekOrigin.Begin);
            while ((nextbyte = fs.ReadByte()) > 0)
            {
               song += Convert.ToChar(nextbyte);
            }
            return song;
        }

        public string GetAlbum()
        {
            for (int i = 0; i < fileinbyte.Count(); i++)
            {
                char tmpchar = Convert.ToChar(fileinbyte[i]);
                if (tmpchar == 'T')
                {
                    int j = i + 1;
                    char tmpchar_ = Convert.ToChar(fileinbyte[j]);
                    if (tmpchar_ == 'A')
                    {
                        int k = j + 1;
                        char _tmpchar = Convert.ToChar(fileinbyte[k]);
                        if (_tmpchar == 'L')
                        {
                            int l = k + 1;
                            char _tmpchar_ = Convert.ToChar(fileinbyte[l]);
                            if (_tmpchar_ == 'B')
                            {
                                pos_album = l + 8;
                            }
                        }

                    }
                }
            }
            int nextbyte;
            fs.Seek(pos_album, System.IO.SeekOrigin.Begin);
            while ((nextbyte = fs.ReadByte()) > 0)
            {
                album += Convert.ToChar(nextbyte);
            }
            return album;
        }

        public string GetYear()
        {
            for (int i = 0; i < fileinbyte.Count(); i++)
            {
                char tmpchar = Convert.ToChar(fileinbyte[i]);
                if (tmpchar == 'T')
                {
                    int j = i + 1;
                    char tmpchar_ = Convert.ToChar(fileinbyte[j]);
                    if (tmpchar_ == 'Y')
                    {
                        int k = j + 1;
                        char _tmpchar = Convert.ToChar(fileinbyte[k]);
                        if (_tmpchar == 'E')
                        {
                            int l = k + 1;
                            char _tmpchar_ = Convert.ToChar(fileinbyte[l]);
                            if (_tmpchar_ == 'R')
                            {
                                pos_year = l + 8;
                            }
                        }

                    }
                }
            }
            int nextbyte;
            fs.Seek(pos_year, System.IO.SeekOrigin.Begin);
            while ((nextbyte = fs.ReadByte()) > 0)
            {
                year += Convert.ToChar(nextbyte);
            }
            return year;
        }
    }
}
