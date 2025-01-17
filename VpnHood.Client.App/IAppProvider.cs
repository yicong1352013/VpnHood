﻿using System;
using VpnHood.Client.Device;

namespace VpnHood.Client.App;

public interface IAppProvider
{
    IDevice Device { get; }
    bool IsLogToConsoleSupported { get; }
    Uri? AdditionalUiUrl { get; }
    Uri? UpdateInfoUrl { get; }
}