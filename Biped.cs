namespace Heritage

{
    public class Biped : Animal
    {
        public Biped(string name, short legsCount) : base(name, legsCount = 2)
        {}
        public override void Move()
        {
            if (_name == "singe") 
            {
                System.Console.WriteLine($"{_name} climbs the trees");
            }
            else
            {
                System.Console.WriteLine($"{_name} walks");
            }
        }  
        public override void Eat()   
        {
            Console.WriteLine("The animal has a mouth, so it swallows.");
        } 
        }
}

