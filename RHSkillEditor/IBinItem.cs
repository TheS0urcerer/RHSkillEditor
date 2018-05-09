﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RohanFile
{
    
    public interface IBinItem<T>
    {
        T Data { get; set; }
        T toStruct();
    }
    
 }
