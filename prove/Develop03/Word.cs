public class Word
{
    private string _singleWord;
    private bool _isHidden;

    public Word(string singleWord, bool isHidden)
    {
        _singleWord = singleWord;
        _isHidden = isHidden;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false; 
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
    public string GetSingleWord()
    {
        return _singleWord;
    }
    public string GetRenderedText()
    {
        
        if(_isHidden == true){
        string dashes = "";
        int numberOfDashes = _singleWord.Length;
        for (int i = 0; i < numberOfDashes; i++)
        {
            dashes += "_";
        }
        return dashes;
        }
        else
        {
            return _singleWord;
        }
    }


}