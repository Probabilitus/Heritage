using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Heritage;

class Program
{
    static void Main(string[] args)
    {
        Biped animal1 = new Biped("singe",2);
        string name1 = animal1.GetName();
        animal1.Move();
    }
}