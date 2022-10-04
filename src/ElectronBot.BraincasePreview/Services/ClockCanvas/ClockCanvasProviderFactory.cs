﻿using System;
using System.Collections.Generic;
using ElectronBot.BraincasePreview.Contracts.Services;

namespace ElectronBot.BraincasePreview.Services;
public class ClockCanvasProviderFactory : IClockCanvasProviderFactory
{
    private readonly Dictionary<string, IClockCanvasProvider> _providers = new(StringComparer.Ordinal);
    public ClockCanvasProviderFactory(IEnumerable<IClockCanvasProvider> providers)
    {
        foreach (var provider in providers)
        {
            _providers.Add(provider.Name, provider);
        }
    }
    public IClockCanvasProvider CreateClockCanvasProvider(string canvasName)
    {
        return _providers.ContainsKey(canvasName) ? _providers[canvasName] : null;
    }
}