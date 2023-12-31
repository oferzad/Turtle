using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleExc
{
    class Song
    {
        private string songTitle;
        private int genre;
        private int length;
        private int collection;

        public Song(string songTitle, int genre, int length)
        {
            this.collection = 0;
            this.songTitle = songTitle;
            this.genre = genre;
            this.length = length;
        }

        public string GetTitle()
        {
            return this.songTitle;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetGenre()
        {
            return this.genre;
        }

        public void SetCollection(int num)
        {
            this.collection = num;
        }

        public override string ToString()
        {
            string str = $"Title: {songTitle} \nGenre: {genre}\nLength: {length}\nCollection: {collection}";
            return str;
        }
    }

    class Malben
    {
        private int length;
        private int width;

        public Malben(int length, int width)
        {
            this.width = width;
            this.length = length;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public int GetLength()
        {
            return this.length;
        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public int Area()
        {
            return width * length;
        }

        public int Perimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            string str = $"Malben({length},{width})";
            return str;
        }
    }
    class MoreClasses
    {
    }
}
