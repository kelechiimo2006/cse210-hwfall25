public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse = 0;

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string DisplayReference()
    {
        string referenceText;
        if (_endVerse > 0)
        {
            referenceText =  $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return referenceText;
        }
        else
        {
            referenceText =  $"{_book} {_chapter}:{_verse}";
            return referenceText;
        }
        
    }

}