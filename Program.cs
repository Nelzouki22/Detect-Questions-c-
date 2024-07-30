using System;
using System.Collections.Generic;

class Program
{
    static bool IsQuestion(string sentence)
    {
        // قائمة الكلمات التي تشير إلى الأسئلة
        HashSet<string> questionWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "what", "when", "where", "who", "whom", "which", "why", "how",
            "is", "are", "do", "does", "did", "can", "could", "would", "will",
            "shall", "should"
        };

        // تقسيم الجملة إلى كلمات
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // التحقق مما إذا كانت الكلمة الأولى من الكلمات التي تشير إلى الأسئلة
        if (words.Length > 0 && questionWords.Contains(words[0]))
        {
            return true;
        }

        // التحقق مما إذا كانت الجملة تنتهي بعلامة استفهام
        if (sentence.EndsWith("?"))
        {
            return true;
        }

        return false;
    }

    static void Main()
    {
        // بعض الجمل لاختبار الكود
        List<string> sentences = new List<string>
        {
            "What is your name?",
            "This is a statement.",
            "Are you coming to the party?",
            "It's raining today."
        };

        foreach (string sentence in sentences)
        {
            if (IsQuestion(sentence))
            {
                Console.WriteLine($"'{sentence}' is a question.");
            }
            else
            {
                Console.WriteLine($"'{sentence}' is not a question.");
            }
        }
    }
}

