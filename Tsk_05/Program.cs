// Cycles, dec to bin, dec to hex
Console.WriteLine("=Binary strings=");

void Example1(int numberIn){
    string numberOut = "";
    while(numberIn > 0){
        numberOut = Convert.ToString(numberIn % 2) + numberOut;
        numberIn /= 2;
    }
    Console.WriteLine(numberOut);
}


Example1(8);
Example1(9);
Example1(10);
Example1(15);

Console.WriteLine("===Binary int===");

void Example2(int numberIn){
    int numberOut = 0;
    int i = 1;
    while(numberIn > 0){
        numberOut = numberIn % 2 * i + numberOut;
        numberIn /= 2;
        i *= 10;
    }
    Console.WriteLine(numberOut);
}


Example2(8);
Example2(9);
Example2(10);
Example2(15);

Console.WriteLine("===Octal  int===");

void Example3(int numberIn){
    int numberOut = 0;
    int i = 1;
    while(numberIn > 0){
        numberOut = numberIn % 8 * i + numberOut;
        numberIn /= 8;
        i *= 10;
    }
    Console.WriteLine(numberOut);
}


Example3(18);
Example3(19);
Example3(110);
Example3(115);

Console.WriteLine("===Hex string===");

void Example4(int numberIn){
    string alphabet = "0123456789abcdef";
    string numberOut = "";
    while(numberIn > 0){
        numberOut = alphabet[numberIn % 16] + numberOut;
        numberIn /= 16;
    }
    Console.WriteLine(numberOut);
}


Example4(15);
Example4(16);
Example4(18);
Example4(110);
Example4(115);
Example4(65535);
Example4(65536);


