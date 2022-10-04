﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronBot.BraincasePreview.Contracts.Services;
public interface IClockCanvasProviderFactory
{
    IClockCanvasProvider CreateClockCanvasProvider(string canvasName);
}