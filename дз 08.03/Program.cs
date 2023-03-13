using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз_08._03
{
    class Student
    {
        private string lastName;
        private string firstName;
        private string patronymic;
        private DateTime birthDate;
        private string address;
        private string phoneNumber;
        private List<int> credits;
        private List<int> homeworks;
        private List<int> exams;

        public Student(string lastName, string firstName, string patronymic, DateTime birthDate,
                       string address, string phoneNumber)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.patronymic = patronymic;
            this.birthDate = birthDate;
            this.address = address;
            this.phoneNumber = phoneNumber;
            credits = new List<int>();
            homeworks = new List<int>();
            exams = new List<int>();
        }

        public Student(string lastName, string firstName, DateTime birthDate,
                       string address, string phoneNumber)
            : this(lastName, firstName, "", birthDate, address, phoneNumber)
        {
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public List<int> Credits
        {
            get { return credits; }
        }

        public List<int> Homeworks
        {
            get { return homeworks; }
        }

        public List<int> Exams
        {
            get { return exams; }
        }

        public override string ToString()
        {
            return string.Format("ФИО: {0} {1} {2}\nДата рождения: {3}\nАдрес: {4}\nТелефон: {5}\nЗачёты: {6}\nДомашние задания: {7}\nЭкзамены: {8}",
                                 lastName, firstName, patronymic, birthDate.ToShortDateString(), address, phoneNumber,
                                 string.Join(", ", credits), string.Join(", ", homeworks), string.Join(", ", exams));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Беззубко", "Владислав", "Батькович", new DateTime(2000, 1, 1), "Одесса, ул. Садовая, д.13", "+380980989898");
            student.Credits.Add(4);
            student.Credits.Add(5);
            student.Homeworks.Add(3);
            student.Homeworks.Add(4);
            student.Exams.Add(4);
            student.Exams.Add(5);

            Console.WriteLine(student.ToString());
        }
    }

}