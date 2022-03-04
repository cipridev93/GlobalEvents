using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Web.Models.Api
{
    public class CatalogBrowse
    {
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public int NumberOfItems { get; set; }
    }
}
