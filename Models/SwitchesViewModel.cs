using System.Collections.Generic;

namespace Commutator.Models
{
    public class SwitchesViewModel
    {
        public List<Switch> Switches { get; set; } = new List<Switch>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SearchQuery { get; set; }
        public string ModelFilter { get; set; }
        public string IpFilter { get; set; }
        public string MacFilter { get; set; }
        public string VlanFilter { get; set; }
        public string InventoryFilter { get; set; }
        public string FloorFilter { get; set; }

    }
}
