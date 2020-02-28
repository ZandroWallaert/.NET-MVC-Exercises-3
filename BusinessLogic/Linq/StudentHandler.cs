using System;
using System.Linq;
using System.Collections.Generic;


namespace BusinessLogic.Linq
{
    class StudentHandler
    {
        private List<Student> students = new List<Student> 
        {
            new Student { Id= 1, FirstName = "Freddie", LastName = "Fish", Age = 18 , Sex = "M"},
            new Student { Id= 2, FirstName = "Bill", LastName = "Jones", Age = 21, Sex = "M" },
            new Student { Id= 3, FirstName = "Kitty", LastName = "Cat", Age = 19, Sex = "F" },
            new Student { Id= 4, FirstName = "Suzy", LastName = "Wan", Age = 20, Sex = "F" }
        };
     

        /*
        ==> Bill Jones
        ==> Freddie Fish
        ==> Kitty Cat
        ==> Suzy Wan
        */
        public void StudentOrderByFirstName()
        {
            IEnumerable<Student> ordered = students.OrderBy(s => s.FirstName);

            foreach (Student student in ordered)
                Console.WriteLine($"{student.FirstName} {student.LastName}");
        }

        /*
        ==> Freddie Fish
        */
        public void StartsWithSameCharInFirstNameAndLastName()
        {
            IEnumerable<Student> studentList = students.Where(s => s.FirstName[0].Equals(s.LastName[0]));

            foreach (Student student in studentList)
                Console.WriteLine($"{student.FirstName} {student.LastName}");
        }

        /*
        ==> 19,5
        */
        public void AverageAgeFemaleStudents()
        {
            Console.WriteLine(students.Where(s => s.Sex.Equals("F")).Average(s => s.Age));
        }

        /*
        ==> { Name = Suzy Wan, Code = 21 }


        Formula = id*id + 5
        */
        public void StudentLargestCodeByFormula()
        {
            Console.WriteLine(students.Select(stud => new 
            {
                Name = $"{stud.FirstName} {stud.LastName}", 
                Code = Math.Pow(stud.Id, 2) + 5
            })
            .OrderBy(stud => stud.Code)
            .Last());
        }
     }
}