using System;
class Sportsmens //1 уровень 4 задача
{
    private string _surname;
    private double _results1;
    private double _results2;
    private double _bestresult;
    private bool _discvalifyed = false;
    public Sportsmens(string surname, double results1, double results2)
    {
        _surname = surname;
        _results1 = results1;
        _results2 = results2;
        if (_results1 >= _results2)
        {
            _bestresult = _results1;
        }
        else
        {
            _bestresult = _results2;
        }
    }
    public double bestresult { get { return _bestresult; } }
    public void Print(string text = "Информация некоректна")
    {
        if (_surname != null && _bestresult > 0)
        {
            text = _surname + " " + _bestresult;

        }
        if (!_discvalifyed)
        {
            Console.WriteLine(text);
        }
    }
    public void discvalifyed()
    {
        _discvalifyed = true;
    }
}
class Program
{
    static void Main()
    {
        #region 1.4
        //Console.WriteLine("Введите количество спортсменов:");
        //int n = int.Parse(Console.ReadLine());
        //Sportsmens[] sportsmens = new Sportsmens[n];
        //string s;
        //double r1, r2;
        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Введите фамилию:");
        //    s = Console.ReadLine();
        //    Console.WriteLine("Введите r1:");
        //    r1 = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Введите r2:");
        //    r2 = double.Parse(Console.ReadLine());
        //    sportsmens[i] = new Sportsmens(s, r1, r2);
        //    Console.WriteLine();
        //}
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n - 1; j++)
        //    {
        //        Sportsmens t;
        //        if (sportsmens[j].bestresult < sportsmens[j + 1].bestresult)
        //        {
        //            t = sportsmens[j];
        //            sportsmens[j] = sportsmens[j + 1];
        //            sportsmens[j + 1] = t;
        //        }
        //    }
        //}
        //sportsmens[n - 1].discvalifyed();
        //for (int i = 0; i < n; i++)
        //{
        //    sportsmens[i].Print();
        //}
        #endregion
        #region 2.9
        //Console.WriteLine("Выберите вид зимнего спорта: 1 - Фигурное катание, 2 - Конькобежный спорт");
        //int choice = int.Parse(Console.ReadLine());
        //winter_sports sport;
        //Console.Write("Введите количество участников: ");
        //int number = int.Parse(Console.ReadLine());
        //Skater[] skaters = new Skater[number];
        //string surname;
        //double[] results;
        //double res;
        //Console.WriteLine();
        //for (int i = 0; i < number; i++)
        //{
        //    Console.WriteLine("Участник " + (i + 1));
        //    Console.Write("Фамилия: ");
        //    surname = Console.ReadLine();
        //    Console.WriteLine("Оценки судей:");
        //    results = new double[7];
        //    for (int j = 0; j < 7; j++)
        //    {
        //        Console.Write((j + 1) + " - ");
        //        res = double.Parse(Console.ReadLine());
        //        while (res < 0 || res > 6)
        //        {
        //            Console.WriteLine("Некрорректное значение");
        //            Console.Write((j + 1) + " - ");
        //            res = double.Parse(Console.ReadLine());
        //        }
        //        results[j] = res;
        //    }
        //    skaters[i] = new Skater(surname, results);
        //    Console.WriteLine();
        //}

