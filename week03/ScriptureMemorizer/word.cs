public class Word
{
    private string _original;
    private bool _isHidden;


    public Word(string original)
    {
    _original = original;
    _isHidden = false;
    }

    public string GetDisplayText()
    {
    if (_isHidden)
    {
        return new string('_', _original.Length);
    }

    return _original;
    }

    public bool IsHidden()
    {
    return _isHidden;
    }

    public void Hide()
    {
    _isHidden = true;
    }

}