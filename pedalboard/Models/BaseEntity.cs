using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedalboard.Models {
    abstract class BaseEntity {
        protected BaseEntity() {
            // Generate a unique ID
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
        public string Name { get; set; }
    }
}