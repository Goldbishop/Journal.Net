using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Journal.Data.Objects {
    public class User {
        public Guid UID { get; set; }
        public Int64 ID { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
    
    }
}
