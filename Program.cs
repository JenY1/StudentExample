using System;
using System.Collections.Generic;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      var students = new List<Student>() {
      	new Student() { FirstName = "Xavier", LastName = "Thorpe" },
        new Student() { FirstName = "Bianca", LastName = "Barclay" },
        new Student() { FirstName = "Eugene", LastName = "Otinger" },
        new Student() { FirstName = "Enid", LastName = "Sinclair" },
        new Student() { FirstName = "Wednesday", LastName = "Addams" }
      };
      
      Console.WriteLine("-- Student List --");
      foreach (var student in students) {
      	Console.WriteLine(student.Name);
      }
    }
  }
  
   public class Student {
      public string FirstName { get; set; }  
      public string LastName { get; set; }
      public string Name => $"{FirstName} {LastName}";
  	}
}
