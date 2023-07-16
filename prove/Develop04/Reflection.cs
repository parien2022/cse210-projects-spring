public class Reflection : Common {

    private List<String> _experiencesList = new List<string>();
    private List<String> _relatedQuestionsList = new List<string>();
    
    public Reflection (String name, String description) : base(name, description){   
    }

    public void setExperiencesList (){
        _experiencesList.Add("Think of a time when you did something really difficult.");
        _experiencesList.Add("Think of a time when you had to go out from your comfort zone.");
        _experiencesList.Add("Think of a time when you helped someone in need.");
        _experiencesList.Add("Think of a time when you did something truly selfless.");
        _experiencesList.Add("Think of a time when you stood up for someone else.");

    }

    public void setQuestionsList (){
        _relatedQuestionsList.Add("Why was this experience meaningful to you? ");
        _relatedQuestionsList.Add("Have you ever done anything like this before? ");
        _relatedQuestionsList.Add("How did you feel when it was complete? ");
        _relatedQuestionsList.Add("What is your favorite thing about this experience? ");
    }

    public void displayExperience (){
        
        Random random = new Random();
        int randomIndex =  random.Next(0, _experiencesList.Count);
        String randomOption = _experiencesList[randomIndex];
        Console.WriteLine($"\n--- {randomOption} ---\n");

        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }

    public void preparation() {

        String[] countList = getCountList();
        Console.WriteLine("\nNow ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        animation(0, countList, 1000);
    }

    public void displayQuestions(){

        Random random = new Random();
        

        String time = getTime();
        int seconds = int.Parse(time);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        
        List<int> countRecord = new List<int>();
        String[] sppinerList = getSpinnerList();
        while (startTime < futureTime){
            int randomIndex = 0;
            while (countRecord.Contains(randomIndex)){
                randomIndex = random.Next(0, _relatedQuestionsList.Count);
            }
            String randomOption = _relatedQuestionsList[randomIndex];
            Console.Write($"\n> {randomOption}");
            for (int i = 0; i < 6; i++){
            animation(2, sppinerList, 500);
            }
            startTime = DateTime.Now;
            countRecord.Add(randomIndex);
        }
            
        }

}