namespace _05.HtmlDispatcher.Interfaces
{
    public interface IElementBuilder
    {
        void AddAttribute(string attr, string value);

        void AddContent(string content);
    }
}
