﻿#nullable disable
using System;
using System.Collections.Generic;

namespace Space.Models;

public partial class Comets
{
    public int CometId { get; set; }

    public int? StarId { get; set; }

    public string CometName { get; set; }

    public double? CometOrbitalPeriod { get; set; }

    public double? CometSemiMajorAxis { get; set; }

    public double? CometPerihelion { get; set; }

    public double? CometEccentricity { get; set; }

    public double? CometOrbitalInclination { get; set; }

    public virtual Stars Star { get; set; }
}