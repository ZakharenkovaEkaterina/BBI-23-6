using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;
abstract class Task
{
    protected string print = "";
    public Task(string text)
    {
    }
    public override string ToString()
    {
        return print;

    }
    protected abstract void ParseText(string text); // все разные
    protected virtual int Count() // если несколько одинаковых, а один выбивается
    {
        return -1;
    }
    protected double CountPersent(double number, double total) // все одинаковые
    {
        return Math.Round(number / total * 100, 2);
    }
}
class Task_1 : Task
{
    private double sum;
    public Task_1(string text) : base(text)
    {
        ParseText(text);
    }
    struct Dictionary
    {
        private char _letter;
        private double _number;
        public Dictionary (char letter)
        {
            _letter = letter;
            _number = 0;
        }
        public void Increment()
        {
            _number++;
        }

        public double GetFrequency(double total, double _number)
        {
            return Math.Round((_number / total * 100), 2);
        }
        public string ToString22(double sum)
        {
            return $"{_letter} {GetFrequency(sum, _number)}\n";
        }
    }
    protected override void ParseText(string text)
    {
        Dictionary[] Russian = new Dictionary['я' - 'а' + 1];
        for (char i = 'а'; i <= 'я'; i++)
        {
            Russian[i - 'а'] = new Dictionary(i);
        }
        text = text.ToLower(); //приводим текст к нижнему регистру
        sum = 0;
        foreach (char symbol in text)
        {
            if (char.IsLetter(symbol))
            {
                sum++;
                Russian[symbol-'а'].Increment();
            }
        }
        foreach (var i in Russian)
        {
            print += i.ToString22(sum);
        }
    }
}
class Program
{
    public static void Main()
    {
        Task_1 task1 = new Task_1("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.");
        Console.WriteLine(task1);
}
}