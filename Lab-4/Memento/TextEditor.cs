using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        private TextDocument document;
        private List<IDocumentMemento> history = new List<IDocumentMemento>();


        public TextEditor(TextDocument document)
        {
            this.document = document;
            history = new List<IDocumentMemento>();
        }


        public void Save()
        {
            this.history.Add(document.Save());
        }
        public void Undo()
        {
            var memento = history.LastOrDefault();
            if (memento != null)
            {
                document.Restore(memento);
                history.Remove(memento);
            }
        }
        public void DocumentHistory()
        {
            foreach (var item in history)
            {
                Console.WriteLine($"Id: {item.Id}, Date: {item.DateTime}");
            }
        }
    }
}
