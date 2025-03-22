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

        // only hide words that are not already hidden
        List<Word> wordsToHide = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                wordsToHide.Add(word);
            }
        }

        // shuffle and hide the specified number of words
        for (int i = 0; i < numberToHide && wordsToHide.Count > 0; i++)
        {
            int index = random.Next(0, wordsToHide.Count);
            wordsToHide[index].Hide();
            wordsToHide.RemoveAt(index); // remove the word from the list after hiding
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