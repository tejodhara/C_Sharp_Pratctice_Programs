// C# Program 1: Hello World
using System;
class Program1 {
    static void Main() {
        Console.WriteLine("Hello, World!");
    }
}

// C# Program 2: Print numbers from 1 to 10
class Program2 {
    static void Main() {
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(i);
        }
    }
}

// C# Program 3: Sum of two numbers
class Program3 {
    static void Main() {
        int a = 5, b = 7;
        int sum = a + b;
        Console.WriteLine("Sum: " + sum);
    }
}

// C# Program 4: Swap two numbers
class Program4 {
    static void Main() {
        int a = 5, b = 10;
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("a: " + a + ", b: " + b);
    }
}

// C# Program 5: Even or Odd Check
class Program5 {
    static void Main() {
        int num = 8;
        if (num % 2 == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}

// C# Program 6: Prime Number Check
class Program6 {
    static void Main() {
        int num = 29, count = 0;
        for (int i = 2; i < num; i++) {
            if (num % i == 0) {
                count++;
                break;
            }
        }
        if (count == 0)
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");
    }
}

// C# Program 7: Factorial of a number
class Program7 {
    static void Main() {
        int num = 5, fact = 1;
        for (int i = 1; i <= num; i++) {
            fact *= i;
        }
        Console.WriteLine("Factorial: " + fact);
    }
}

// C# Program 8: Fibonacci Series
class Program8 {
    static void Main() {
        int n = 10, a = 0, b = 1, c;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < n; i++) {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}

// C# Program 9: Multiplication Table
class Program9 {
    static void Main() {
        int num = 5;
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}

// C# Program 10: Reverse a Number
class Program10 {
    static void Main() {
        int num = 12345, rev = 0;
        while (num > 0) {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num /= 10;
        }
        Console.WriteLine("Reversed: " + rev);
    }
}

// C# Program 11: Palindrome Number Check
class Program11 {
    static void Main() {
        int num = 121, temp = num, rev = 0;
        while (num > 0) {
            int digit = num % 10;
            rev = rev * 10 + digit;
            num /= 10;
        }
        if (temp == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}

// C# Program 12: Armstrong Number Check
class Program12 {
    static void Main() {
        int num = 153, temp = num, sum = 0;
        while (num > 0) {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }
        if (sum == temp)
            Console.WriteLine("Armstrong");
        else
            Console.WriteLine("Not Armstrong");
    }
}

// C# Program 13: Find Largest of Three Numbers
class Program13 {
    static void Main() {
        int a = 10, b = 20, c = 15;
        int max = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
        Console.WriteLine("Largest: " + max);
    }
}

// C# Program 14: Check Leap Year
class Program14 {
    static void Main() {
        int year = 2024;
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            Console.WriteLine("Leap Year");
        else
            Console.WriteLine("Not a Leap Year");
    }
}

// C# Program 15: Count Digits in Number
class Program15 {
    static void Main() {
        int num = 12345, count = 0;
        while (num > 0) {
            num /= 10;
            count++;
        }
        Console.WriteLine("Digits: " + count);
    }
}

// C# Program 16: Calculate Power of a Number
class Program16 {
    static void Main() {
        int baseNum = 2, exponent = 3;
        int result = 1;
        for (int i = 0; i < exponent; i++) {
            result *= baseNum;
        }
        Console.WriteLine("Result: " + result);
    }
}

// C# Program 17: Sum of Digits of a Number
class Program17 {
    static void Main() {
        int num = 1234, sum = 0;
        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Sum of digits: " + sum);
    }
}

// C# Program 18: Check Number is Positive, Negative, or Zero
class Program18 {
    static void Main() {
        int num = -10;
        if (num > 0)
            Console.WriteLine("Positive");
        else if (num < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");
    }
}

// C# Program 19: Check Vowel or Consonant
class Program19 {
    static void Main() {
        char ch = 'e';
        ch = Char.ToLower(ch);
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            Console.WriteLine("Vowel");
        else if (Char.IsLetter(ch))
            Console.WriteLine("Consonant");
        else
            Console.WriteLine("Not an alphabet character");
    }
}

// C# Program 20: Find ASCII Value of Character
class Program20 {
    static void Main() {
        char ch = 'A';
        Console.WriteLine("ASCII value of " + ch + " is " + (int)ch);
    }
}

// C# Program 21: Find GCD of Two Numbers
class Program21 {
    static void Main() {
        int a = 36, b = 60, gcd = 1;
        for (int i = 1; i <= a && i <= b; i++) {
            if (a % i == 0 && b % i == 0)
                gcd = i;
        }
        Console.WriteLine("GCD: " + gcd);
    }
}
