namespace MySlideShow.Models
{
    /// <summary>
    /// The undo button undoes [Delete] and [Save].
    /// It does not undo [Rename] or [Rotate]
    /// </summary>
    internal class Undo
    {
        public string FullPath { get; set; } = string.Empty;
        public string RecycledPath { get; set; } = string.Empty;
        public App.Action Action { get; set; } = App.Action.Void;
    }
}
