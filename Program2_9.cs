using System;
using lab9_2_9.serializers1;
class Program2_9
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine("Выберите вид зимнего спорта: 1 - Фигурное катание, 2 - Конькобежный спорт");
        int choice = random.Next(1, 3);
        winter_sports sport;
        Skater[] skaters = new Skater[5];
        double[] results;
        double res;
        Console.WriteLine();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Участник " + (i + 1));
            string[] surnames = new string[5];
            surnames[0] = new string("Morozov");
            surnames[1] = new string("Sidorov");
            surnames[2] = new string("Kotlov");
            surnames[3] = new string("Vasenin");
            surnames[4] = new string("Zaharenkova");
            Console.WriteLine("Оценки судей:");
            results = new double[7];
            for (int j = 0; j < 7; j++)
            {
                Console.Write((j + 1) + " - ");
                res = random.Next(0, 7);
                results[j] = res;
            }
            skaters[i] = new Skater(surnames[i], results);
            Console.WriteLine();
        }

        for (int i = 0; i < 5; i++)
        {
            double placeSum = 0;
            for (int j = 0; j < 7; j++)
            {
                double place = 1;
                for (int k = 0; k < 5; k++)
                {
                    if (k != i && skaters[i].Results[j] > skaters[k].Results[j])
                    {
                        place++;
                    }
                }
                placeSum += place;
            }
            skaters[i].PlaceSum = placeSum;
        }
        Skater tmp;
        for (int i = 1; i < 5; i++)
        {
            for (int j = i; j > 0 && skaters[j].PlaceSum > skaters[j - 1].PlaceSum; j--)
            {
                tmp = skaters[j];
                skaters[j] = skaters[j - 1];
                skaters[j - 1] = tmp;
            }
        }
        if (choice == 1)
        {
            sport = new FigureSkating(skaters); //FigureSkating(skaters) - объект класса FigureSkating со входным параметром skaters
        }
        else if (choice == 2)
        {
            sport = new SpeedSkating(skaters);
        }
        else
        {
            Console.WriteLine("Некорректный ввод данных");
            sport = new FigureSkating(skaters);
        }
        sport.Namesport();
        sport.Skater();
        ISer2_9[] serialisers = new ISer2_9[1]
        {
            new JsonSer2_9()
        };
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path = Path.Combine(path, "Sample");
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        string[] files = new string[1]
        {
                    "task2_9.json"
        };
        for (int i = 0; i < serialisers.Length; i++)
        {
            serialisers[i].Write(skaters, Path.Combine(path, files[i]));
        }
        for (int i = 0; i < serialisers.Length; i++)
        {
            skaters = serialisers[i].Read<Skater[]>(Path.Combine(path, files[i]));
            for (int j = 0; j < 5; j++)
            {
                skaters[j].PrintResult();
            }
        }
    }
    class Skater //2 уровень 9 задача
    {
        private string _surname;
        private double[] _results;
        private double _placeSum;
        public string Surname { get { return _surname; } }
        public double PlaceSum { get { return _placeSum; } set { _placeSum = value; } }
        public double[] Results { get { return _results; } }
        public Skater(string surname, double[] results)
        {
            _surname = surname;
            _results = results;
            _placeSum = 0;
        }
        public void PrintResult(string text = "Некорректная информация")
        {
            if (_surname != null)
            {
                text = _surname + " " + _placeSum;
            }
            Console.WriteLine(text);
        }
    }
    abstract class winter_sports
    {
        protected string _namesport;
        protected Skater[] skater;
        public winter_sports(Skater[] skaters)
        {
            skater = skaters;
        }
        public void Namesport()
        {
            Console.WriteLine(_namesport);
        }
        public void Skater()
        {
            for (int i = 0; i < skater.Length; i++)
            {
                skater[i].PrintResult();
            }
        }
    }
    class FigureSkating : winter_sports
    {
        public FigureSkating(Skater[] skaters) : base(skaters)
        {
            _namesport = "Фигурное катание";
        }
    }
    class SpeedSkating : winter_sports
    {
        public SpeedSkating(Skater[] skaters) : base(skaters)
        {
            _namesport = "Конькобежный спорт";
        }
    }
}

