using System;
using System.Collections.Generic;

namespace FamilyTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = Console.ReadLine();
            var input = Console.ReadLine();

            var listOfInputs = new List<string>();
         
            while (input != "End")
            {
                listOfInputs.Add(input);
                input = Console.ReadLine();
            }

            var tempPerson = SerchPerson(listOfInputs, person);
            Person findPerson = makePerson(tempPerson);
            
            foreach (var li in listOfInputs)
            {
                if (li.Contains("-"))
                {
                    if (li.Contains(findPerson.Name) || li.Contains(findPerson.Birthday) )
                    {
                        var temp = li.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                        
                        if (findPerson.Name == temp[0])
                        {
                            var tempChild = SerchPerson(listOfInputs, temp[1]);
                            Child findChild = makeChild(tempChild);
                            findPerson.Children.Add(findChild);
                        }
                        if (findPerson.Name == temp[1])
                        {
                            var tempParent = SerchPerson(listOfInputs, temp[0]);
                            Parent findParent = makeParent(tempParent);
                            findPerson.Parents.Add(findParent);
                        }
                        if (findPerson.Birthday == temp[0])
                        {
                            var tempChild = SerchPerson(listOfInputs, temp[1]);
                            Child findChild = makeChild(tempChild);
                            findPerson.Children.Add(findChild);
                        }
                        if (findPerson.Birthday == temp[1])
                        {
                            var tempParent = SerchPerson(listOfInputs, temp[0]);
                            Parent findParent = makeParent(tempParent);
                            findPerson.Parents.Add(findParent);
                        }
                    }
                }
            }

            Console.WriteLine(findPerson.Name + " " + findPerson.Birthday);
            Console.WriteLine("Parents:");
            foreach (var parent in findPerson.Parents)
            {
                Console.WriteLine(parent.ParentName + " " + parent.ParentBirthday);
            }
            Console.WriteLine("Children:");
            foreach (var child in findPerson.Children)
            {
                Console.WriteLine(child.ChildName + " " + child.ChildBirthday);
            }

        }

        public static string SerchPerson(List<string> listOfInputs, string person)
        {

            foreach (var li in listOfInputs)
            {
                if (!li.Contains("-") && li.Contains(person))
                {
                    person = li;
                    //listOfInputs.Remove(li);
                    break;
                }
            }

            return person;
        }
        public static Person makePerson(string person)
        {
            var split = person.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var name = split[0] + " " + split[1];
            var birthday = split[2];

            var newPerson = new Person(name, birthday);
            return newPerson;
        }

        public static Child makeChild(string person)
        {
            var split = person.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = split[0] + " " + split[1];
            var birthday = split[2];

            var newChild = new Child(name, birthday);
            return newChild;
        }


        public static Parent makeParent(string person)
        {
            var split = person.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var name = split[0] + " " + split[1];
            var birthday = split[2];

            var newParent = new Parent(name, birthday);
            return newParent;
        }
    }
}
