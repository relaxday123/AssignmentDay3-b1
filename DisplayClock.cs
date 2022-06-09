using System;

namespace b4
{
    public class DisplayClock
    {
        public void Subcribe(Clock clock)
        {
            clock.clockTickEvent += ShowClock;
        }

        public void ShowClock(object clock, TimeInfoEventArgs timeInfoEvent)
        {
            Console.WriteLine($"{timeInfoEvent.hour} : {timeInfoEvent.minute} : {timeInfoEvent.second}");
        }
    }
}