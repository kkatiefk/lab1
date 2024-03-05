//Об’єднати два словники, додаючи значення для спільних ключів. 
//d1 = {'a': 1, 'b': 2, 'c':3} d2 = { 'a': 3, 'b': 2, 'd':4}. 
//Вихідний результат:{ 'a': 4, 'b': 4, 'd': 4, 'c': 3}

using Newtonsoft.Json;

Dictionary<string, int> d1 = new Dictionary<string, int>
{
   { "a", 1 },
   { "b", 2 },
   { "c", 3 }
};

Dictionary<string, int> d2 = new Dictionary<string, int>
{
   { "a", 3 },
   { "b", 2 },
   { "d", 4 }
};

foreach (var kvp in d2)
{
    if (d1.ContainsKey(kvp.Key))
    {
        // Якщо ключ існує, додаємо значення з d2 до значення в d1 за відповідним ключем
        d1[kvp.Key] += kvp.Value;
    }
    else
    {
        // Якщо ключ не існує, просто додаємо пару ключ-значення з d2 в d1
        d1.Add(kvp.Key, kvp.Value);
    }
}

string s = JsonConvert.SerializeObject(d1);
Console.WriteLine(s);

Console.ReadKey();