Console.WriteLine("Введите текст");
string [] array = new string [3];
for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
Console.WriteLine($"{string.Join(", ", array)}");
int count = 0;
for(int i = 0; i < array.Length; i++)
    {
        string s = array[i];
        if (s.Length < 4)
        {
            count++;
            Console.Write($"{s} ");
        }
    }
if (count == 0);
{
    Console.WriteLine("null");
}