﻿using Clean.Architecture.Domain.Defination;

using System.Collections.Generic;

namespace Clean.Architecture.Application.Interfaces.Application.Defination {
    public interface ISufixService {
        IEnumerable<Sufix> GetSufixes();

    }
}
