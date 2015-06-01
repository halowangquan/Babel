﻿using System.Reflection;
using Abp.Modules;

namespace ABPSingleDemo
{
    public class ABPSingleDemoCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
