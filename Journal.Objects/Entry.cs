﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal.Data.Objects {
    public class Entry {
        public Guid UID { get; set; }
        public Int64 ID { get; set; }
        public Int64 CreatedByID { get; set; }
        public Int64 ModifiedByID { get; set; }
        public Int64 DeletedByID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public DateTime DeletedOn { get; set; }

        public User CreatedBy { get; set; }
        public User ModifiedBy { get; set; }
        public User DeletedBy { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
