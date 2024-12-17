using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache.Classes
{
    public class CachingDataDownloader : IDataDownloader
    {
        private readonly IDataDownloader _dataDownloader;
        private readonly Cache<string, string> _cache = new();

        public CachingDataDownloader (IDataDownloader dataDownloader)
        {
            _dataDownloader = dataDownloader;
        }
        public string DownloadData(string resourceId)
        {
            return _cache.Get(resourceId, _dataDownloader.DownloadData);
        }
    }
}
