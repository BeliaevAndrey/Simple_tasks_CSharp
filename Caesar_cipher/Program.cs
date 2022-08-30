string alphabet = " abcdefghijklmnopqrstuvwxyz";
int shift = 10;

string phrase = "hello world";
// string phrase2 = "";
char[] tmp = new char[phrase.Length];
char[] phrase2 = new char[phrase.Length];

// There...
for(int i = 0; i < phrase.Length; i++)
{
    int ind = new int();
    for(int j = 0; j < alphabet.Length; j++)
    {
        if(phrase[i] == alphabet[j]) ind = (alphabet.Length + j + shift) % alphabet.Length;
    }
    tmp[i] = alphabet[ind];
}

Console.WriteLine(tmp);

// ...and back
for(int i = 0; i < phrase.Length; i++)
{
    int ind = new int();
    for(int j = 0; j < alphabet.Length; j++)
    {
        if(tmp[i] == alphabet[j]) ind = (j + alphabet.Length - shift) % alphabet.Length;
    }
    // tmp[i] = alphabet[ind];
    phrase2[i] = alphabet[ind];
}

Console.WriteLine(phrase2);
