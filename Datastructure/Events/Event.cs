using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events
{
    public delegate void EventManager( );
    public class Event
    {
        private string _eventName;
        public static event EventManager eventlink=null;// user defined event && here event link is the object
        static int i;

        public Event(string eventName)
        {
            _eventName=eventName;

        }
        public static void HandleEvent( )
        {
            i=0;
            System.Console.WriteLine("User Registration ");
            System.Console.WriteLine("Starting the following events ");
            eventlink( );// event trigger -> Like clikking a button 

        }

        public void ShowEvents( )
        {
            ++i;System.Console.WriteLine("Event Name : "+_eventName+" Started ");
        }
    }
}