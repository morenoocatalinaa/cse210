using System;
using System.Threading;

namespace MindfulnessApp
{
    public class BreathingActivity : MindfulnessActivity
    {
        public BreathingActivity() : base("Breathing", "A simple breathing activity")
        {
        }

        protected override void DisplayAnimation()
        {
            Console.WriteLine("Welcome to breathing session");
            Console.WriteLine("Breathing Activity\n");
            Console.WriteLine("This activity will help you relax by walking through a breathing exercise.\n");

            for (int i = 0; i < _duration; i++)
            {
                Console.WriteLine("Inhale...");
                Pause(4);
                Console.WriteLine("Exhale...");
                Pause(4);
            }
        }

        public new void Start()
        {
            _duration = GetDurationFromUser();
            base.Start();
            Console.WriteLine($"Duration: {_duration} seconds.\n");
            DisplayAnimation();
            End();
        }
    }
}
