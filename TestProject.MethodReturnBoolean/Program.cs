string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word) 
{
    int start = 0;                // Points to first character
    int end = word.Length - 1;    // Points to last character

    while (start < end) 
    {
        if (word[start] != word[end]) 
        {
            return false;    // Characters don't match = not a palindrome
        }
        start++;    // Move right pointer forward
        end--;      // Move left pointer backward
    }

    return true;
}

// Step 1: r a c e c a r    Compare r=r ✓
//         ↑           ↑
//         start      end

// Step 2: r a c e c a r    Compare a=a ✓
//           ↑       ↑
//           start   end

// Step 3: r a c e c a r    Compare c=c ✓
//             ↑   ↑
//             s   e

// Step 4: r a c e c a r    Pointers meet, done
//               ↑
//               se