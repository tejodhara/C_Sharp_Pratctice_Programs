# Program 22: Calculate GCD of Two Numbers
class Program22 {
    static void Main() {
        int a = 36, b = 60;
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine("GCD: " + a); // Output: GCD: 12
    }
}
# Program 23: Calculate LCM of Two Numbers
class Program23 {
    static void Main() {
        int a = 12, b = 18;
        int gcd = a, tempB = b;
        while (tempB != 0) {
            int temp = tempB;
            tempB = gcd % tempB;
            gcd = temp;
        }
        int lcm = (a * b) / gcd;
        Console.WriteLine("LCM: " + lcm); // Output: LCM: 36
    }
}
✅ Program 24: Count Vowels in a String
class Program24 {
    static void Main() {
        string str = "Hello World";
        int count = 0;
        foreach (char c in str.ToLower()) {
            if ("aeiou".Contains(c)) count++;
        }
        Console.WriteLine("Vowels: " + count); // Output: Vowels: 3
    }
}
✅ Program 25: Reverse a String
class Program25 {
    static void Main() {
        string str = "developer";
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine("Reversed: " + new string(arr)); // Output: Reversed: repoleved
    }
}
✅ Program 26: Check Palindrome String
class Program26 {
    static void Main() {
        string str = "madam";
        string rev = new string(str.Reverse().ToArray());
        Console.WriteLine(str == rev ? "Palindrome" : "Not Palindrome"); // Output: Palindrome
    }
}
✅ Program 27: Sum of Digits of a Number
class Program27 {
    static void Main() {
        int num = 1234, sum = 0;
        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Sum: " + sum); // Output: Sum: 10
    }
}
✅ Program 28: Find ASCII Value of a Character
class Program28 {
    static void Main() {
        char ch = 'A';
        Console.WriteLine("ASCII: " + (int)ch); // Output: ASCII: 65
    }
}
✅ Program 29: Convert Celsius to Fahrenheit
class Program29 {
    static void Main() {
        double c = 25;
        double f = (c * 9 / 5) + 32;
        Console.WriteLine("Fahrenheit: " + f); // Output: Fahrenheit: 77
    }
}
✅ Program 30: Convert Fahrenheit to Celsius
class Program30 {
    static void Main() {
        double f = 98.6;
        double c = (f - 32) * 5 / 9;
        Console.WriteLine("Celsius: " + c); // Output: Celsius: 37
    }
}
✅ Program 31: Print All Even Numbers from 1 to 100
class Program31 {
    static void Main() {
        for (int i = 1; i <= 100; i++) {
            if (i % 2 == 0) Console.Write(i + " ");
        }
        // Output: 2 4 6 8 ... 100
    }
}
✅ Program 32: Print All Odd Numbers from 1 to 100
class Program32 {
    static void Main() {
        for (int i = 1; i <= 100; i++) {
            if (i % 2 != 0) Console.Write(i + " ");
        }
        // Output: 1 3 5 7 ... 99
    }
}
✅ Program 33: Find Power of a Number
class Program33 {
    static void Main() {
        int baseNum = 2, exp = 4;
        double result = Math.Pow(baseNum, exp);
        Console.WriteLine("Power: " + result); // Output: Power: 16
    }
}
✅ Program 34: Find Square Root of a Number
class Program34 {
    static void Main() {
        int num = 25;
        double sqrt = Math.Sqrt(num);
        Console.WriteLine("Square Root: " + sqrt); // Output: Square Root: 5
    }
}
✅ Program 35: Count Words in a Sentence
class Program35 {
    static void Main() {
        string sentence = "I am a C# developer";
        int wordCount = sentence.Split(' ').Length;
        Console.WriteLine("Words: " + wordCount); // Output: Words: 5
    }
}
✅ Program 36: Check Armstrong Number (3 digits)
class Program36 {
    static void Main() {
        int num = 371, temp = num, sum = 0;
        while (num > 0) {
            int d = num % 10;
            sum += d * d * d;
            num /= 10;
        }
        Console.WriteLine(temp == sum ? "Armstrong" : "Not Armstrong"); // Output: Armstrong
    }
}
✅ Program 37: Find All Armstrong Numbers (1 to 1000)
class Program37 {
    static void Main() {
        for (int i = 1; i <= 1000; i++) {
            int num = i, temp = i, sum = 0;
            while (num > 0) {
                int d = num % 10;
                sum += d * d * d;
                num /= 10;
            }
            if (sum == temp) Console.Write(i + " ");
        }
        // Output: 1 153 370 371 407
    }
}
✅ Program 38: Print Alphabet using Loop
class Program38 {
    static void Main() {
        for (char c = 'A'; c <= 'Z'; c++) {
            Console.Write(c + " ");
        }
        // Output: A B C ... Z
    }
}
✅ Program 39: Convert Char to Uppercase
class Program39 {
    static void Main() {
        char ch = 'b';
        Console.WriteLine("Uppercase: " + Char.ToUpper(ch)); // Output: Uppercase: B
    }
}
✅ Program 40: Convert Char to Lowercase
class Program40 {
    static void Main() {
        char ch = 'D';
        Console.WriteLine("Lowercase: " + Char.ToLower(ch)); // Output: Lowercase: d
    }
}
