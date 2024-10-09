string hello = "We are the champions?";

int stringlength  = hello.Length;

hello = hello.Trim();

char firstletter = hello[0];
Console.WriteLine(firstletter);

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');

firstletter = hello[0]; 
Console.WriteLine(firstletter); 

Console.WriteLine(hello);

int wordcounter = 0;

for (int i = 0; i < hello.Length; i++)
{
    Console.WriteLine($"{i} symbol in string: {hello[i]}");
}

Console.WriteLine(stringlength);