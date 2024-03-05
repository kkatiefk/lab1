List<string> listString = new List<string>()
{
    "Попрощалось ясне сонце",
    "З чорною землею.",
    "Виступає круглий мiсяць",
    "З сестрою зорею...",
    "I темний гайок зелененький,",
    "I мiсяць з зорями сiяв,",
    "I соловейко на калинi",
    "То затихав, то щебетав..."
};
listString.Sort((x, y) => x.Length.CompareTo(y.Length));

Console.WriteLine("Рядки по зростанню їх довжини:");
Console.WriteLine();
foreach (string str in listString)
{
    Console.WriteLine(str);
}

Console.ReadKey();
