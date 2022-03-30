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
Console.Write("count from 0 to 5");

for (i = 0; i < 6; i ++) 
{
    Console.WriteLine(i);
}

// 1.b. TODO: Write a for loop to console.log the numbers from 3 to 5
//   - Which part of the example loop do you need to change to do this?
Console.WriteLine("count from 3 to 5");

for (i = 3; i < 6; i ++) 
{
    Console.WriteLine(i);
}

// 1.c. TODO: Write a for loop to console.log EVEN numbers from 2 to 10
//   - Which part of the example loop do you need to change to do this?
Console.WriteLine("count even numbers from 2 to 10 (2, 4, 6, 8, 10):");

for (i = 2; i < 11; i += 2) 
{
    Console.WriteLine(i);
}

// 1.d. (STRETCH) TODO: Write a for loop to do a counddown from 5 to 0
Console.WriteLine("STRETCH: countdown from 5 to 0");

for (i = 5; i >= 0; i --)
{
    Console.WriteLine(i);
}

// 2. For of loops
// console.log('---- 2. For Of loop ----');
// let stars = ['Polaris', 'Gacrux', 'Formalhaut', 'Rigel', 'Deneb'];

// 2.a. TODO: Write a for of loop to console.log each star in the 'stars' array
// console.log('Some stars:');

// let star=0;

// for (star of stars){
//   console.log(star);
// }

// 3. While loops
// console.log('---- 3. While loop ----');

// 3.a. TODO: Write a while loop to console.log each star in the 'stars' array
// console.log('Some stars using while:');

// i=0;
// let length= stars.length;

// while (i < length){
//   console.log(stars[i]);
//   i ++;
// }

// 3.b. TODO: Write a while loop to console.log the numbers from 0 to 5
// console.log('count from 0 to 5');

// i=0;
// const max=6;

// while (i < max){
//   console.log(i);
//   i ++;
// }

// 3.c. TODO: Write a while loop to console.log the numbers from 10 to 5
// console.log('count backwards from 10 to 5');

// i=10;
// const min=4;

// while (i > min){
//   console.log(i);
//   i --;
// }