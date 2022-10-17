using System;
namespace Events;
 class Program 
 {
    public static void Main(string[] args)
    {
        Event event1=new Event("Quiz ");
        Event event2=new Event("Debugging ");
        Event event3=new Event("Presentation ");
        Event event4=new Event("Games ");

        Event.eventlink +=new EventManager(event1.ShowEvents);
        Event.eventlink +=new EventManager(event2.ShowEvents);
        Event.eventlink +=new EventManager(event3.ShowEvents);
        Event.eventlink +=new EventManager(event4.ShowEvents);
        Event.HandleEvent( );//process initialization


        //To cancel the particular event
        Event.eventlink -=new EventManager(event4.ShowEvents);
        Event.HandleEvent( );
    }
 }