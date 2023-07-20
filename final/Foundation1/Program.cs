using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\nWelcome to Youtube videos!!\n");

        Video video = new Video ("Story of my life", "Kate", 120);
        Comments comments = new Comments ();
        comments.setComment("Agustin", "That song is amazing");
        video.addCommentList(comments.getComment());
        comments.setComment("Pedro", "You sing really nice");
        video.addCommentList(comments.getComment());
        comments.setComment("Jhon", "The show was fantastic");
        video.addCommentList(comments.getComment());
        videoList.Add(video);

        Video video2 = new Video ("When I was your man", "Bruno", 160);
        comments.setComment("Kelly", "This is a great hit");
        video2.addCommentList(comments.getComment());
        comments.setComment("Carl", "Some day I will play the piano like that");
        video2.addCommentList(comments.getComment());
        comments.setComment("Mark", "The guitar sound is amazing");
        video2.addCommentList(comments.getComment());
        videoList.Add(video2);

        Video video3 = new Video ("Yellow", "Coldplay", 150);
        comments.setComment("Derek", "After listening to that I feel better");
        video3.addCommentList(comments.getComment());
        comments.setComment("Michaell", "The images you used were beautiful");
        video3.addCommentList(comments.getComment());
        comments.setComment("Popy", "I can't sing like you");
        video3.addCommentList(comments.getComment());
        videoList.Add(video3);



        foreach(Video item  in videoList){
            item.getVideoInfo();
            Console.WriteLine();
            Console.WriteLine(item.getNumberOfComments());
            Console.WriteLine();
            foreach(String comment in item.getCommentList()){
                Console.WriteLine(comment);
            }

            Console.WriteLine("---------------------------------------");
        }

        


    }

    static List <Video> videoList = new List<Video>();
}