using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class XmlMarkupBuilder : IXmlMarkupBuilder
    {
        private List<string> openTags;
        private List<string> closeTags;
        bool isFinish = false;
        string text;

        public XmlMarkupBuilder()
        {
            this.openTags=new List<string>();
            this.closeTags = new List<string>();
        }

        public XmlMarkupBuilder OpenTag(string tagName)
        {
            CheckIfFinished();
            if (this.closeTags.Count >=1)
            {
                throw new Exception("BOOOM! You need to have a root XML object, XML is not a list!");
            }
            this.openTags.Add(tagName);
            return this;
        }

        public XmlMarkupBuilder CloseTag()
        {
            CheckIfFinished();
            if (this.closeTags.Count < this.openTags.Count)
            {
                closeTags.Add(this.openTags.LastOrDefault());
                this.openTags.Remove(this.openTags.LastOrDefault());
                return this;
            }
            else
            {
                throw new Exception("BOOOM! What the hell are we closing?!");
            }
        }

        public XmlMarkupBuilder AddAttribute(string attributeName, string attributeValue)
        {
            CheckIfFinished();

            if (this.openTags.Count >= 1)
            {
                var tag = this.openTags.LastOrDefault();
                var attribute = String.Format(" {0}=\"{1}\"",attributeName,attributeValue);
                var result = tag + attribute;
                this.openTags.Remove(this.openTags.LastOrDefault());
                this.openTags.Add(result);
                return this;
            }
            else
            {
                throw new Exception("You added wrong attribute");
            }
        }

        public XmlMarkupBuilder AddText(string text)
        {
            CheckIfFinished();

            this.text = text;
            return this;
        }

        public XmlMarkupBuilder Finish()
        {
            CheckIfFinished();

            if (this.openTags.Count >= 1)
            {
                for (int i = this.openTags.Count - 1; i >= 0; i--)
                {
                    this.closeTags.Add(this.openTags[i]);
                }
                this.openTags.Clear();
            }
            this.isFinish = true;
            return this;
        }

        public string GetResult()
        {
            StringBuilder sb = new StringBuilder();
            if (this.openTags.Count >= 1)
            {
                throw new Exception("There are unclosed tags!");
            }

            foreach (var tag in this.closeTags)
            {
                sb.Append("<" + tag + ">");
            }
            sb.Append(this.text);

            foreach (var tag in this.closeTags)
            {
                var currTag = tag.Split(' ');
                sb.Append("<" + currTag[0] + ">");
            }
            return sb.ToString();
        }

        private void CheckIfFinished()
        {
            if (isFinish)
            {
                throw new Exception("BOOOM! Object finalized! Exception!");
            }
        }
    }
}
