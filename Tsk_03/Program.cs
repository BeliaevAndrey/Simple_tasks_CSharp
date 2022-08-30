// Caesar cipher decode
string alphabet = " abcdefghijklmnopqrstuvwxyz";    // leading space symbol is important!
int shift = 10;

string phraseIn = "rovvyjfyavn";
char[] phraseOut = new char[phraseIn.Length];

for(int i = 0; i < phraseIn.Length; i++)
{
    int ind = new int();
    for(int j = 0; j < alphabet.Length; j++)
    {
        if(phraseIn[i] == alphabet[j]) ind = (j + alphabet.Length - shift) % alphabet.Length;
    }
    phraseOut[i] = alphabet[ind];
}

Console.WriteLine(phraseOut);
