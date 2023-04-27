﻿namespace Military_Elite.Models.Interfaces
{
    using System.Collections.Generic;
    public interface ILieutenantGeneral : IPrivate
    {
        public IReadOnlyCollection<IPrivate> Privates { get;}
    }
}
