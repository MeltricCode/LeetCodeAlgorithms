using EasyAlgorithms.Algorithm.PlusOne;

string result = "[";
foreach (var item in LastIndexPlusOne.PlusOne([9]))
{
    result += item + ",";
}
result = result.Remove(result.Length - 1);
result += ']';
Console.WriteLine(result);