        //for (int i = 0; i < number; i++)
        //{
        //    double placeSum = 0;
        //    for (int j = 0; j < 7; j++)
        //    {
        //        double place = 1;
        //        for (int k = 0; k < number; k++)
        //        {
        //            if (k != i && skaters[i].Results[j] > skaters[k].Results[j])
        //            {
        //                place++;
        //            }
        //        }
        //        placeSum += place;
        //    }
        //    skaters[i].PlaceSum = placeSum;
        //}
        //Skater tmp;
        //for (int i = 1; i < number; i++)
        //{
        //    for (int j = i; j > 0 && skaters[j].PlaceSum > skaters[j - 1].PlaceSum; j--)
        //    {
        //        tmp = skaters[j];
        //        skaters[j] = skaters[j - 1];
        //        skaters[j - 1] = tmp;
        //    }
        //}
        //if (choice == 1)
        //{
        //    sport = new FigureSkating(skaters); //FigureSkating(skaters) - объект класса FigureSkating со входным параметром skaters
        //}
        //else if (choice == 2)
        //{
        //    sport = new SpeedSkating(skaters);
        //}
        //else
        //{
        //    Console.WriteLine("Некорректный ввод данных");
        //    sport = new FigureSkating(skaters);
        //}
        //sport.Namesport();
        //sport.Skater();
        #endregion
        #region 3.3
        //Woman_Comand[] woman_Comand = new Woman_Comand[3];
        //double[] results = new double[6];
        //string name;
        //for (int i = 0; i < woman_Comand.Length; i++)
        //{
        //    Console.WriteLine("Введите название женских команд:");
        //    name = Console.ReadLine();
        //    Console.WriteLine("Введите места участников команды:");
        //    for (int j = 0; j < 6; j++)
        //    {
        //        results[j] = double.Parse(Console.ReadLine());
        //    }
        //    woman_Comand[i] = new Woman_Comand(name, results);
        //}
        //Man_Comand[] man_Comand = new Man_Comand[3];
        //string name1;
        //for (int i = 0; i < man_Comand.Length; i++)
        //{
        //    Console.WriteLine("Введите название мужских команд:");
        //    name1 = Console.ReadLine();
        //    Console.WriteLine("Введите места участников команды:");
        //    for (int j = 0; j < 6; j++)
        //    {
        //        results[j] = double.Parse(Console.ReadLine());
        //    }
        //    man_Comand[i] = new Man_Comand(name1, results);
        //}
        //Comand[] comand = new Comand[woman_Comand.Length + man_Comand.Length];
        //for (int i=0; i < woman_Comand.Length;i++)
        //{
        //    comand[i] = woman_Comand[i];
        //}
        //for (int i=0; i < man_Comand.Length; i++)
        //{
        //    comand[i+3] = man_Comand[i];
        //}
        //for (int i = 0; i < comand.Length; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (comand[j].count < comand[j + 1].count || (comand[j].count == comand[j + 1].count && comand[j].bestcomand < comand[j + 1].bestcomand))
        //        {
        //            Comand t = comand[j];
        //            comand[j] = comand[j + 1];
        //            comand[j + 1] = t;
        //        }
        //    }
        //}
        //Console.Write("Победитель:");
        //    comand[0].Print();
        #endregion
        Console.ReadKey();
    }

    class Skater //2 уровень 9 задача
    {
        private string _surname;
        private double[] _results;
        private double _placeSum;
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
class Comand //3 уровень 3 задача
{
    protected string _name;
    private double[] _results = new double[6];
    private int _count = 0; //баллы команд
    private int _bestcomand = 0;
    public Comand(string name, double[] results)
    {
        _name = name;
        _results = results;
        for (int i = 0; i < _results.Length; i++)
        {
            for (int j = 1; j <= 5; j++)
            {
                if (results[i] == j)
                {
                    _count += 6 - j; //присвоение баллов умом
                }
            }
            if (results[i] == 1)
            {
                _bestcomand = 1;
            }
        }
    }
    public int bestcomand { get { return _bestcomand; } }
    public int count { get { return _count; } }
    public void Print(string text = "Некорректная информация")
    {
        if (_name != null)
        {
            text = _name + " " + _count;
        }
        Console.WriteLine(text);
    }
}
class Woman_Comand : Comand
{
    public Woman_Comand(string name, double[] results) : base(name, results)
    {
        _name = name + " Женская";
    }
}
class Man_Comand : Comand
{
    public Man_Comand(string name, double[] results) : base(name, results)
    {
        _name = name + " Мужская";
    }
}

