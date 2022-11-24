﻿#nullable disable
using System;
using System.Collections.Generic;

namespace Space.Models;

public partial class Nebulae
{
    public int NebulaId { get; set; }

    public int ConsId { get; set; }

    public int? GlxId { get; set; }

    public string NebulaName { get; set; }

    public string NebulaType { get; set; }

    public TimeSpan? NebulaRightAscension { get; set; }

    public string NebulaDeclination { get; set; }

    public int? NebulaDistance { get; set; }

    public virtual Constellations Cons { get; set; }

    public virtual Galaxies Glx { get; set; }
}