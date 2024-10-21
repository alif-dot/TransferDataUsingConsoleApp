using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_SDSIS
{
    public class KOTOrderDetail
    {
        #region Scalar properties

        public string Id { get; set; }
        public string KOTOrderMasterId { get; set; }
        public string MOrderNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public string ItemId { get; set; }
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string UOMId { get; set; }
        public decimal OrderedQuantity { get; set; }
        public bool IsSynchronized { get; set; }
        public string SynchronizationType { get; set; }

        #endregion Scalar properties
    }
}
