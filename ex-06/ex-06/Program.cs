class Animal
{
    public int Age { get; set; }
    public string Name { get; set; }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name}, born {Age} years ago is speaking");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name}, born {Age} years ago is howling");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name}, born {Age} years ago is meowing");
    }
}

class Bird : Animal
{
    public override void Speak()
    {
        Console.WriteLine($"{Name}, born {Age} years ago is tweeting");
    }
}

class Program
{
    static void Main(string[] args )
    {
        Dog dog = new Dog();
        dog.Name = "Pluto";
        dog.Age = 13;
        dog.Speak();

        Cat cat = new Cat();
        cat.Name = "Gambadilegno";
        cat.Age = 3;
        cat.Speak();

        Bird bird = new Bird();
        bird.Name = "Tuco";
        bird.Age = 5;
        bird.Speak();
    }
}