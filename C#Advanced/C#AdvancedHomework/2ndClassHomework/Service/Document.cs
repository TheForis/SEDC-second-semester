namespace Service
{
    public class Document : ISearchable
    {
        public string DocumentText {  get; set; }
        public Document(string documentText)
        {
            DocumentText = documentText;
        }
        public Document()
        {
            
        }

        public string Search(string word)
        {
            if(DocumentText.ToLower().Contains(word.ToLower()))
            {
                return $"The document contains the word : {word} !";
            }
            else
            {
                return $"The document doesn't contain the word!";
            }
        }
    }
}
