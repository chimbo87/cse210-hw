// ScriptureLibrary.cs
using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        
        // Add several scriptures to the library
        AddDefaultScriptures();
    }

    private void AddDefaultScriptures()
    {
        // Add John 3:16
        Reference ref1 = new Reference("John", 3, 16);
        string text1 = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture1 = new Scripture(ref1, text1);
        
        // Add Proverbs 3:5-6
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        string text2 = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture2 = new Scripture(ref2, text2);
        
        // Add 1 Nephi 3:7
        Reference ref3 = new Reference("1 Nephi", 3, 7);
        string text3 = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        Scripture scripture3 = new Scripture(ref3, text3);
        
        _scriptures.Add(scripture1);
        _scriptures.Add(scripture2);
        _scriptures.Add(scripture3);
    }

    // Get a random scripture from the library
    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("No scriptures in the library.");
        }
        
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}