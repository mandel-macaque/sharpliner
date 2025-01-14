﻿using System.Collections.Generic;

namespace Sharpliner.Model
{
    public record Pipeline(
        string Name,
        Resources Resources,
        IEnumerable<Variable> Variables,
        IEnumerable<Trigger> Triggers,
        IEnumerable<Stage> Stages);
}
