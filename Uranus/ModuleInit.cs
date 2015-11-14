using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Web;
using Uranus.Domain;
using Uranus.Utility;

namespace Uranus
{
    [Export(typeof(IModule))]
    public class ModuleInit : IModule
    {
        public void Initialize(IModuleRegistrar registrar)
        {
           // registrar.RegisterTypeUsingSetter<GlobalSetupHelper>("CompanyService");
        }

       
    }
}