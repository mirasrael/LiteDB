namespace LiteDB
{
    using System;

    public class LiteEngineOptions
    {
        public IDiskService                              DiskService { get; set; }
        public string                                    Password    { get; set; }
        public TimeSpan?                                 Timeout     { get; set; } = null;
        public int                                       CacheSize   { get; set; } = 5000;
        public bool                                      UtcDate     { get; set; } = false;
        public Func<IDiskService, Logger, ICacheService> CacheServiceFactory { get; set; }
    }
}