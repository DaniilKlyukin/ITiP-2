namespace LR1Example
{

    public class Employee : Person
    {
        public static double MinimunWage = 1000;

        private Position position;
        public Position Position
        {
            get => position;
            set
            {
                if (!Enum.IsDefined(value))
                {
                    throw new ArgumentException("Такой должости нет");
                }

                position = value;
            }

        }

        private Company company;
        public Company Company
        {
            get=>company;
            set
            {
                if (value == null)
                    throw new ArgumentException("Такой должости нет");

                company = value;
            }
        }

        private double salary;
        public double Salary
        {
            get => salary;
            set
            {
                if (value < MinimunWage)
                    throw new ArgumentException("Зарплата не может быть меньше МРОТ");

                salary = value;
            }
        }

        public Employee(
    string name, int age, Position position, Company company, double salary)
    : base(name, age)
        {
            Position = position;
            Company = company;
            Salary = salary;
        }
    }
}
