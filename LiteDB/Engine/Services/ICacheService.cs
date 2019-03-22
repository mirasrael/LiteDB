namespace LiteDB
{
    using System.Collections.Generic;

    public interface ICacheService
    {
        int CleanUsed { get; }
        int DirtyUsed { get; }
        void DiscardDirtyPages();
        BasePage GetPage(uint pageID);
        BasePage GetOrAddPage(uint pageID, AesEncryption crypto);
        void AddPage(BasePage page);
        void ClearPages();
        void SetDirty(BasePage page);
        ICollection<BasePage> GetDirtyPages();
        void MarkDirtyAsClean();
    }
}