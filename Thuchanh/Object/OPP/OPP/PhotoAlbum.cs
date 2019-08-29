using System;
using System.Collections.Generic;
using System.Text;

namespace OPP
{
    class Bai2
    {
        public class PhotoAlbum
        {
            protected int numberOfPages;
            public PhotoAlbum()
            {
                numberOfPages = 16;
            }
            public PhotoAlbum( int n)
            {
                numberOfPages = n;
            }
            public int GetNumberOfPages()
            {
                return numberOfPages;
            }
        }
        public class BigPhotoAlbum : PhotoAlbum
        {
            public BigPhotoAlbum()
            {
                numberOfPages = 64;
            }
        }
        public class AlbumTest
        {
            public static void Main()
            {
                PhotoAlbum album1 = new PhotoAlbum();
                Console.WriteLine(album1.GetNumberOfPages());
                PhotoAlbum album2 = new PhotoAlbum(24);
                Console.WriteLine(album2.GetNumberOfPages());
                PhotoAlbum album3 = new BigPhotoAlbum();
                Console.WriteLine(album3.GetNumberOfPages());
            }
        }

    }
}
