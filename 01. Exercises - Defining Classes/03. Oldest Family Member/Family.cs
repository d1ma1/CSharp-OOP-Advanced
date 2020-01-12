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
}

