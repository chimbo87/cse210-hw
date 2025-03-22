// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    // Hide a specified number of random words that aren't already hidden
    public void HideRandomWords(int count)
    {
        // Find all words that aren't hidden yet
        List<int> visibleWordIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleWordIndices.Add(i);
            }
        }

        // Determine how many words to hide (minimum of count and available words)
        int wordsToHide = Math.Min(count, visibleWordIndices.Count);

        // Hide the random words
        for (int i = 0; i < wordsToHide; i++)
        {
            if (visibleWordIndices.Count == 0)
            {
                break;
            }

            int randomIndex = _random.Next(visibleWordIndices.Count);
            int wordIndex = visibleWordIndices[randomIndex];
            
            _words[wordIndex].Hide();
            visibleWordIndices.RemoveAt(randomIndex);
        }
    }

    // Check if all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // Get the formatted scripture for display
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        
        // Build the scripture text with correctly hidden words
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        
        string scriptureText = string.Join(" ", displayWords);
        
        // Return the complete scripture with reference
        return $"{reference}\n{scriptureText}";
    }
}