using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowwhite
{
    class Dwarf
    {

        // Field
        public string Name { get; set; }
        public string Color { get; set; }
        public int Counter { get; set; }
        public long Physics { get; set; }

        // Constructor that takes one argument.
        public Dwarf(string name, string color, long physics)
        {
            this.Physics = physics;
            this.Name = name;
            this.Color = color;
        }

        // Method
        //public bool SetName(string newName)
        //{
        //    Name = newName;
        //}

    }
    class Snowwhite
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<Dwarf> dwarfs = new List<Dwarf>();
                //Dictionary<string, Dictionary<string, long>> dwarfs = new Dictionary<string, Dictionary<string, long>>();

            while (input != "Once upon a time")
            {
                string[] data = input.Split(">:< ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                string dwarfName = data[0];
                string dwarfColor = data[1];
                long dwarfPhysics = long.Parse(data[2]);
                Dwarf temp = new Dwarf(dwarfName, dwarfColor, dwarfPhysics);
                if (dwarfs.Contains(temp.)
                {

                }
                //if (!dwarfs.ContainsKey(dwarfName))
                //{
                //    dwarfs.Add(dwarfName, new Dictionary<string, long>());
                //    dwarfs[dwarfName][dwarfHatColor] = dwarfPhysics;
                //}
                //else
                //{
                //    if (!dwarfs[dwarfName].ContainsKey(dwarfHatColor))
                //    {
                //        dwarfs[dwarfName].Add(dwarfHatColor, dwarfPhysics);
                //    }
                //    else if (dwarfs[dwarfName][dwarfHatColor] < dwarfPhysics)
                //        dwarfs[dwarfName][dwarfHatColor] = dwarfPhysics;
                //}
                //dwarfs[dwarfName][dwarfHatColor] = dwarfPhysics;

                input = Console.ReadLine();
            }
            foreach (var dwarf in dwarfs)
            {

            }
            //foreach (var dwarf in dwarfs.OrderByDescending(x => x.Value.Values.Max()).ThenBy(k => k.Value.Count))    // .ThenBy(k => k.Key))
            //{
            //    foreach (var color in dwarf.Value.OrderByDescending(x => x.Value))
            //    {
            //        Console.WriteLine($"({color.Key}) {dwarf.Key} <-> {color.Value}");
            //    }
            //}
        }
    }
}
