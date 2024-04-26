using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
    public Task_1(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        Dictionary<char, double> Russian = new Dictionary<char, double>();
        for (char i = 'а'; i <= 'я'; i++)
        {
            Russian[i] = 0;
        }
        text = text.ToLower(); //приводим текст к нижнему регистру
        double sum = 0;
        foreach (char symbol in text)
        {
            if (char.IsLetter(symbol))
            {
                sum++;
                Russian[symbol]++;
            }
        }
        for (char i = 'а'; i <= 'я'; i++)
        {
            Russian[i] = CountPersent(Russian[i], sum);
        }
        foreach (var i in Russian)
        {
            print += i.Key + " " + i.Value + "\n";
        }
    }
}
class Task_3 : Task
{
    public Task_3(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        List<string> list = new List<string>(); //список строк не длиннее 50 символов
        string[] Words = text.Split(); //метод для того, чтобы разделить строку на несколько частей (массив частей)
        string this_line = "";
        int length_line = 0;
        foreach (string word in Words)
        {
            if (length_line + word.Length > 50)
            {
                list.Add(this_line); //добавляем текущую строку в список
                this_line = "";
                length_line = 0;
            }
            this_line += word + " ";
            length_line += word.Length + 1;
        }
        list.Add(this_line);
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].Remove(list[i].Length - 1); //удаляем пробел в конце каждой строки
            print += list[i] + "\n";
        }
    }
}
class Task_5 : Task
{
    public Task_5(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        text = text.ToLower();
        Dictionary<char, double> Russian = new Dictionary<char, double>();
        string[] words = text.Split(new char[] { ' ', ',', ';', '.', '!', '?', ':', '(', ')', '"' });
        char first_letter;
        foreach (string word in words)
        {
            if (word.Length > 0 && char.IsLetter(word[0]))
            {
                first_letter = word[0];
                if (!Russian.ContainsKey(first_letter))
                {
                    Russian[first_letter] = 0;
                }
                Russian[first_letter]++;
            }
        }
        List<KeyValuePair<char, double>> list = new List<KeyValuePair<char, double>>(Russian);
        Sort(list);
        foreach (KeyValuePair<char, double> pair in list)
        {
            print += pair.Key + " " + pair.Value + "\n";
        }
    }
    static void Sort(List<KeyValuePair<char, double>> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = 0; j < list.Count - 1; j++)
            {
                if (list[j].Value < list[j + 1].Value)
                {
                    KeyValuePair<char, double> t = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = t;
                }
            }
        }
    }
}
class Task_7 : Task
{
    private string request;
    public Task_7(string text) : base(text)
    {
        Console.WriteLine("Введите свой запрос:");
        request = Console.ReadLine();
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        string[] Words = text.Split(new char[] { ' ', ',', ';', '.', '!', '?', ':', '(', ')', '"' });
        foreach (string word in Words)
        {
            if (word.Contains(request))
            {
                print += word + "\n";
            }
        }
        if (print == "")
        {
            print = "Не найден результат по запросу";
        }
    }
}
class Task_11 : Task
{
    public Task_11(string text) : base(text)
    {
        ParseText(text);
    }
    protected override void ParseText(string text)
    {
        string[] Words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries - убрать пустые подстроки из результата
        Sort(Words);
        foreach (string i in Words)
        {
            print += i + "\n";
        }
    }
    static bool CheckOrder(string name1, string name2)
    {
        int length = Math.Min(name1.Length, name2.Length);
        int index = 0;
        while (index < length && name1[index] == name2[index])
        {
            index++;
        }
        if (index == length)
        {
            if (name1.Length > name2.Length)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            if (name1[index] > name2[index])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    static void Sort(string[] Words)
    {
        for (int i = 1; i < Words.Length; i++)
        {
            string val = Words[i];
            for (int j = i - 1; j >= 0;)
            {
                if (CheckOrder(val, Words[j])) //смотрим в правильном ли порядке стоят два слова и меням их
                {
                    Words[j + 1] = Words[j];
                    Words[j] = val;
                    j--;
                }
                else break;
            }
        }
    }
}
class Task_14 : Task
{
    private int sum = 0;
    public Task_14(string text) : base(text)
    {
        ParseText(text);
        print = sum + "";
    }
    protected override void ParseText(string text)
    {
        string[] Words = text.Split();
        foreach (string word in Words)
        {
            string line = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    line += word[i];
                }
                else if (line != "")
                {
                    sum += int.Parse(line);
                    line = "";
                }
            }
            if (line != "") // если число стоит в конце слова, то else if не сработает и для этого мы дублируем его
            {
                sum += int.Parse(line);
            }
        }
    }

}
class Program
{
    public static void Main()
    {
        //Task_1 task1 = new Task_1("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений.");
        //Console.WriteLine(task1);
        //Task_3 task3 = new Task_3("Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
        //Console.WriteLine(task3);
        //Task_5 task5 = new Task_5("1 июля 2015 года Греция объявила о дефолте по государственному долгу, став первой развитой страной в истории, которая не смогла выплатить свои долговые обязательства в полном объеме. Сумма дефолта составила порядка 1,6 миллиарда евро. Этому предшествовали долгие переговоры с международными кредиторами, такими как Международный валютный фонд (МВФ), Европейский центральный банк (ЕЦБ) и Европейская комиссия (ЕК), о программах финансовой помощи и реструктуризации долга. Основными причинами дефолта стали недостаточная эффективность реформ, направленных на улучшение финансовой стабильности страны, а также политическая нестабильность, что вызвало потерю доверия со стороны международных инвесторов и кредиторов. Последствия дефолта оказались глубокими и долгосрочными: сокращение кредитного рейтинга страны, увеличение затрат на заемный капитал, рост стоимости заимствований и утрата доверия со стороны международных инвесторов.");
        //Console.WriteLine(task5);
        //Task_7 task7 = new Task_7("Фьорды – это ущелья, формирующиеся ледниками и заполняющиеся морской водой. Название происходит от древнескандинавского слова \"fjǫrðr\". Эти глубокие заливы, окруженные высокими горами, представляют захватывающие виды и природную красоту. Они популярны среди туристов и известны под разными названиями: в Норвегии – \"фьорды\", в Шотландии – \"фьордс\", в Исландии – \"фьордар\". Фьорды играют важную роль в культуре и туризме региона, продолжая вдохновлять людей со всего мира.");
        //Console.WriteLine(task7);
        //Task_11 task11 = new Task_11("Иванов, Петров, Смирнов, Соколов, Кузнецов, Попов, Лебедев, Волков, Козлов, Новиков, Иванова, Петрова, Смирнова, Ivanov, Petrov,Smirnov,Sokolov,Kuznetsov,Popov,Lebedev,Volkov,Kozlov,Novikov,Ivanova,Petrova,Smirnova");
        //Console.WriteLine(task11);
        Task_14 task14 = new Task_14("William Shakespeare, widely regarded as one of the greatest writers in the English language, authored a total of 37 plays, along with numerous poems and sonnets. He was born in Stratford-upon-Avon, England, in 1564, and died in 1616. Shakespeare's most famous works, including \"Romeo and Juliet,\" \"Hamlet,\" \"Macbeth,\" and \"Othello,\" were written during the late 16th and early 17th centuries. \"Romeo and Juliet,\" a tragic tale of young love, was penned around 1595. \"Hamlet,\" one of his most celebrated tragedies, was written in the early 1600s, followed by \"Macbeth,\" a gripping drama exploring themes of ambition and power, around 1606. \"Othello,\" a tragedy revolving around jealousy and deceit, was also composed during this period, believed to be around 1603.");
        Console.WriteLine(task14);
    }
}
