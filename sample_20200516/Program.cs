using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sample_20200516
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<IVirtualPet>
            {
                new SleepyPet("dog"),
                new FoodiePet("cat"),
                new CheerfulPet("monkey")
            };

            //格納した各インスタンスに対して繰り返し処理
            foreach(var pet in pets)
            {
                pet.Eat();
                pet.Play();
                pet.Rest();
                Console.WriteLine
                    ($"{pet.Name}　機嫌：{pet.Mood}　エネルギー：{pet.Energy}");
            }
            Console.ReadKey();
        }
    }

    interface IVirtualPet       //Interfaceキーワードでインターフェースを定義
    {
        string Name { get; }    //getだけ定義
        int Mood { get; set; }
        int Energy { get; set; }
        void Eat();
        void Play();
        void Sleep();
        void Rest();
    }

    class SleepyPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }
        public SleepyPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        public void Eat()       //Interface実装の場合は、overrideキーワードは不要
        {
            Mood -= 1;
            Energy += 5;
            Console.WriteLine
                ("SleepyPet.Eatメソッドが実行されました。");
        }
        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine
                ("SleepyPet.Playメソッドが実行されました。");
        }
        public void Sleep()
        {
            Mood += 1;
            Energy += 2;
            Console.WriteLine
                ("SleepyPet.Sleepメソッドが実行されました。");
        }
        public void Rest()
        {
            Mood += 2;
            Energy += 4;
            Console.WriteLine
                ("SleepyPet.Restメソッドが実行されました。");
        }
    }

    class FoodiePet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }
        public FoodiePet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        public void Eat()
        {
            Mood += 3;
            Energy += 5;
            Console.WriteLine
                ("FoodiePet.Eatメソッドが実行されました。");
        }
        public void Play()
        {
            Mood -= 1;
            Energy -= 10;
            Console.WriteLine
                ("FoodiePet.Playメソッドが実行されました。");
        }
        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine
                ("FoodiePet.Sleepメソッドが実行されました。");
        }    
        public void Rest()
        {
            Mood += 4;
            Energy += 1;
            Console.WriteLine
                ("FoodiePet.Restメソッドが実行されました。");
        }
    }

    class CheerfulPet : IVirtualPet
    {
        public string Name { get; private set; }
        public int Mood { get; set; }
        public int Energy { get; set; }

        public CheerfulPet(string name)
        {
            Name = name;
            Mood = 5;
            Energy = 100;
        }
        public void Eat()
        {
            Mood += 0;
            Energy += 5;
            Console.WriteLine
                ("SleepyPet.Eatメソッドが実行されました。");

        }
        public void Play()
        {
            Mood += 3;
            Energy -= 10;
            Console.WriteLine
                ("SleepyPet.Playメソッドが実行されました。");
        }
        public void Sleep()
        {
            Mood -= 1;
            Energy += 2;
            Console.WriteLine
                ("SleepyPet.Sleepメソッドが実行されました。");
        }
        public void Rest()
        {
            Mood += 1;
            Energy += 5;
            Console.WriteLine
                ("CheerfulPet.Restメソッドが実行されました。");
        }
    }
}
