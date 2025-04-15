 // Program 41: Find Sum of Natural Numbers
class Program41 {
    static void Main() {
        int n = 100;
        int sum = n * (n + 1) / 2;
        Console.WriteLine("Sum: " + sum); // Output: Sum: 5050
    }
}
 // Program 42: Check Alphabet, Digit, or Special Character
class Program42 {
    static void Main() {
        char ch = '$';
        if (char.IsLetter(ch))
            Console.WriteLine("Alphabet");
        else if (char.IsDigit(ch))
            Console.WriteLine("Digit");
        else
            Console.WriteLine("Special Character"); // Output: Special Character
    }
}
 // Program 43: Count Frequency of Characters in String
class Program43 {
    static void Main() {
        string str = "hello";
        var freq = new Dictionary<char, int>();
        foreach (char c in str) {
            if (freq.ContainsKey(c)) freq[c]++;
            else freq[c] = 1;
        }
        foreach (var pair in freq)
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        // Output: h:1, e:1, l:2, o:1
    }
}
 // Program 44: Swap Without Temp Variable
 
 
 
class Program44 {
    static void Main() {
        int a = 10, b = 20;
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine($"a: {a}, b: {b}"); // Output: a: 20, b: 10
    }
}
 // Program 45: Sum of Array Elements
 
 
 
class Program45 {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        int sum = arr.Sum();
        Console.WriteLine("Sum: " + sum); // Output: Sum: 15
    }
}
 // Program 46: Find Max and Min in Array
 
 
 
class Program46 {
    static void Main() {
        int[] arr = {3, 9, 2, 5, 8};
        Console.WriteLine("Max: " + arr.Max()); // Output: Max: 9
        Console.WriteLine("Min: " + arr.Min()); // Output: Min: 2
    }
}
 // Program 47: Linear Search
 
 
 
class Program47 {
    static void Main() {
        int[] arr = {1, 3, 5, 7};
        int key = 5, index = -1;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == key) {
                index = i;
                break;
            }
        }
        Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not Found");
        // Output: Found at index 2
    }
}
 // Program 48: Binary Search (Sorted Array)
 
 
 
class Program48 {
    static void Main() {
        int[] arr = {1, 3, 5, 7, 9};
        int key = 7, low = 0, high = arr.Length - 1, mid;
        bool found = false;
        while (low <= high) {
            mid = (low + high) / 2;
            if (arr[mid] == key) {
                Console.WriteLine("Found at index " + mid); // Output: Found at index 3
                found = true;
                break;
            } else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }
        if (!found) Console.WriteLine("Not Found");
    }
}
 // Program 49: Bubble Sort
 
 
 
class Program49 {
    static void Main() {
        int[] arr = {5, 2, 8, 1, 3};
        for (int i = 0; i < arr.Length - 1; i++) {
            for (int j = 0; j < arr.Length - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Sorted: " + string.Join(", ", arr));
        // Output: Sorted: 1, 2, 3, 5, 8
    }
}
 // Program 50: Reverse an Array
 
 
 
class Program50 {
    static void Main() {
        int[] arr = {1, 2, 3, 4};
        Array.Reverse(arr);
        Console.WriteLine(string.Join(", ", arr)); // Output: 4, 3, 2, 1
    }
}
 // Program 51: Count Positive and Negative Numbers
 
 
 
class Program51 {
    static void Main() {
        int[] nums = {-1, 2, 0, -5, 6};
        int pos = 0, neg = 0;
        foreach (int n in nums) {
            if (n > 0) pos++;
            else if (n < 0) neg++;
        }
        Console.WriteLine($"Positive: {pos}, Negative: {neg}"); // Output: Positive: 2, Negative: 2
    }
}
 // Program 52: Find Duplicate Elements in Array
 
 
 
class Program52 {
    static void Main() {
        int[] arr = {1, 2, 3, 2, 4, 1};
        var duplicates = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
        Console.WriteLine("Duplicates: " + string.Join(", ", duplicates)); // Output: Duplicates: 1, 2
    }
}
 // Program 53: Find Second Largest Element
 
 
 
class Program53 {
    static void Main() {
        int[] arr = {10, 20, 15, 25};
        var second = arr.OrderByDescending(x => x).Distinct().Skip(1).FirstOrDefault();
        Console.WriteLine("Second Largest: " + second); // Output: Second Largest: 20
    }
}
 // Program 54: Merge Two Arrays
 
 
 
class Program54 {
    static void Main() {
        int[] a = {1, 2}, b = {3, 4};
        int[] merged = a.Concat(b).ToArray();
        Console.WriteLine("Merged: " + string.Join(", ", merged)); // Output: 1, 2, 3, 4
    }
}
 // Program 55:   Array Elements
 
 
 
class Program55 {
    static void Main() {
        int[] a = {1, 2, 3};
        int[] b = new int[a.Length];
        Array. (a, b, a.Length);
        Console.WriteLine("Copied: " + string.Join(", ", b)); // Output: 1, 2, 3
    }
}
 // Program 56: Find Largest Element Index
 
 
 
class Program56 {
    static void Main() {
        int[] arr = {4, 7, 9, 1};
        int maxIndex = Array.IndexOf(arr, arr.Max());
        Console.WriteLine("Index of Max: " + maxIndex); // Output: Index of Max: 2
    }
}
 // Program 57: Count Even and Odd Numbers
 
 
 
class Program57 {
    static void Main() {
        int[] arr = {1, 2, 3, 4, 5};
        int even = arr.Count(x => x % 2 == 0);
        int odd = arr.Length - even;
        Console.WriteLine($"Even: {even}, Odd: {odd}"); // Output: Even: 2, Odd: 3
    }
}
 // Program 58: Insert Element at Index
 
 
 
class Program58 {
    static void Main() {
        List<int> list = new List<int> {1, 2, 4};
        list.Insert(2, 3);
        Console.WriteLine(string.Join(", ", list)); // Output: 1, 2, 3, 4
    }
}
 // Program 59: Remove Duplicates from Array
 
 
 
class Program59 {
    static void Main() {
        int[] arr = {1, 1, 2, 3, 2};
        var unique = arr.Distinct().ToArray();
        Console.WriteLine("Unique: " + string.Join(", ", unique)); // Output: Unique: 1, 2, 3
    }
}
 // Program 60: Count Frequency of Each Word
 
 
 
class Program60 {
    static void Main() {
        string text = "C# is awesome and C# is powerful";
        var words = text.Split(' ');
        var freq = words.GroupBy(w => w).ToDictionary(g => g.Key, g => g.Count());
        foreach (var w in freq)
            Console.WriteLine($"{w.Key}: {w.Value}");
        // Output: C#:2, is:2, awesome:1, and:1, powerful:1
    }
}
