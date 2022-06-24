// See https://aka.ms/new-console-template for more information

using System;

float functions(float pay) 
{
    float result = pay * 0.1f;
    return result;


}


Console.WriteLine($"the result is {functions(10f)}");


float calx(float amount) {

    float finaltax = amount * 0.1f;
    float final = finaltax + amount;
    return final;
}
Console.WriteLine($"the final result is {calx(100)}");






string str = "test";

for (int i = 0; i < str.Length; i++)
{
    Console.Write(str[i] + " ");
    
}
// Output: t e s t