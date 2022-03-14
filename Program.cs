string frase;
string palavracensurada = "$%@#@#&**$";

Console.Write("Digite uma frase: ");
frase = Console.ReadLine()!;

frase = frase
    .Replace("bobo", $"{palavracensurada}")
    .Replace("boba", $"{palavracensurada}")
    .Replace("feio", $"{palavracensurada}")
    .Replace("feia", $"{palavracensurada}")
    .Replace("inutil", $"{palavracensurada}")
    .Replace("chato", $"{palavracensurada}")
    .Replace("chata", $"{palavracensurada}")
    .Replace("estranho", $"{palavracensurada}")
    .Replace("estranha", $"{palavracensurada}")
    .Replace("besta", $"{palavracensurada}")
    .Replace("tonto", $"{palavracensurada}")
    .Replace("tonta", $"{palavracensurada}");

Console.Write($"\n{frase}");