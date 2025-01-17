
public class Scripture{

    Reference _reference;
    List<Word> _words;

    public Scripture (Reference reference, string text){
        _reference = reference;
        _words = SplitText(text);
    }

    private List<Word> SplitText(string text){
        List<Word> words = new List<Word>();
        String[] parts;
        Word word;

        parts = text.Split(" ");
        foreach (string item in parts)
        {
            word = new Word(item);
            words.Add(word);
        }
        return words;
    }

    public void HideRandomWords(int numberToHide){
        Random random = new Random();
        int number;
        int wordsHidden = 0;
        while (wordsHidden < numberToHide)
        {
            number = random.Next(0, _words.Count);
            if (!_words[number].isHidden())
            {
                _words[number].Hide();
                wordsHidden++;
            }
            else if (IsCompletelyHidden())
            {
                wordsHidden = numberToHide;
            }
        }
    }

    public bool IsCompletelyHidden(){
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText(){
        string text = $"{_reference.GetDisplayText()}: ";
        foreach (Word word in _words)
        {
            text += " " + word.GetDisplayText();
        }
        return text;
    }
}