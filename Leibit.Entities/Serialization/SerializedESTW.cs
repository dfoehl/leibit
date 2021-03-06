﻿using Leibit.Core.Scheduling;
using System;

namespace Leibit.Entities.Serialization
{
    [Serializable]
    public class SerializedESTW
    {
        public string ESTWId { get; set; }
        public LeibitTime Time { get; set; }
        public bool IsActive { get; set; }
    }
}
