// Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text
public class Scripture
{
    // attributes
    private Reference _reference;
    private List<Word> _words;

    // constructor
    public Scripture (Reference Reference, string text )
    {
        _reference = Reference;

        _words = [];

        string[] words = text.Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            Word word = new Word(words[i]);
            _words.Add(word);
        }
    }

    // getter function
    private string GetReference()
    {
        return _reference.GetDisplayText();
    }

    private string GetWords()
    {
        List<string> texts = [];
        
        foreach (Word word in _words)
        {
            texts.Add(word.GetDisplayText());
        }

        return string.Join(" ", texts);
    }

    // methods
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, _words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return GetReference() + " " + GetWords();
    }

    public bool IsCompletelyHidden()
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