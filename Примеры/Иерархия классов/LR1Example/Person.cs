namespace LR1Example
{

    public class Person
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Имя не может быть пустым");
                }
                name = value;
            }
        }

        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Возраст не может быть меньше нуля");

                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
