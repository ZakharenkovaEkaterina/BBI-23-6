using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;

abstract class Task
{
    protected string text = "";
    protected string answer = "";
    public string Answer
    {
        get => answer;
        protected set => answer = value;
    }
    public string Text
    {
        get => text;
        protected set => text = value;
    }

    public virtual void ParseText() { }
    public Task(string text)
    {
        this.text = text;
    }
}
class Task1 : Task
{   
    [JsonConstructor]
    public Task1(string text) : base(text)
    {
        answer = "";
    }
    public override void ParseText()
    {
        string[] Words = text.Split(new char[] {'.', '!','?'}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < Words.Length; i++)

        {
            string[] words = Words[i].Split(new char[] { ' ', ';', ':', '(', ')', '"', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            answer += words[words.Length / 2] + "\n";
        }
    }

    public override string ToString()
    {
        ParseText();
        return answer.ToString();
    }
}
class Task2 : Task
{   
    [JsonConstructor]
    public Task2(string text) : base(text)
    {
        answer = "";
    }
    public override void ParseText()
    {
        text = text.ToLower();
        string shiftedText = ShiftLetters(text, -10);
        answer = shiftedText + answer + "\n";
    }
    static string ShiftLetters(string text, int shift)
    {
        const string alphabet = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
        StringBuilder result = new StringBuilder();
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'А' : 'а';
                int index = (c - baseChar + shift + alphabet.Length) % alphabet.Length;
                result.Append((char)(alphabet[index] + (char.IsUpper(c) ? 'А' - 'а' : (char)0)));
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
    public override string ToString()
    {
        ParseText();
        return answer.ToString();
    }
}
class JsonIO
{
    public static void Write<T>(T obj, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(fs, obj);
        }
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }
}
class Program
{
    static void Main()
    {
        string text = "Природа – удивительное явление, где каждый элемент совершенно на своем месте. Величественные горы, шумные реки, густые леса и цветущие поля создают неповторимую картину мира. Разнообразие живых существ, от маленьких насекомых до могучих хищников, обогащает экосистемы планеты. В природе царит гармония и баланс, который важно беречь и сохранять для будущих поколений.";
        Task[] tasks = {
            new Task1(text),
            new Task2(text)
        };
        Console.WriteLine(tasks[0]);
        Console.WriteLine(tasks[1]);

        string path = @"C:\Users\m2302741\downloads";
        string folderName = "Solution";
        path = Path.Combine(path, folderName);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string fileName1 = "cw2_1.json";
        string fileName2 = "cw2_2.json";

        fileName1 = Path.Combine(path, fileName1);
        fileName2 = Path.Combine(path, fileName2);
        if (!File.Exists(fileName1))
        {
            JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
        }
        else
        {
            var t1 = JsonIO.Read<Task1>(fileName1);
            Console.WriteLine(t1);
        }
        if (!File.Exists(fileName2))
        {
            JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
        }
        else
        {
            var t2 = JsonIO.Read<Task2>(fileName2);
            Console.WriteLine(t2);
        }

    }
}
  
