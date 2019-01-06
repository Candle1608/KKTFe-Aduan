using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

    namespace EditableListMvc.Models
    {
        public class Complaint
        {
            public int PrimaryKey { get; set; }
            public int ComplaintId { get; set; }
            public string Name { get; set; }

            public string Date { get; set; }
            public string RoomNo { get; set; }
            public string Type { get; set; }
            public string Technician { get; set; }
            public string Status { get; set; }
        public bool Remove { get; internal set; }
    }
}
