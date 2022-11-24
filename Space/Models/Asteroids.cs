﻿#nullable disable
using System;
using System.Collections.Generic;

namespace Space.Models;

public partial class Asteroids
{
    public int AstId { get; set; }

    public int? StarId { get; set; }

    public string AstName { get; set; }

    public int? AstDiameter { get; set; }

    public double? AstOrbitalEccentricity { get; set; }

    public double? AstOrbitalInclination { get; set; }

    public double? AstArgumentOfPerihelion { get; set; }

    public double? AstMeanAnomaly { get; set; }

    public virtual Stars Star { get; set; }
}