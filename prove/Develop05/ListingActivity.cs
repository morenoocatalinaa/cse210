using System;
using System.Threading;

namespace MindfulnessApp
{
    public class ListingActivity : MindfulnessActivity
    {
        public ListingActivity() : base("Listing", "A listing activity")
        {
        }

        protected override void DisplayAnimation()
        {
            Console.WriteLine("Listing animation...\n");
            for (int i = 0; i < _duration; i++)
            {
                Console.Write(".");
                Pause(1);
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
