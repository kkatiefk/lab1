//Дано ціле число L (> 0) і строкова послідовність A. 
//Рядки послідовності A містять лише великі літери латинського алфавіту. 
//Серед всіх рядків з A, які мають довжину L, знайти найбільшу (в сенсі лексикографічного порядку). 
//Вивести цей рядок або порожній рядок, якщо послідовність не містить рядків довжини L. (1)
//-First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault (поелементні операції)
//- Count, Sum, Average, Max, Min, Aggregate (агрегування); • Range(генерування послідовностей).

int L = 5; 
string[] A = { "ZXJEH", "QLMOV", "ОNWIE" }; 

var result = A.Where(i => i.Length == L).OrderByDescending(i => i).FirstOrDefault();

Console.WriteLine(result ?? string.Empty);

Console.ReadKey();