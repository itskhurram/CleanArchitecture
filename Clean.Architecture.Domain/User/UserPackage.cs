﻿using System;

namespace Clean.Architecture.Domain.User {
    public class UserPackage {
        public long ID { get; set; }
        public long UserId { get; set; }
        public int PackageId { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
