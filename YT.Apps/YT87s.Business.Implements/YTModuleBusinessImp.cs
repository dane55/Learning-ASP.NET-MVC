﻿using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT87s.Business.Service;
using YT87s.Database.Service;
using YT87s.Entities;
using YT87s.ViewModels;

namespace YT87s.Business.Implements
{
    public class YTModuleBusinessImp : IYTModuleBusiness
    {
        [Dependency]
        public IYTModuleRepository Rep { get; set; }

        public List<SysModule> GetMenuByPersonId(string personId, string moduleId)
        {
            return Rep.GetMenuByPersonId(personId, moduleId);
        }
    }
}