using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video()
        video1._title = "Learn Bolivian Cooking";
        video1._author = "Jorge Gonzales";
        video1._length = 120;
        Comment comment1V1 = new Comment();
        comment1V1._name = "Sam";
        comment1V1._text = "Bolivain cooking seems so fun";
        video1._comments.Add(comment1V1);
        
        Comment comment2V1 = new Comment();
        comment2V1._name = "Paul";
        comment2V1._text = "How can i order the ingredients";
        video1._comments.Add(comment2V1);
        _videos.Add(video1);

        Video video2 = new Video()
        video2._title = "Learn Nigerian Cooking";
        video2._author = "Kelechi";
        video2._length = 150;
        Comment comment1V2 = new Comment();
        comment1V2._name = "Karen";
        comment1V2._text = "That looks spicy!";
        video2._comments.Add(comment1V2);
        
        Comment comment2V2 = new Comment();
        comment2V2._name = "Gary";
        comment2V2._text = "I had this food back in the army";
        video2._comments.Add(comment2V2);
        _videos.Add(video2);


        foreach (Video video in _videos)
        {
            Console.WriteLine($"{video._title} {video._author} {video._length}");
            Console.WriteLine($" The number of comments: {video.AmountOfComments()});
            Console.WriteLine("");
        }
    }
}