using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat5.Students
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public int AmountToPay { get; set; }
        public int Payed { get; set; }
        

        public Student()
        {
                
        }
        public Student(string firstName, int age, int grade, int amountToPay)
        {
            FirstName = firstName;
            Age = age;
            Grade = grade;
            AmountToPay = amountToPay;
        }
    }
}
