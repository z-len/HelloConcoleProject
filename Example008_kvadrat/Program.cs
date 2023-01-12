int xa = 10, ya = 1, 
    xb = 10, yb = 10,
    xc = 60, yc = 1,
    xd = 60, yd = 10;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = ya; 
int count = 0; 

while (count < 10000) 
{
    int what = new Random().Next(0, 4); 
     
    if(what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if(what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if(what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    if(what == 3)
    {
        x = (x + xd)/2;
        y = (y + yd)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++; 
}


