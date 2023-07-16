using System;

class Program
{
    static void Main(string[] args)
    {

        int option = 0;

        while (option != 4){
        Console.WriteLine("Menu Options");
        String[] menuList = {"1. Start breathing activity", "2. Start reflection activity", "3. Start listing activity", "4. Quit"};
        foreach (String menuItem in menuList){
            Console.WriteLine(menuItem);
        }
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());

        
            switch (option){
                case 1:
                Console.Clear();
                Breathing breathing = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                Console.WriteLine(breathing.getName());
                Console.WriteLine(breathing.getDescription());
                breathing.setTime();
                Console.Clear();
                breathing.getFirstMessage();
                breathing.inAndOut();
                breathing.getLastMessage();
                Console.Clear();
                break;

                case 2:
                Console.Clear();
                Reflection refelction = new Reflection("Refelction", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                Console.WriteLine(refelction.getName());
                Console.WriteLine(refelction.getDescription());
                refelction.setTime();
                Console.Clear();
                refelction.getFirstMessage();
                refelction.setExperiencesList();
                refelction.setQuestionsList();
                refelction.displayExperience();
                refelction.preparation();
                Console.Clear();
                refelction.displayQuestions();
                refelction.getLastMessage();
                Console.Clear();
                break;

                case 3:
                Console.Clear();
                Listing listing = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Console.WriteLine(listing.getName());
                Console.WriteLine(listing.getDescription());
                listing.setTime();
                Console.Clear();
                listing.getFirstMessage();
                listing.setPromptList();
                listing.DisplayPrompt();
                listing.writeAnswers();
                listing.getLastMessage();
                Console.Clear();
                break;
            }
        }
        
    }
}