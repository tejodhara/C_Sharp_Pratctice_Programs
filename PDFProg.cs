from fpdf import FPDF

# Initialize PDF
pdf = FPDF()
pdf.set_auto_page_break(auto=True, margin=15)
pdf.add_page()
pdf.set_font("Courier", size=10)

# Load C# code from the user content
code = '''// C# Program 1: Hello World
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
'''

# Split into lines and add to PDF
for line in code.split('\n'):
    pdf.cell(200, 5, txt=line, ln=True)

# Save the PDF
output_path = "/mnt/data/CSharp_Programs_1_to_12.pdf"
pdf.output(output_path)
