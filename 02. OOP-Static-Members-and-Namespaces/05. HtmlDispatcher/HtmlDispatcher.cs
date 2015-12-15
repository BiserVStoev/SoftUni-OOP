using _05.HtmlDispatcher.Interfaces;

namespace _05.HtmlDispatcher
{
    public static class HtmlDispatcher
    {
        public static string CreateImage(string imgSource, string alt, string title)
        {
            IElementBuilder image = new ElementBuilder("img");
            image.AddAttribute("src", imgSource);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);

            return image.ToString();
        }

        public static string CreateUrl(string url, string title, string text)
        {
            IElementBuilder link = new ElementBuilder("a");
            link.AddAttribute("href", url);
            link.AddAttribute("title", title);
            link.AddContent(text);

            return link.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            IElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("type", type);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);

            return input.ToString();
        }
    }
}
