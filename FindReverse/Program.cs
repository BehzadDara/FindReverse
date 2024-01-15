
List<string> list = ["test", "salam", "bye", "malas", "rx", "xr", "tssst", "tset", "brb"];

var result = FindNumberOfReverseStrings(list);

Console.WriteLine(result);

static int FindNumberOfReverseStrings(List<string> list)
{
    var result = 0;
    var hashmap = new Dictionary<string, bool>();

    foreach (var item in list)
    {
        if (hashmap.ContainsKey(item))
        {
            result++;
            hashmap[item] = true;
        }
        else
        {
            hashmap[Reverse(item)] = false;
        }
    }

    return result;
}

static string Reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}