using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Address lectureaddress = new Address ("650 S","Rexburg","Idaho","USA");
        LectureEvent lectureEvent = new LectureEvent("Learning C-Sharp","Participants will learn about OOP","12/12/2025","2:00PM",lectureaddress,"Samuel",50);
        lectureEvent.DisplayShortDescription();
        Console.WriteLine("");
        lectureEvent.DisplayFullDetails();
        Console.WriteLine("");
        lectureEvent.DisplayStandardDetails();
        Console.WriteLine("");

        Address receptionAddress = new Address("200 N", "Provo", "Utah", "USA");
        ReceptionEvent receptionEvent = new ReceptionEvent("Wedding","Come Join in the matrimony of Paul and Paula","2/12/2025","12:00PM", receptionAddress, "sam@gmail.com");
        receptionEvent.DisplayShortDescription();
        Console.WriteLine("");
        receptionEvent.DisplayFullDetails();
        Console.WriteLine("");
        receptionEvent.DisplayStandardDetails();
        Console.WriteLine("");

        Address outdoorGatheringAddress = new Address("500 Plane", "Bronx", "NYC", "USA");
        OutdoorGatheringEvent outdoorGatheringEvent = new OutdoorGatheringEvent("Pride and Prejudice 2 Premiere", "Come and join us as we watch Pride and Prejudice 2","4/12/2025","5:00PM", outdoorGatheringAddress, "20 Degress Celcius");
        outdoorGatheringEvent.DisplayShortDescription();
        Console.WriteLine("");
        outdoorGatheringEvent.DisplayFullDetails();
        Console.WriteLine("");
        outdoorGatheringEvent.DisplayStandardDetails();
        Console.WriteLine("");

    }
}