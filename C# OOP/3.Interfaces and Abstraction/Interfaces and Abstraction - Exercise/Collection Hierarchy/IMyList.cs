﻿namespace Collection_Hierarchy
{
    using System.Collections.Generic;

    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        IReadOnlyCollection<T> Used { get; }
    }
}
