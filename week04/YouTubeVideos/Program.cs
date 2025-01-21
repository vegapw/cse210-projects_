using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Top 10 Cars in the World", "Fred", 600);
        Video v2 = new Video("Top 10 Games in the World", "Fred", 300);
        Video v3 = new Video("Most used Programming languages in the World", "Fred", 180);
        Video v4 = new Video("Hello World in Spring boot", "Fred", 420);
        Comment c1 = new Comment("Pepe", "I like the first one");
        Comment c2 = new Comment("Paco", "I like the second one");
        Comment c3 = new Comment("Peter", "I like the Last one");
        Comment c4 = new Comment("Paul", "I like them all");
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v1.AddComment(c4);
        Comment c12 = new Comment("Pepe", "The first is awesome");
        Comment c22 = new Comment("Paco", "I have not played the last one");
        Comment c32 = new Comment("Peter", "When was released the third one");
        Comment c42 = new Comment("Paul", "Is a Rpg the 6th game?");
        v2.AddComment(c12);
        v2.AddComment(c22);
        v2.AddComment(c32);
        v2.AddComment(c42);
        Comment c13 = new Comment("Pepe", "Javascript");
        Comment c23 = new Comment("Paco", "Java");
        Comment c33 = new Comment("Peter", "C#");
        Comment c43 = new Comment("Paul", "Python");
        v3.AddComment(c13);
        v3.AddComment(c23);
        v3.AddComment(c33);
        v3.AddComment(c43);
        Comment c14 = new Comment("Pepe", "I like Java");
        Comment c24 = new Comment("Paco", "I like Spring boot");
        Comment c34 = new Comment("Peter", "It was easy");
        Comment c44 = new Comment("Paul", "I want more content");
        v4.AddComment(c14);
        v4.AddComment(c24);
        v4.AddComment(c34);
        v4.AddComment(c44);

        List<Video> videos = new List<Video>();
        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);
        videos.Add(v4);

        foreach (Video item in videos)
        {
            Console.WriteLine(item.GetDisplayText());
        }

    }
}