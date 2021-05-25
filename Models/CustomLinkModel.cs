using System.Xml.Serialization;

namespace ServerMess.Models
{
    public class CustomLinkModel
    {
        [XmlAttribute]
        public string Message;
        [XmlAttribute]
        public string Url;

        public CustomLinkModel()
        {
            
        }

        public CustomLinkModel(string message, string url)
        {
            Message = message;
            Url = url;
        }
    }
}