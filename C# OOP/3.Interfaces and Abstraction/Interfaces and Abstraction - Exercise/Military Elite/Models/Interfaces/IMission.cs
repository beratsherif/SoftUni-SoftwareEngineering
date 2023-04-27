﻿namespace Military_Elite.Models.Interfaces
{
    using Military_Elite.Models.Enums;
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }
        void CompleteMission();
    }
}
