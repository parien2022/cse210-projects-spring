using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("The famous lectures", "This is the best place to share good moments", "10/08/2023", "15:00", new Address("Margaret Street", "Los Angeles", "California", "USA"), "Jhon Cross", 200);
        lecture.getStandardDetails();
        lecture.getLectureInfo();
        lecture.getShortDescription();

        Receptions receptions = new Receptions("The wanderful Receptions", "What are you waiting to join the best reception ever?", "15/09/2023", "18:00", new Address("Bros Street", "Las Vegas", "Nevada", "USA"), "receptions.events@gmail.com");
        receptions.getStandardDetails();
        receptions.getReceptionsInfo();
        receptions.getShortDescription();

        Outdoor outdoor = new Outdoor("The bright Outdoor", "If you like to spend time outside and meet new people don't loos the opportnity and come with us", "20/10/2023", "13:30", new Address("Grill Street", "Miami", "Florida", "USA"), "Sunny 77°F");
        outdoor.getStandardDetails();
        outdoor.getOutdoorsInfo();
        outdoor.getShortDescription();
    }
}