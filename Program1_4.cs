using Lab9.Serializers;
using System;
using Microsoft.VisualBasic;
using System.Threading.Channels;
class Sportsmens //1 уровень 4 задача
{
    private string _surname;
    private double _results1;
    private double _results2;
    private double _bestresult;
    private bool _discvalifyed = false;
    public string Surname1 { get { return _surname; } }
    public double Results1 { get { return _results1; } }
    public double Results2 { get { return _results2; } }
    public double Bestresult { get { return _bestresult; } }
    public bool Discvalifyed { get { return _discvalifyed; } }

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
    public string surname { get { return _surname; } }
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
class Program1_4
{
    static void Main()
    {
        Sportsmens[] sportsmens = new Sportsmens[5];
        sportsmens[0] = new Sportsmens("Sidorov", 2, 4);
        sportsmens[1] = new Sportsmens("Morosov", 1, 3);
        sportsmens[2] = new Sportsmens("Kotikov", 5, 7);
        sportsmens[3] = new Sportsmens("Vasenin", 3, 3);
        sportsmens[4] = new Sportsmens("Galkin", 8, 6);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5 - 1; j++)
            {
                Sportsmens t;
                if (sportsmens[j].bestresult < sportsmens[j + 1].bestresult)
                {
                    t = sportsmens[j];
                    sportsmens[j] = sportsmens[j + 1];
                    sportsmens[j + 1] = t;
                }
            }
        }
        sportsmens[5 - 1].discvalifyed();
        for (int i = 0; i < 5; i++)
        {
            sportsmens[i].Print();
        }

        ISer1_4[] serialisers = new ISer1_4[1]
        {
            new JsonSer1_4()
        };
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path = Path.Combine(path, "Sample");
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

        string[] files = new string[1]
        {
            "task1_4.json"
        };
        for (int i = 0; i < serialisers.Length; i++)
        {
            serialisers[i].Write(sportsmens, Path.Combine(path, files[i]));
        }
        for (int i = 0; i < serialisers.Length; i++)
        {
            sportsmens = serialisers[i].Read<Sportsmens[]>(Path.Combine(path, files[i]));
            for (int j = 0; j < 5; j++)
            {
                sportsmens[j].Print();
            }
        }
    }
}