using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class DocumentMemento : IDocumentMemento
    {
        protected string content;
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime DateTime { get; } = DateTime.Now;

        public DocumentMemento(string content)
        {
            this.content = content;
        }
        public void Restore(string content)
        {
            this.content = content;
        }
        public string GetContent()
        {
            return content;
        }
    }
}
