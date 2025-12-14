using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Learn Bolivian Cooking";
        video1._author = "Jorge Gonzales";
        video1._length = 120;
        
        Comment comment1V1 = new Comment();
        comment1V1._name = "Sam";
        comment1V1._text = "Bolivain cooking seems so fun";
        video1._comments.Add(comment1V1);
        
        Comment comment2V1 = new Comment();
        comment2V1._name = "Paul";
        comment2V1._text = "How can i order the ingredients?";
        video1._comments.Add(comment2V1);
        

        Video video2 = new Video();
        video2._title = "Learn Nigerian Cooking";
        video2._author = "Kelechi";
        video2._length = 150;
        
        Comment comment1V2 = new Comment();
        comment1V2._name = "Karen";
        comment1V2._text = "That looks spicy!😀";
        video2._comments.Add(comment1V2);
        
        Comment comment2V2 = new Comment();
        comment2V2._name = "Gary";
        comment2V2._text = "I had this food back in the army! I served in the area";
        video2._comments.Add(comment2V2);

        Comment comment3V2 = new Comment();
        comment3V2._name = "Nicholas";
        comment3V2._text = "I feel hungry now";
        video2._comments.Add(comment3V2);

        Video video3 = new Video();
        video3._title = "Learn C-Sharp for Beginners";
        video3._author = "Nathan Jack";
        video3._length = 100;

        Comment comment1V3 = new Comment();
        comment1V3._name = "Kelsey";
        comment1V3._text = "This helped me in my final project!😀";
        video3._comments.Add(comment1V3);
        
        Comment comment2V3 = new Comment();
        comment2V3._name = "David";
        comment2V3._text = "I dont really understand Inheritance?";
        video3._comments.Add(comment2V3);

        Comment comment3V3 = new Comment();
        comment3V3._name = "Patel";
        comment3V3._text = "Hello from India!";
        video3._comments.Add(comment3V3);

        Comment comment4V3 = new Comment();
        comment4V3._name = "Parrish";
        comment4V3._text = "I taught my students exactly this!";
        video3._comments.Add(comment4V3);
        
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);

        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video._title} | Author: {video._author} | Duration (in seconds): {video._length}");
            Console.WriteLine($"Comments: {video.AmountOfComments()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"Name of Commenter: {comment._name} | Text: {comment._text}");
            }
            Console.WriteLine("");
        }
    }
}