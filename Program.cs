using System;

namespace interfce2
{
    interface ianimal
    {
        void sound(string name,string sounds);
    }
    interface iaqAnimal:ianimal
    {
        void swim(string name,string sounds);
    }
    class animals:ianimal,iaqAnimal
    {
        public string type="Pet";
        public string loc="Dip sea";
        

        public void sound(string name, string sounds)
        {
            Console.WriteLine("Name of animal is: "+name+"\nsound produced by him is: "+sounds+"\n Type of Animal is: "+type);
        }
        public void swim(string name, string sounds)
        {
            Console.WriteLine("Name of acquatic animal is : "+name+"\nsound produced by his is: "+sounds+"\nIt is founf in : "+loc);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            animals a = new animals();
            a.sound("Dog","bark");
            a.swim("Shark", "Shrinks");
        }
    }
}
