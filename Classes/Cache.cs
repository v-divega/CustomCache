using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomCache.Classes
{
    public class Cache<TKey, TData>
    {
        private readonly Dictionary<TKey, TData> _cachedData = new();

        //the method to obtain the data. 
        //we pass a Func<> as a parameter which will give us the data
        //from source that we need to add to our cache. 
        public TData Get(TKey key, Func<TKey, TData> getForTheFirstTIme)
        {
            if (!_cachedData.ContainsKey(key))
            {
                _cachedData[key] = getForTheFirstTIme(key);
            }
            return _cachedData[key];

        }

    }


}
