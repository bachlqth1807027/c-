namespace ExamPaper.entity
{
    public class People
    {
        public string name;
        public string gender;
        private int age;

        public People()
        {
        }

        public People(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Gender
        {
            get => gender;
            set => gender = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        
        public override string ToString()
        {
            return $"name = {Name} , gender = {Gender} , age = {Age}";            
        }
    }
}