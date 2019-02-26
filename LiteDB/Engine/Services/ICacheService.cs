namespace LiteDB
{
    using System.Collections.Generic;

    public interface ICacheService
    {
        int CleanUsed { get; }
        int DirtyUsed { get; }
        void DiscardDirtyPages();
        BasePage GetPage(uint pageID);
        void AddPage(BasePage page);
        void ClearPages();
        void SetDirty(BasePage page);
        ICollection<BasePage> GetDirtyPages();
        void MarkDirtyAsClean();
    }
}