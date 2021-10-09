using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Delegat5.Students
{
    delegate bool FilterDelegate(Student student);
    delegate bool DelegateContains(Student student);



    class Managament
    {

        List<Student> studentsList = new List<Student>(); // includ all student
        List<Student> filterStudent = new List<Student>();// includ only students filter = true
        int length = studentsList.Length;
        void AddStudent(Student student)
        {
            studentsList.Add(student);
        }
        void RemoveStudent(Student student)
        {
            studentsList.Remove(student);
        }
        public delegate bool FilterDelegate(List<Student> students);
        public List<Student> FilterByAge(List<Student> students)
        {
            List<Student> filterByAge = students.Where(s => s.Age > 25).ToList();
            return filterByAge;

        }
        public List<Student> Filter(FilterDelegate filterDelegate)// targil 5
        {

            foreach (var itam in studentsList)
            {
                if (filterDelegate(studentsList))
                {
                    filterStudent.Add(itam);
                }
            }
            return filterStudent;
        }
        public bool Contanis(DelegateContains delegateContains)// targil 6

        {
            var contains = false;
            foreach (var item in studentsList)
            {
                if (delegateContains(item))
                {
                    contains = true;
                }
            }
            return contains;
        }
        public bool ContansGradeUnderFifty(List<Student> list) // targil 7
        {
            var gradeUnderFifty = false;
            foreach (var student in list)
            {
                if (student.Grade < 50)
                {
                    gradeUnderFifty = true;
                }
            }
            return gradeUnderFifty;
        }
        public bool FirstAndLastNameStartWithSameLetter(DelegateContains firstAndLastNameDelegate)
        {
            var firstAndLast = false;
            foreach (var item in studentsList)
            {
                if (firstAndLastNameDelegate(item))
                {
                    firstAndLast = true;
                }
            }
            return firstAndLast;
        }
        public Student FirstAndLast(List<Student> students)
        {
            foreach (var student in students)
            {
                if (student.FirstName.StartsWith(student.LastName))
                {
                    return student;
                }
            }
            return null;
        }
        public delegate int Sumdelegate(Student student); // Targil 9
        public int Sum(Sumdelegate sumdelegate) 
        {
            var sum = 0;
            foreach (var student in studentsList)
            {
                sum += sumdelegate(student);
            }
            return sum;
        }
        public int SumAmountToPay(Student student)
        {
            return student.AmountToPay;
        }
        public int SumAmountPayed(Student student)
        {
            return student.Payed;
        }
        public delegate decimal AverageDelegate(Student student); // Targil 10
        public decimal Average(AverageDelegate averageDelegate)
        {
            decimal studentAverage = 0;
            decimal length = studentsList.Count;
            foreach (var student in studentsList)
            {
                studentAverage += averageDelegate(student);
            }
            return (studentAverage / length);
        }
        public decimal AverageAge(Student student)
        {
            return student.Age;
        }
        public decimal AverageGrade(Student student)
        {
            return student.Grade;
        }
    }
}
