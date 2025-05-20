using EasyAlgorithms.Algorithm.PlusOne;

string result = "[";
foreach (var item in LastIndexPlusOne.PlusOne([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]))
{
    result += item + ",";
}
result = result.Remove(result.Length - 1);
result += ']';
Console.WriteLine(result);
