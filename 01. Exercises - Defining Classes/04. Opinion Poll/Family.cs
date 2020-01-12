
using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> people;
    public List<Person> People { get; set; }

    public Family()
    {
        this.people = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.people.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.people
           .OrderByDescending(p => p.Age)
           .First();
    }

    public void Print()
    {
        foreach (var item in this.people.OrderBy(p => p.Name))
        {
            System.Console.WriteLine(item.Name + " - " + item.Age);
        }
    }
}

