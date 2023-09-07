// 1 starts at 49
// A starts at 65
// Z starts at 90
// a starts at 97
// z starts at 123
// 9 starts at 57
// real chars start at 33 and end at 126

// All Useable Characters Password
var randChar = new Random();

var rnd = randChar.Next(8, 101);

Console.Write("New Password: ");

for (int i = 0; i <= rnd; i++)
{

    var rndChar = randChar.Next(33, 127);
        char chars = (char)rndChar;
        Console.Write((char)chars);
}


/*


//----------------------------


//Generates a New Random Password with Symbols excluding some
var randChar = new Random();

var rnd = randChar.Next(8, 101);

Console.Write("New Password: ");

for (int i  = 0; i <= rnd; i++)
{
    var rndChar = randChar.Next(49, 123);
    char chars = (char)rndChar;
    Console.Write((char)chars);
}


//-----------------------------



// Number and upper and Lower Case Letter Password
var randChar = new Random();

var rnd = randChar.Next(8, 101);

Console.Write("New Password: ");

for (int i = 0; i <= rnd; i++)
{

    var rndChar = randChar.Next(49, 123);
    if ((rndChar > 90 && rndChar < 97) || (rndChar > 57 && rndChar < 65 ))
    {
        i--;
    }
    else
    {
        char chars = (char)rndChar;
        Console.Write((char)chars);
    }
}


//-------------------------------------


// Just upper & lower case letter Password
var randChar = new Random();

var rnd = randChar.Next(8, 101);

Console.Write("New Password: ");

for (int i = 0; i <= rnd; i++)
{

    var rndChar = randChar.Next(65, 123);
    if(rndChar > 90 && rndChar < 97) {
        i--;
    }
    else { 
        char chars = (char)rndChar;
        Console.Write((char)chars);
    }
}

//---------------------------------------



var randChar = new Random();

var rnd = randChar.Next(8, 101);



for(int i = 33; i < 127; i++)
{
    int j = i;
Console.WriteLine((char)j);

}

*/