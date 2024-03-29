﻿namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get;private set;}
        public virtual int Power { get;private set; }

        public abstract string CastAbility();
    }
}
