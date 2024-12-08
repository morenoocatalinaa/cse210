using System;
using System.Threading;

namespace MindfulnessApp
{
    public class MindfulnessActivity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public MindfulnessActivity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public virtual void Start()
        {
            Console.WriteLine($"Starting {_name} activity...");
            DisplayAnimation();
        }

        public virtual void End()
        {
            Console.WriteLine($"Ending {_name} activity.");
        }

        protected virtual void DisplayAnimation()
        {
        }

        protected void Pause(int duration)
        {
            Thread.Sleep(duration * 1000);
        }

        protected int GetDurationFromUser()
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
                {
                    return duration;
                }
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
