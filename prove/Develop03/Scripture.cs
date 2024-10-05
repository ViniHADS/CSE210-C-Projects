using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Construtor que aceita um �nico vers�culo
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();

        // Divide o texto em palavras e as adiciona � lista _words
        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Construtor que aceita um intervalo de vers�culos
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(book, chapter, startVerse, endVerse);
        _words = new List<Word>();

        // Divide o texto em palavras e as adiciona � lista _words
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

        // Cria uma lista de palavras que ainda est�o vis�veis
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Se existirem palavras vis�veis, esconde uma aleat�ria
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
