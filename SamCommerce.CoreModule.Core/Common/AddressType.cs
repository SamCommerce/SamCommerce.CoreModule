using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCommerce.CoreModule.Core.Common
{
    [Flags]
    public enum AddressType
    {
        Undefined = 0,
        Billing = 1,
        Shipping = 2,
        Pickup = 4,
        BillingAndShipping = Billing | Shipping
    }
}