﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DDEXFactory.Interfaces
{
    public interface IXmlGenerationForm: IDisposable
    {
        IXmlObject GetXmlObject();
        IXmlGenerationFactory Factory { get; }
    }
}
