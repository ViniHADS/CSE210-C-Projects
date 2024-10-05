using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor that accepts a single verse
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();

        // Splits the text into words and adds them to the _words list
        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Constructor that accepts a range of verses
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = new List<Word>();

        // Splits the text into words and adds them to the _words list
        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        // Creates a list of words that are still visible
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // If there are visible words, hide a random one
        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public string GetRenderedScripture()
    {
        string renderedText = "";

        foreach (Word word in _words)
        {
            renderedText += word.GetDisplayedWord() + " ";
        }

        return $"{_reference.ToString()}: {renderedText.Trim()}";
    }

    public bool AllWordsHidden()
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
}
