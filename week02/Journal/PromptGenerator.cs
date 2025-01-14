public class PromptGenerator{
    List<string> _prompts = new List<string>();

    public string GetRandomPrompt(){
        Random random = new Random();
        if (_prompts.Count > 0)
        {
            int n = random.Next(0,_prompts.Count);
            return _prompts[n];
        }
        return "";
    }

    public void AddPrompt(string prompt){
        _prompts.Add(prompt);
    }
}