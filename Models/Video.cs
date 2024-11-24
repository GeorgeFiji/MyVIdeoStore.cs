namespace MyVideostore.Models
{
    public class Video
    {

        public int VideoID { get; set; }
        public required string Title { get; set; }
        public required string Director { get; set; }
        public int GenreID { get; set; }

        public byte[]? Poster { get; set; }



        /*
* Genre?- nullable property
* 
* What it does?
* 
*/
        public Genre? Genre { get; set; }//Mr Peni Narube made changes
    }
}
