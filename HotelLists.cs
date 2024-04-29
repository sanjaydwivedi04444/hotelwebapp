using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelWebApp
{
    public class HotelLists
    {
        public static string GetRating(int rating)
        {
            var objStr = new StringBuilder();
            int remain = 5 - rating;
            for (int i = 0; i < rating; i++)
            {
                objStr.Append("<span class='fa fa-star checked'>");
            }
            for (int i = 0; i < remain; i++)
            {
                objStr.Append("<span class='fa fa-star'>");
            }
            return objStr.ToString();
        }
        public static List<HotelDetail> GetHotelLists()
        {
            var objHotelList = new List<HotelDetail>();
            var objHotel1 = new HotelDetail()
            {
                HotelId = 100401,
                Name = "Hilton",
                Address = "5015 Campbell Blvd",
                HotelUrl = "http://hilton.com",
                Rating = 2,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/151-exmouth-blog-post-image-20200221113448.jpg",
                Price = "$135 - $193*",
                DisplayRating= GetRating(2)
            };
            var objHotel2 = new HotelDetail()
            {
                HotelId = 100402,
                Name = "Mandarin Oriental",
                Address = "5015 Delhi INDIA",
                HotelUrl = "http://hilton.com",
                Rating = 3,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/1010-london-blog-post-image-20210416133554.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(3)
            };
            var objHotel3 = new HotelDetail()
            {
                HotelId = 100403,
                Name = "The Athenaeum Hotel & Residency",
                Address = "10 Suite Campbell Blvd",
                HotelUrl = "http://hilton.com",
                Rating = 4,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/462-london-blog-post-image-20210312175821.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(4)
            };
            var objHotel4 = new HotelDetail()
            {
                HotelId = 100404,
                Name = "The Eastbury Hotel",
                Address = "51 Bristol Irland",
                HotelUrl = "http://hilton.com",
                Rating = 1,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/455-dorest-blog-post-image-20200114155055.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(1)
            };
            var objHotel5 = new HotelDetail()
            {
                HotelId = 100405,
                Name = "The Grove",
                Address = "5014 Burz Khalifa Dubai",
                HotelUrl = "http://tajhotel.com",
                Rating = 5,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/961-hertfordshire-blog-post-image-20210315121357.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(5)
            };
            var objHotel6 = new HotelDetail()
            {
                HotelId = 100406,
                Name = "The Langham London",
                Address = "55 New York City",
                HotelUrl = "http://chifyi.com",
                Rating = 5,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/528-london-blog-post-image-20201021161552.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(5)
            };
            var objHotel7 = new HotelDetail()
            {
                HotelId = 100407,
                Name = "The Lygon Arms Hotel",
                Address = "415 Dudewell United Kingdom",
                HotelUrl = "http://hilton.com",
                Rating = 4,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/--blog-post-image-20190904144355.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(4)
            };
            var objHotel8 = new HotelDetail()
            {
                HotelId = 100408,
                Name = "Sai Naka",
                Address = "315 Hitler Road London",
                HotelUrl = "http://sainaka.com",
                Rating = 3,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/--blog-post-image-20190904144355.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(3)
            };
            var objHotel9 = new HotelDetail()
            {
                HotelId = 100409,
                Name = "Cadogan Garden",
                Address = "11 England",
                HotelUrl = "http://cadongarden.com",
                Rating = 2,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/1026-london-blog-post-image-20210427150513.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(2)
            };
            var objHotel10 = new HotelDetail()
            {
                HotelId = 1004010,
                Name = "Chewton Glen Hotel & Spa",
                Address = "New Milton",
                HotelUrl = "http://newmilton.com",
                Rating = 1,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/--blog-post-image-20190903114345.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(1)
            };
            var objHotel11 = new HotelDetail()
            {
                HotelId = 1004011,
                Name = "Clevedon House",
                Address = "5015 Campbell Blvd",
                HotelUrl = "http://clevedon.com",
                Rating = 2,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/--blog-post-image-20190903160547.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(2)
            };
            var objHotel12 = new HotelDetail()
            {
                HotelId = 1004012,
                Name = "Chalet Aurelio",
                Address = "Lech ARM Alberge",
                HotelUrl = "http://chalet.com",
                Rating = 3,
                ImageUrl = "https://addressbook.tatler.com/uploads/news-pictures/--blog-post-image-20190904141911.jpg",
                Price = "$135 - $193*",
                DisplayRating = GetRating(3)
            };
            objHotelList.Add(objHotel1); objHotelList.Add(objHotel2); objHotelList.Add(objHotel3);
            objHotelList.Add(objHotel4); objHotelList.Add(objHotel5); objHotelList.Add(objHotel6);
            objHotelList.Add(objHotel7); objHotelList.Add(objHotel8); objHotelList.Add(objHotel9);
            objHotelList.Add(objHotel10); objHotelList.Add(objHotel1); objHotelList.Add(objHotel2);
            return objHotelList;
        }
    }
}
