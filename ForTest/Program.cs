﻿
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {

    }
}
/*Very simple, given a number (integer / decimal / both depending on the language), find its opposite (additive inverse).

Examples:

1: -1
14: -14
-34: 34*/

public class KataOposite
{
    public static int Opposite(int number)
    {
        return -number;
    }
}


/*Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).

If they are, change the array value to a string of that vowel.

Return the resulting array.*/
public class KataISVow
{
    public static object[] IsVow(object[] a)
    {

        int[] vowelCodes = { 97, 101, 105, 111, 117 };


        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] is int && Array.Exists(vowelCodes, code => code == (int)a[i]))
            {
                a[i] = ((char)(int)a[i]).ToString();
            }
        }


        return a;

        //return a.Select(x => "aeiou".Contains(Convert.ToChar(x)) ? Convert.ToChar(x).ToString() : x).ToArray();

    }
}

/*You're on your way to the market when you hear beautiful music coming from a nearby street performer. The notes come together like you wouln't believe as the musician puts together patterns of tunes. As you wonder what kind of algorithm you could use to shift octaves by 8 pitches or something silly like that, it dawns on you that you have been watching the musician for some 10 odd minutes. You ask, "how much do people normally tip for something like this?" The artist looks up. "It's always gonna be about tree fiddy."

It was then that you realize the musician was a 400 foot tall beast from the paleolithic era! The Loch Ness Monster almost tricked you!

There are only 2 guaranteed ways to tell if you are speaking to The Loch Ness Monster: A) it is a 400 foot tall beast from the paleolithic era; B) it will ask you for tree fiddy.

Since Nessie is a master of disguise, the only way accurately tell is to look for the phrase "tree fiddy". Since you are tired of being grifted by this monster, the time has come to code a solution for finding The Loch Ness Monster. Note that the phrase can also be written as "3.50" or "three fifty". Your function should return true if you're talking with The Loch Ness Moster, false otherwise.*/
public static class KataIsLockNessMonster
{
    public static bool IsLockNessMonster(string sentence)
    {
        string lowerCaseSentence = sentence.ToLower();
        return lowerCaseSentence switch
        {
            var s when s.Contains("tree fiddy") => true,
            var s when s.Contains("3.50") => true,
            var s when s.Contains("three fifty") => true,
            _ => false
        };
    }
}


/*Write a method that takes one argument as name and then greets that name, capitalized and ends with an exclamation point.

Example:

"riley" --> "Hello Riley!"
"JACK"  --> "Hello Jack!"*/

public static class KataGreet
{
    public static string Greet(string name)
    {
        return "Hello " + name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower() + "!";
    }
}


/*Exclusive "or" (xor) Logical Operator
Overview
In some scripting languages like PHP, there exists a logical operator (e.g. &&, ||, and, or, etc.) called the "Exclusive Or" (hence the name of this Kata). The exclusive or evaluates two booleans. It then returns true if exactly one of the two expressions are true, false otherwise. For example:

false xor false == false // since both are false
true xor false == true // exactly one of the two expressions are true
false xor true == true // exactly one of the two expressions are true
true xor true == false // Both are true.  "xor" only returns true if EXACTLY one of the two expressions evaluate to true.
Task
Since we cannot define keywords in Javascript (well, at least I don't know how to do it), your task is to define a function xor(a, b) where a and b are the two expressions to be evaluated. Your xor function should have the behaviour described above, returning true if exactly one of the two expressions evaluate to true, false otherwise.

*/

public class KataXOR
{
    public static bool Xor(bool a, bool b)
    {
        return (a && !b) || (!a && b);
    }
}


/*Complete the function power_of_two/powerOfTwo (or equivalent, depending on your language) that determines if a given non-negative integer is a power of two. From the corresponding Wikipedia entry:

a power of two is a number of the form 2n where n is an integer, i.e. the result of exponentiation with number two as the base and integer n as the exponent.

You may assume the input is always valid.

Examples
power_of_two?(1024) # true
power_of_two?(4096) # true
power_of_two?(333)  # false
Beware of certain edge cases - for example, 1 is a power of 2 since 2^0 = 1 and 0 is not a power of 2.*/

public static class KataPowerOfTwo
{
    public static bool PowerOfTwo(int number)
    {
        if (number <= 0)
        {
            return false;
        }
        while (number > 1)
        {
            if (number % 2 != 0)
            {
                return false;
            }
            number /= 2;
        }

        return true;

    }
    //public static bool PowerOfTwo(int n) => new BigInteger(n).IsPowerOfTwo; !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
}

/*Task
Given an array of integers , Find the minimum sum which is obtained from summing each Two integers product .

Notes
Array/list will contain positives only .
Array/list will always have even size
Input >> Output Examples
minSum({5,4,2,3}) ==> return (22) */

class KataMinSum
{
    public static int MinSum(int[] a)
    {

        Array.Sort(a);

        int minSum = 0;
        for (int i = 0, j = a.Length - 1; i < j; i++, j--)
        {
            minSum += a[i] * a[j];
        }

        return minSum;
    }
}

/*Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

Use conditionals to return the proper message:

case	return
name equals owner	'Hello boss'
otherwise	'Hello guest'*/

public class KataGreetIsGood
{
    public static string Greet(string name, string owner)
    {
        return (name == owner) ? "Hello boss" : "Hello guest";
    }
}

/*Remove all exclamation marks from the end of sentence.

Examples
"Hi!"     ---> "Hi"
"Hi!!!"   ---> "Hi"
"!Hi"     ---> "!Hi"
"!Hi!"    ---> "!Hi"
"Hi! Hi!" ---> "Hi! Hi"
"Hi"      ---> "Hi"*/

public class KataRemove
{
    public static string Remove(string s)
    {
        return Regex.Replace(s, "!+$", "");
    }
}

/*Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').

Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').

Create a function which translates a given DNA string into RNA.

For example:

"GCAT"  =>  "GCAU"
The input string can be of arbitrary length - in particular, it may be empty. All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.*/
public class Converter
{
    public string dnaToRna(string dna)
    {
        return dna.Replace('T', 'U');
    }
}

/*Given an array of integers , Find the maximum product obtained from multiplying 2 adjacent numbers in the array.

Notes
Array/list size is at least 2.
Array/list numbers could be a mixture of positives, negatives also zeroes .
Input >> Output Examples
adjacentElementsProduct([1, 2, 3]); ==> return 6
Explanation:
The maximum product obtained from multiplying 2 * 3 = 6, and they're adjacent numbers in the array.adjacentElementsProduct([9, 5, 10, 2, 24, -1, -48]); ==> return 50
Explanation:
Max product obtained from multiplying 5 * 10  =  50 .
adjacentElementsProduct([-23, 4, -5, 99, -27, 329, -2, 7, -921])  ==>  return -14
Explanation:
The maximum product obtained from multiplying -2 * 7 = -14, and they're adjacent numbers in the array.

 public static int AdjacentElementsProduct(int[] array)*/

public class KataAdjacentElementsProduct
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int maxProduct = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            int product = array[i] * array[i + 1];
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }

        return maxProduct;

    }
    // return array.Skip(1).Select((x,i) => x * array[i]).Max();
}