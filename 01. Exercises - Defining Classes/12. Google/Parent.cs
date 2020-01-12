namespace Google
{
    public class Parent
    {
        public string ParentName { get; set; }

        public string ParentBirthday { get; set; }

        public Parent(string parentName, string parentBirthday)
        {
            ParentName = parentName;
            ParentBirthday = parentBirthday;
        }

        public override string ToString()
        {
            return $"{ParentName} {ParentBirthday}";
        }
    }
}
