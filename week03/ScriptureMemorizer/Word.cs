// Keeps track of a single word and whether it is shown or hidden
using System.ComponentModel.DataAnnotations;

public class Word
{
    // attributes
    private string _text;
    private bool _isHidden = false; // set to false to show text by default

    // constructor
    public Word (string text)
    {
        _text = text;
    }

    // getter function
    private string GetText()
    {
        return _text;
    }

    // getter function
    private bool GetIsHidden()
    {
        return _isHidden;
    }

    // setter function
    private void SetIsHidden(bool value)
    {
        _isHidden = value;
    }

    // method
    public void Hide()
    {
        SetIsHidden(true);
    }
    
    public void Show()
    {
        SetIsHidden(false);
    }

    public bool IsHidden()
    {
        return GetIsHidden();
    }

    public string GetDisplayText()
    {
        string displayText = GetText();

        if (IsHidden())
        {
            char[] chars = displayText.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '_';
            }

            displayText = new string(chars);
        }

        return displayText;
    }
}