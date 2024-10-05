class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse; // Nullable int para representar a aus�ncia de um final

    // Construtor para um �nico vers�culo
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null; // Define como nulo para um �nico vers�culo
    }

    // Construtor para um intervalo de vers�culos
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse.HasValue) // Verifica se _endVerse n�o � nulo
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}
