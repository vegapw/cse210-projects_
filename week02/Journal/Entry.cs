public class Entry{

    DateTime _date;
    string _prompt;
    string _response;

    public void Display(){
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}\n");
    }

    public DateTime GetDate(){
        return _date;
    }

    public string GetPrompt(){
        return _prompt;
    }

    public string GetResponse(){
        return _response;
    }

    public void SetDate(DateTime date){
        _date = date;
    }

    public void SetPrompt(string prompt){
        _prompt = prompt;
    }

    public void SetResponse(string response){
        _response = response;
    }


}