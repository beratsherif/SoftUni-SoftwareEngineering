using System.Collections.Generic;
using System.Linq;

namespace Collection_Hierarchy
{
    public class MyList<T> : AddRemoveCollection<T>, IMyList<T>
    {
        public IReadOnlyCollection<T> Used => this.Data as IReadOnlyCollection<T>;

        public override T Remove()
        {
            var firstElement = this.Data.First();
            this.Data.RemoveAt(0);
            return firstElement;
        }
    }
}
