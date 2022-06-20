namespace Azox.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class AzoxBugException :
        AzoxException
    {
        #region Ctor

        public AzoxBugException() :
            base("[BUG]")
        {
        }

        public AzoxBugException(string message) :
            base($"[BUG] {message}")
        {
        }

        #endregion Ctor
    }
}
