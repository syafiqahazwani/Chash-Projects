namespace ChessUI
{
    public static class ChessCursors
    {
        public static readonly ChessCursors WhiteCursor = LoadCursor("Assets/CursorW.cur");
        public static readonly ChessCursors BlackCursor = LoadCursor("Assets/CursorB.cur");

        private static ChessCursors LoadCursor(string filePath)
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true);
        }
    }
}
