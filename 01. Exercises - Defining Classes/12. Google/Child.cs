namespace Google
{
    public class Child
    {
        public string ChildName { get; set; }

        public string ChildBirthday { get; set; }

        public Child(string childName, string childBirthday)
        {
            ChildName = childName;
            ChildBirthday = childBirthday;
        }
        public override string ToString()
        {
            return $"{ChildName} {ChildBirthday}";
        }
    }
}
