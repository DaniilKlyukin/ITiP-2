namespace MyLib
{
    public class Person
    {
        string name;

        public Person(string name)
        {
            this.name = name;
        }

        public void Print() => Console.WriteLine($"Name: {name}");
    }
}
