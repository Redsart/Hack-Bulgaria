using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public interface IXmlMarkupBuilder
    {
        XmlMarkupBuilder OpenTag(string tagName);
        XmlMarkupBuilder AddAttribute(string attributeName, string attributeValue);
        XmlMarkupBuilder AddText(string text);
        XmlMarkupBuilder CloseTag();
        XmlMarkupBuilder Finish();
        string GetResult();
    }
}
