﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.Infra.Interface
{
    public interface IUnityOfWork
    {
        Task Commit();
    }
}
