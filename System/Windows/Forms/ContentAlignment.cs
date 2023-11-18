namespace System.Windows.Forms
{
    internal class ContentAlignment
    {
        public static ContentAlignment MiddleLeft { get; internal set; }

        public static implicit operator Drawing.ContentAlignment(ContentAlignment v)
        {
            throw new NotImplementedException();
        }
    }
}