public class Listing : Common {

    private List<String> _promptList = new List<String>();
    private List<String> _answersList = new List<String>();

    public Listing (String name, String description) : base(name, description){
    }

    public void setPromptList(){
        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }

    public void DisplayPrompt() {

        Random random = new Random();
        String[] countList = getCountList();

        Console.WriteLine("\nList as many responses you can to the following prompt: ");

        int randomIndex = random.Next(0, _promptList.Count);
        String randomOption = _promptList[randomIndex];

        Console.WriteLine($"\n--- {randomOption} ---");
        Console.Write("You may begin in: ");
        animation(1, countList, 1000);
    }

    public void writeAnswers() {

        String time = getTime();
        int seconds = int.Parse(time);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        Console.WriteLine("");

        while (startTime < futureTime){

            Console.Write("> ");
            String answer = Console.ReadLine();
        
            _answersList.Add(answer);
            startTime = DateTime.Now;
        }

        Console.WriteLine($"You listed {_answersList.Count} items!");
    }
}