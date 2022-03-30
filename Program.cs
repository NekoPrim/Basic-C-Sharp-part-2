Console.WriteLine("****** Loops Practice *******");


// 1. 'for' loop
Console.WriteLine("---- 1. For loops ----");
// Example: a for loop to console.log numbers from 0 to 3
Console.WriteLine("count from 0 to 3");
// start i at 0, while i is < 4 do code between {}, afterwards add 1 to i (i++)
for (int i = 0; i < 4; i ++) 
{
    Console.WriteLine(i);
}

// 1.a. TODO: Write a for loop to console.log the numbers from 0 to 5
//   - Which part of the example loop do you need to change to do this?
Console.Write("count from 0 to 5.");

for (int i = 0; i < 6; i ++) 
{
    Console.WriteLine(i);
}

// 1.b. TODO: Write a for loop to console.log the numbers from 3 to 5
//   - Which part of the example loop do you need to change to do this?
Console.WriteLine("count from 3 to 5");

for (int i = 3; i < 6; i ++) 
{
    Console.WriteLine(i);
}

// 1.c. TODO: Write a for loop to console.log EVEN numbers from 2 to 10
//   - Which part of the example loop do you need to change to do this?
Console.WriteLine("count even numbers from 2 to 10 (2, 4, 6, 8, 10):");

for (int i = 2; i < 11; i += 2) 
{
    Console.WriteLine(i);
}

// 1.d. (STRETCH) TODO: Write a for loop to do a counddown from 5 to 0
Console.WriteLine("STRETCH: countdown from 5 to 0");

for (int i = 5; i >= 0; i --)
{
    Console.WriteLine(i);
}

// 2. For of loops
Console.WriteLine("---- 2. For Of loop ----");
string[] stars = 
{
    "Polaris", 
    "Gacrux", 
    "Formalhaut", 
    "Rigel", 
    "Deneb"
};

// 2.a. TODO: Write a foreach loop to console.log each star in the 'stars' array
Console.WriteLine("Some stars:");

foreach (string star in stars)
{
    Console.WriteLine(star);
}

// 3. While loops
Console.WriteLine("---- 3. While loop ----");

// 3.a. TODO: Write a while loop to console.log each star in the 'stars' array
Console.WriteLine("Some stars using while:");

int x = 0;

while (x < stars.Length)
{
    Console.WriteLine(stars[x]);
    x ++;
}

// 3.b. TODO: Write a while loop to console.log the numbers from 0 to 5
Console.WriteLine("count from 0 to 5");

int y = 0;

while (y < 6)
{
    Console.WriteLine(y);
    y ++;
}

// 3.c. TODO: Write a while loop to console.log the numbers from 10 to 5
Console.WriteLine("count backwards from 10 to 5");

int z = 10;

while (z > 5)
{
    Console.WriteLine(z);
    z --;
}