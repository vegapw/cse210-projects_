using System.Text.RegularExpressions;

public class Word{
    private string _text;
    private bool _isHidden=false;
    private string _hiddenText;

    public Word (string text){
        _text = text;
        _hiddenText = text;
    }

    public void Hide(){
        _text = Regex.Replace(_text, @"[A-Za-z]", "_");
        _isHidden = true;
    }

    public void Show(){
        _text = _hiddenText;
        _isHidden = false;
    }

    public bool isHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        return _text;
    }
}