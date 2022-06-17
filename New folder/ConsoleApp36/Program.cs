using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Human firsthuman = new Human("Fazil", " qarayev", "Gulmemmed", 52, "male", "Azeri", 5);
            {


            }
            Human secondhuman = new Human("maksuq", " cunayev", "kapasito", 41, "female", "rus", 1);
            {

            }
            Human thirdhuman = new Human("mamiko", " arayan", "riko", 69, "male", "ARmyan", 4);
            {

            }
            Console.WriteLine(thirdhuman.name);

        }

    }
    class Human
    {
        public Human(string _name, string _lastName, string _dadsName, int _age, string _gender, string _nathion, int _bloodGroup)
        {
            name = _name;
            lastName = _lastName;
            dadsName = _dadsName;
            age = _age;
            gender = _gender;
            nathion = _nathion;
            bloodGroup = _bloodGroup;
        }

        public string name;
        public string lastName;
        public string dadsName;
        public int age;
        public string gender;
        public string nathion;
        public int bloodGroup;
    }
}
