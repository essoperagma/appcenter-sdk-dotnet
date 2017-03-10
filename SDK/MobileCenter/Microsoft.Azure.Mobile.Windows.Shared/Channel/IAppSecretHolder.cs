﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Azure.Mobile.Channel
{
    /* Capability interface for having an app secret */
    public interface IAppSecretHolder
    {
        string AppSecret { get; }
    }
}
