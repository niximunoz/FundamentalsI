Console.WriteLine("**************FOR***********");
/*Create a Loop that prints all values from 1-255*/
Console.WriteLine("Create a Loop that prints all values from 1-255");
for(int i = 1; i <= 255; i++){
    Console.WriteLine(i);
}
Console.WriteLine("-------------------------------");
/*Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both*/
Console.WriteLine("Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both");
for(int j = 1; j <= 100; j++){
    bool divisible = (j % 3 == 0 || j % 5 == 0);
    bool divisibleAll = !(j % 3 == 0 && j % 5 == 0);

    if (divisible && divisibleAll){
        Console.WriteLine(j);
    }
}
Console.WriteLine("-------------------------------");
/*Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5*/
Console.WriteLine("print 'Fizz' for multiples of 3, 'Buzz' for multiples of 5, and 'FizzBuzz' for numbers that are multiples of both 3 and 5");
for(int k = 1; k <= 100; k++){
    if(k % 3 == 0 && k % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }else if(k % 3 == 0){
        Console.WriteLine("Fizz");
    }else if(k % 5 == 0){
        Console.WriteLine("Buzz");
    }
}
/*(Optional) If you used "for" loops for your solution, try doing the same with "while" loops. Vice-versa if you used "while" loops!*/
Console.WriteLine("**************WHILE***********");
/*Create a Loop that prints all values from 1-255*/
Console.WriteLine("Create a Loop that prints all values from 1-255");
int x = 1;
while( x <= 255 ){
    Console.WriteLine(x);
    x++;
}
Console.WriteLine("-------------------------------");
/*Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both*/
Console.WriteLine("Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both");
int y = 1;
while(y <= 100){
    bool divisible = (y % 3 == 0 || y % 5 == 0);
    bool divisibleAll = !(y % 3 == 0 && y % 5 == 0);
    if (divisible && divisibleAll){
        Console.WriteLine(y);
    }
    y++;
}
Console.WriteLine("-------------------------------");
/*Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5*/
Console.WriteLine("print 'Fizz' for multiples of 3, 'Buzz' for multiples of 5, and 'FizzBuzz' for numbers that are multiples of both 3 and 5");
int z = 1;
while(z <= 100){
    if(z % 3 == 0 && z % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }else if(z % 3 == 0){
        Console.WriteLine("Fizz");
    }else if(z % 5 == 0){
        Console.WriteLine("Buzz");
    }
    z++;
}


