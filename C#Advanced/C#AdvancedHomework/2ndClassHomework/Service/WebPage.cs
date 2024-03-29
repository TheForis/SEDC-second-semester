namespace Service
{
    public class WebPage : ISearchable
    {
        public string WebPageText { get; set; }
        public WebPage(string webPageText)
        {
            WebPageText = webPageText;
        }
        public WebPage()
        {
            
        }

        public string Search(string word)
        {
            if (WebPageText.ToLower().Contains(word.ToLower()))
            {
                return $"The Web Page contains the word: {word}!";
            }
            else
            {
                return $"Sadly, the Web page doesn't contain the word: {word}!";
            }
        }
    }
}
