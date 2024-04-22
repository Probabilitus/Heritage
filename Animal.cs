namespace Heritage
{
    public abstract class Animal
    {
        protected short _legsCount;
        protected string _name;
        public Animal(string name, short legsCount)
        {
            _name = name;
            _legsCount = legsCount;
        }
        public string GetName()
        {
            return _name;
        }

        public abstract void Eat();
        public abstract void Move();
    }
}