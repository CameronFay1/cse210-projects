using System;

class Program
{
    static void Main(string[] args)
    {
        Video V1 = new Video("How to fix the iphone 4", "fIX It ALL", 674);
        Comment C1 = new Comment();
        Comment C2 = new Comment();
        Comment C3 = new Comment();
        C1.SetComment("jeff", "this video saved my old phone!"); V1.AddComment(C1);
        C2.SetComment("epicBrogames", "its not working why bad video!"); V1.AddComment(C2);
        C3.SetComment("Unown", "such great editing."); V1.AddComment(C3); 
        V1.Display(); Console.WriteLine("");
        Video V2 = new Video("why birds are not real", "ConspairacyKing", 14400);
        Comment C4 = new Comment();
        Comment C5 = new Comment();
        Comment C6 = new Comment();
        C4.SetComment("emtymine", "this is soooo true!"); V2.AddComment(C4);
        C5.SetComment("negativeZero", "why is this video soo long."); V2.AddComment(C5);
        C6.SetComment("InTheStars", "who would beleve this!"); V2.AddComment(C6);
        V2.Display(); Console.WriteLine("");
        Video V3 = new Video("how to cook for thankesgiving", "sunshinePain", 572);
        Comment C7 = new Comment();
        Comment C8 = new Comment();
        Comment C9 = new Comment();
        C7.SetComment("FaceChanging", "this was very helpfull i did not know to to cook."); V3.AddComment(C7);
        C8.SetComment("muncherMan", "I know this is for thankesgiving but im going to make some of these for dinner."); V3.AddComment(C8);
        C9.SetComment("spaceDogs", "these are terrible recipes DO NOT MAKE!"); V3.AddComment(C9);
        V3.Display(); Console.WriteLine("");

    }
}