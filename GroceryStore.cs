using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace joke {
    class Program {
        static void Main(string[] args) {
            WriteJokeLine("A programmer talks to his wife..");
            TalkToWife();
        }


        public static void TalkToWife() {
            WriteJokeLine("His wife says, go to the grocery store");
            GoToGroceryStore();
        }

        public static void GoToGroceryStore() {
            bool isAtGroceryStore = true;
            WriteJokeLine("and pick up some milk!");
            PickUpMilk();
            WriteJokeLine("While you're there, pick up some eggs");
            while (isAtGroceryStore) {
                PickUpEggs();
            }

            //and he never...
            return;//ed...
        }

        public static void PickUpMilk() {
            Console.WriteLine("I got the milk!");
        }

        public static void PickUpEggs() {
            Console.WriteLine("I got the eggs!");
        }

        public static void WriteJokeLine(string line) {
            Console.WriteLine(line);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
