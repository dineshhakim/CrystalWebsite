﻿ 

namespace Uranus.Domain
{
    /// <summary>
    /// To register all the internal type with unity.
    /// </summary>
    public interface IModule
    {
        void Initialize(IModuleRegistrar registrar);
    }
}
