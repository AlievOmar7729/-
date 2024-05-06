namespace Memento
{
    public class TextDocument
    {
        protected string content {  get; set; }

        public TextDocument(string content)
        {
            this.content = content;
        }

        public void AddContent(string newContent)
        {
            content += newContent;
        }
        public IDocumentMemento Save()
        {
            return new DocumentMemento(content);
        }
        public void Restore(IDocumentMemento memento)
        {
            var backMemento = (DocumentMemento)memento;
            content = backMemento.GetContent();
        }
        public override string ToString()
        {
            return content;
        }
    }
}
