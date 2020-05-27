using System;

namespace _2._1._2
{
    

        public class Bird
        {
            public int Heigth { get; set; }
            public string Sound { get; set; }
            public int CountEgg { get; set; }
            public int CountChick { get; set; }
            public virtual void Fly()
            {
                Console.WriteLine($"heigth fly={Heigth}");
            }
            public virtual void Sing()
            {
                Console.WriteLine($"Sound sing={Sound}");
            }
            public virtual void Egg()
            {
                Console.WriteLine($"Count egg={CountEgg}");
            }
            public virtual void Chick()
            {
                Console.WriteLine($"Count chick={CountChick}");
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                Bird m = obj as Bird;
                if (m as Bird == null)
                    return false;
                return m.Heigth == this.Heigth && m.Sound == this.Sound && m.CountEgg == this.CountEgg && m.CountChick == this.CountChick;
            }
        }
        public class Zozylya : Bird
        {
            public int CountNest { get; set; }
            public override void Egg()
            {
                Console.WriteLine($"Put the {CountEgg} eggs  in {CountNest} nests");
            }
            public override void Fly()
            {
                base.Fly();
            }
        }
        public class Chicken : Bird
        {
            public int Age { get; set; }
            public override void Egg()
            {
                Console.WriteLine($"Chiken {Age} years old {CountEgg} eggs is");
            }
            public override void Fly()
            {
                Console.WriteLine("Chiken not fly");
            }
        }
        public class Kvochka : Chicken
        {
            public string Color { get; set; }
            public override void Chick()
            {
                Console.WriteLine($"Kvochka raised {CountChick} chicks {Color} color");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Kvochka k1 = new Kvochka();
                Kvochka k2 = new Kvochka();
                k1.Age = 15;
                k1.Color = "black";
                k1.CountChick = 16;
                k1.CountEgg = 20;
                k1.Sound = "ko-ko";
                k1.Egg();
                k1.Fly();
                k1.Sing();
                k1.Chick();
                k2.Age = 15;
                k2.Color = "black";
                k2.CountChick = 16;
                k2.CountEgg = 20;
                k2.Sound = "ko-ko";
                Console.WriteLine(k1.Equals(k2));
            }
        }
    }


    
    

