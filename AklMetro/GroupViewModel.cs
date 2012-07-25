using System.Collections.Generic;

namespace AklMetro
{
    public class GroupViewModel<TKey, TItem> : List<TItem>
    {
        private readonly TKey _key;

        public GroupViewModel(TKey key, IEnumerable<TItem> items)
        {
            _key = key;
            base.AddRange(items);
        }

        public string Identifier
        {
            get { return _key.ToString(); }
        }
    }
}