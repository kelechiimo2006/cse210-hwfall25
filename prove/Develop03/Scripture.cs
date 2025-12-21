public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private int _numberOfWordsHidden = 0;

    public Scripture(string referenceText, string text)
    {
        string[] words = text.Split(" ");
        foreach(string singleText in words)
        {
            Word word = new Word(singleText, false);
            _words.Add(word);
        }
        string[] referenceParts = referenceText.Split(' ', ':','-');
        if (referenceParts.Length == 3)
        {
            _reference = new Reference(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]));
        }
        else if(referenceParts.Length == 4)
        {
            _reference = new Reference(referenceParts[0], int.Parse(referenceParts[1]), int.Parse(referenceParts[2]), int.Parse(referenceParts[3]));
        }
    }
    public void HideWords()
    {   
        Random random = new Random();
        int groupOfHiddenWords = random.Next(1,3);
        for(int i = 0; i < groupOfHiddenWords; i++)
        {
            int number = random.Next(_words.Count);
            if (_words[number].GetIsHidden() == false)
            {
                _words[number].Hide();
                _numberOfWordsHidden++;
            }
        }
    }
    public void GetRenderedText()
    {
        Console.Write($"{_reference.DisplayReference()} ");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetRenderedText()} ");
        }
        Console.WriteLine("");
    }
    public bool IsCompletelyHidden()
    {
        if (_words.Count == _numberOfWordsHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}