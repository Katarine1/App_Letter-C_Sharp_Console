namespace App4_Letter.Model
{
    public class Letters
    {
        private string Name { get; set; }

        public Letters() { }

        public Letters(string name)
        {
            Name = name;
        }

        public string LetterA(string name)
        {
            if(name.Contains('A'))
            {
                string n = name.Replace('A', '_');
                Name = n;
                return Name;
            }else if (name.Contains('a'))
            {
                string n = name.Replace('a', '_');
                Name = n;
                return Name;
            }
            return null;
        }

        public override string ToString()
        {
            return "Name" + Name;
        }
    }
}
