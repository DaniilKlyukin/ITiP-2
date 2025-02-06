namespace LR1Example
{
    public class Company
    {
        public Company(string name, string country)
        {
            Name = name;
            Country = country;
        }

        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название компании не может быть пустым");
                }
                name = value;
            }
        }

        private string country;
        public string Country
        {
            get => country;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Название страны не может быть пустым");
                }
                country = value;
            }
        }
    }
}
