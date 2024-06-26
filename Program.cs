﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Windows.Input;
using lab9_защита.Serializers2;
class Program3_3
{
    static void Main()
    {
        Woman_Comand[] woman_Comand = new Woman_Comand[3];
        string[] shapeColor = new string[3];
        shapeColor[0] = new string("Blue");
        shapeColor[1] = new string("White");
        shapeColor[2] = new string("Black");
        double[] results = new double[6];
        results[0] = 1;
        results[1] = 2;
        results[2] = 3;
        results[3] = 4;
        results[4] = 5;
        results[5] = 6;
        woman_Comand[0] = new Woman_Comand("Zenit", results, shapeColor[0]);
        results[0] = 7;
        results[1] = 8;
        results[2] = 9;
        results[3] = 10;
        results[4] = 11;
        results[5] = 12;
        woman_Comand[1] = new Woman_Comand("CSKA", results, shapeColor[1]);
        results[0] = 13;
        results[1] = 14;
        results[2] = 15;
        results[3] = 16;
        results[4] = 17;
        results[5] = 18;
        woman_Comand[2] = new Woman_Comand("Sirens", results, shapeColor[2]);
        Random random = new Random();
        for (int i = 0; i < woman_Comand.Length; i++)
        {
            Console.WriteLine("Woman_Comand" + (i + 1));
            string[] names = new string[3];
            names[0] = new string("Zenit");
            names[1] = new string("CSKA");
            names[2] = new string("Sirens");
            Console.WriteLine("Places:");
        }
        Man_Comand[] man_Comand = new Man_Comand[3];
        string[] league = new string[3];
        league[0] = new string("Highest");
        league[1] = new string("Juniors");
        league[2] = new string("Amateurs");
        results[0] = 1;
        results[1] = 3;
        results[2] = 5;
        results[3] = 7;
        results[4] = 9;
        results[5] = 11;
        man_Comand[0] = new Man_Comand("Warriors", results, league[0]);
        results[0] = 2;
        results[1] = 13;
        results[2] = 18;
        results[3] = 8;
        results[4] = 10;
        results[5] = 12;
        man_Comand[1] = new Man_Comand("Winners", results, league[2]);
        results[0] = 4;
        results[1] = 15;
        results[2] = 14;
        results[3] = 16;
        results[4] = 17;
        results[5] = 6;
        man_Comand[2] = new Man_Comand("SKA", results, league[1]);
        for (int i = 0; i < man_Comand.Length; i++)
        {
            Console.WriteLine("Man_Comand" + (i + 1));
            string[] names1 = new string[3];
            names1[0] = new string("Warriors");
            names1[1] = new string("Winners");
            names1[2] = new string("SKA");
            Console.WriteLine("Places");
        }
        Comand[] comand = new Comand[woman_Comand.Length + man_Comand.Length];
        for (int i = 0; i < woman_Comand.Length; i++)
        {
            comand[i] = woman_Comand[i];
        }
        for (int i = 0; i < man_Comand.Length; i++)
        {
            comand[i + 3] = man_Comand[i];
        }
        for (int i = 0; i < comand.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (comand[j].count < comand[j + 1].count || (comand[j].count == comand[j + 1].count && comand[j].bestcomand < comand[j + 1].bestcomand))
                {
                    Comand t = comand[j];
                    comand[j] = comand[j + 1];
                    comand[j + 1] = t;
                }
            }
        }
        Console.Write("Победитель:");
        comand[0].Print();
        ISer3_3[] serialisers = new ISer3_3[1]
        {
            new JsonSer3_3()
        };
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path = Path.Combine(path, "Sample");
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        string[] files = new string[2]
        {
            "task3_3.json",
            "task3_3.Man.json"
        };
        for (int i = 0; i < serialisers.Length; i++)
        {
            serialisers[i].Write(woman_Comand, Path.Combine(path, files[0]));
        }
        for (int i = 0; i < serialisers.Length; i++)
        {
            woman_Comand = serialisers[i].Read<Woman_Comand[]>(Path.Combine(path, files[0]));
            Console.Write("Победитель:");
            woman_Comand[0].Print();
        }
        for (int i = 0; i < serialisers.Length; i++)
        {
            serialisers[i].Write(man_Comand, Path.Combine(path, files[1]));
        }
        for (int i = 0; i < serialisers.Length; i++)
        {
            man_Comand = serialisers[i].Read<Man_Comand[]>(Path.Combine(path, files[1]));
            man_Comand[0].Print();
        }
    }
}
class Comand //3 уровень 3 задача
{
    protected string _name;
    protected double[] _results = new double[6];
    protected int _count = 0; //баллы команд
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
    [JsonConstructor]
    public Comand(string name, double[] results, int count, int bestcomand)
    {
        this._name = name;
        this._results = results;
        this._count = count;
        this._bestcomand = bestcomand;
    }
    public string name { get { return _name; } }
    public double[] results { get { return _results; } }
    public int bestcomand { get { return _bestcomand; } }
    public int count { get { return _count; } }
    public virtual void Print(string text = "Некорректная информация")
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
    private string _shapeColor;
    public Woman_Comand(string name, double[] results) : base(name, results)
    {
        _name = name + " Woman";
    }
    [JsonConstructor]
    public Woman_Comand(string name, double[] results, string shapeColor) : base(name, results)
    {
        this._shapeColor = shapeColor;
        this._name = name + " Woman";
    }
    public string shapeColor { get { return _shapeColor; } }
    public override void Print(string text = "Некорректная информация")
    {
        if (_name != null)
        {
            text = _name + " " + _count + " " + _shapeColor;
        }
        Console.WriteLine(text);
    }
}
class Man_Comand : Comand
{
    private string _league;
    public Man_Comand(string name, double[] results) : base(name, results)
    {
        _name = name + " Man";
    }
    public string league { get { return _league; } }
    [JsonConstructor]
    public Man_Comand(string name, double[] results, string league) : base(name, results)
    {
        this._league = league;
        this._name = name + " Man";
    }
    public override void Print(string text = "Некорректная информация")
    {
        if (_name != null)
        {
            text = _name + " " + _count + " " + _league;
        }
        Console.WriteLine(text);
    }
}
