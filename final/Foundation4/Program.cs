using System;

class Program
{
    static void Main(string[] args)
    {
        activityList.Add(new Running("10 Jul 2023", 80, 2.5));
        activityList.Add(new Cycling("15 March 2023", 120, 1.2));
        activityList.Add(new Swimming("5 Jun 2023", 30, 20));


        foreach(Activity activity in activityList){
            activity.getSummary();
        }
    }

    static List<Activity> activityList = new List<Activity>();
}