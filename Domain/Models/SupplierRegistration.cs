using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{

        public class SupplierRegistration: Entity
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Responsible { get; set; }

            public int Email { get; set; }

            public int Telephone { get; set; }

            public int Whatsapp { get; set; }

        }
}
