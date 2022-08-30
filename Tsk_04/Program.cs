void Example1()
{
    int[,,] block1 = new int[10, 9, 8];

    Console.WriteLine($"a: {block1.GetLength(0)}, b: {block1.GetLength(1)}, c: {block1.GetLength(2)}");
}

void Example2()
{
    int[,,] block2 = {{
                    {1, 2, 3, 4, 5}, {1, 2, 3, 4, 5}, {1, 2, 3, 4, 5}, 
                    {6, 7, 8, 9, 10}, {6, 7, 8, 9, 10}, 
                    {11, 12, 13, 14, 15}
                    },
                    {
                    {1, 2, 3, 4, 5}, {1, 2, 3, 4, 5}, 
                    {1, 2, 3, 4, 5}, {6, 7, 8, 9, 10}, {6, 7, 8, 9, 10}, 
                    {11, 12, 13, 14, 15}
                    }
                    };

    Console.WriteLine($"x: {block2.GetLength(2)}, y: {block2.GetLength(1)}, z: {block2.GetLength(0)}");
}
void Example3()
{
    int[,,] Fill(){
        int x = 105;
        int[,,] mtrx = new int[7, 3, 5];
        for(int i=0; i < mtrx.GetLength(0); i++){
            for(int j=0; j < mtrx.GetLength(1); j++){
                for(int k=0; k < mtrx.GetLength(2); k++){
                    mtrx[i, j, k] = x;
                    x--;
                }
            }
        }
        return mtrx;
    }
    Console.WriteLine($"{Fill()[1, 1, 1]}");
    Console.WriteLine($"{Fill()[0, 0, 0]}");
}

Example1();
Example2();
Example3();
