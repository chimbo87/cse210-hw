
class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide this word
    public void Hide()
    {
        _isHidden = true;
    }

    // Check if the word is currently hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the display text for the word (either the word or underscores)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create a string of underscores with the same length as the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}