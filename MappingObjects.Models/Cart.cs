using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Entities;

public record class Cart
(
    Customer Customer,
    List<LineItem> Items
);
