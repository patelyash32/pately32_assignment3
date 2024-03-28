using System;

namespace ValidationExample
{
 public class BaseClass
 {
 
 public virtual bool IsValidated()
 {
 return false;
 }
 }

 public class Person : BaseClass
 {
 
 public Person(string firstName = "", string lastName = "")
 {
 FirstName = firstName;
 LastName = lastName;
 }

 public string FirstName { get; set; }

 
 public string LastName { get; set; }

 
 public override bool IsValidated()
 {
    
 if (FirstName == null)
         {
         FirstName = "";
         }
    
                
 if (LastName == null)
         {
         LastName = "";
         }
    

 if (FirstName.Length > 0 && LastName.Length > 0)
         {
         return true;
         }
     else
        {
         return false;
        }
     }
 }

 class Program
 {
     static void Main(string[] args)
 {
         Person bob = new Person();
         Console.WriteLine(bob.IsValidated()); 
        
 Person kim = new Person("kim", "smith");
         Console.WriteLine(kim.IsValidated()); 
         }
     }
}