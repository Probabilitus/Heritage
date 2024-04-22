namespace Heritage

{
    public class Quadruped : Animal
    {
        public Quadruped(string name, short legsCount) : base(name, legsCount = 4)
        {}
        public override void Move()
        {
            if (_name == "éléphant") 
            {
                Console.WriteLine($"{_name} is trotting");
            }
            else
            {
                Console.WriteLine($"{_name} is crawl");
            }
        }  
        public override void Eat()   
        {
            Console.WriteLine("The animal has a mouth, so it swallows.");
        } 
    }
}