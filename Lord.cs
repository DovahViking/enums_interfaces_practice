using System;
using System.Collections.Generic;
using System.Text;

namespace enums_and_interfaces
{
    class Lord
    {
        public static List<Lord> lords = new List<Lord>();

        public string name;
        string surname;
        int age;
        string faction;

        public Lord(string name, string surname, int age, string faction)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.faction = faction;
            lords.Add(this);
        }

        public static void get_lords()
        {
            foreach (Lord l in lords)
            {
                Console.WriteLine(l);
            }
        }

        public override string ToString()
        {
            return string.Format("\nName: {0} {1}\nAge: {2}\nFaction: {3}", name, surname, age, faction);
        }
    }
}
