namespace OOPBasics
{
    internal class Animal
    {
        public string Name { get; set; }
        public virtual void MakeSound()
        {
            Console.WriteLine($"makes the sound {Name}");

        }
    }
 internal   class Dog : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Makes sound like bow!");
        }

    }
    internal class Cat : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} Makes sound like Meow!");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Dog {Name="Dog" };
            Animal Cat = new Cat { Name = "Cat" };
            Dog.MakeSound();
            Cat.MakeSound();

            Console.WriteLine("Day1 -Completed!!");
        }
    }
}
