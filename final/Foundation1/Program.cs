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


        foreach (Video video in _author)
        {
            Console.WriteLine($"{video._title} {video._author} {video._length}");
            Console.WriteLine(video.AmountOfComments());
        }
    }
}