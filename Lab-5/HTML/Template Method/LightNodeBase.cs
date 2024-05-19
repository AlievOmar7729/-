using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Template_Method
{
    public abstract class LightNodeBase : ILightNode
    {
        public void Render()
        {
            OnCreated();
            OnInserted();
            ApplyStyles();
            ApplyClassList();
            RenderText();
            OnRemoved();
        }

        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void ApplyStyles() { }
        protected virtual void ApplyClassList() { }
        protected virtual void RenderText() { }

        public abstract void outerHTML();
        public abstract void innerHTML();
    }
}
