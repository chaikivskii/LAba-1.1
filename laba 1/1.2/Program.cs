List<string> inputList = new List<string>() { "ab", "bc", "cb", "sf"};
List<string> resultList = new List<string>();

for (int i = 0; i < inputList.Count; i++)
{
    string previousElements = string.Join(" ", inputList.Take(i));
    resultList.Add($"{inputList[i]} {previousElements}");
}

foreach (string item in resultList)
{
    Console.WriteLine(item);
}