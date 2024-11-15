var range = 250;
var counts = new int[range];
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text.ToLower() ?? string.Empty)
    {
        counts[(int)character]++;
    }

    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            double count = (double)counts[i];
            double percent = count / text.Length * 100;
            var character = (char)i;

            Console.WriteLine(character + " - " + counts[i]);
            Console.WriteLine($"{percent}%");
        }
    }
}