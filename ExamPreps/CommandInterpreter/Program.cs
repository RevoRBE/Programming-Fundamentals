using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CommandInterpreter2
{
    class CommandInterpreter2
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var command = Console.ReadLine();

            var manipulatedArr = new List<string>(input).ToList();
            while (true)
            {

                if (command == "end")
                {
                    break;
                }
                var commandArr = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (commandArr[0])
                {
                    case "reverse":
                        ReversePartOfArr(manipulatedArr, int.Parse(commandArr[2]), int.Parse(commandArr[4]));
                        break;
                    case "sort":
                        SortPartOfArr(manipulatedArr, int.Parse(commandArr[2]), int.Parse(commandArr[4]));
                        break;
                    case "rollLeft":
                        RollLeft(manipulatedArr, int.Parse(commandArr[1]));
                        break;
                    case "rollRight":
                        RollRight(manipulatedArr, int.Parse(commandArr[1]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + String.Join(", ", manipulatedArr) + "]");
        }

        public static void ReversePartOfArr(List<string> manipulatedArr, int index, int count)
        {

            if (index + count > manipulatedArr.Count || index >= manipulatedArr.Count || index < 0 || count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                manipulatedArr.Reverse(index, count);
            }
        }
        private static void SortPartOfArr(List<string> manipulatedArr, int index, int count)
        {
            if (index >= manipulatedArr.Count || index < 0 || count < 0 || index + count > manipulatedArr.Count)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            else
            {
                manipulatedArr.Sort(index, count, null);
            }
        }
        private static void RollLeft(List<string> manipulatedArr, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            for (int i = 0; i < count % manipulatedArr.Count; i++)
            {
                manipulatedArr.Add(manipulatedArr[0]);
                manipulatedArr.RemoveAt(0);
            }
        }
        private static void RollRight(List<string> manipulatedArr, int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Invalid input parameters.");
            }
            for (int i = 0; i < count % manipulatedArr.Count; i++)
            {
                manipulatedArr.Insert(0, manipulatedArr[manipulatedArr.Count - 1]);
                manipulatedArr.RemoveAt(manipulatedArr.Count - 1);
            }
        }

    }
}