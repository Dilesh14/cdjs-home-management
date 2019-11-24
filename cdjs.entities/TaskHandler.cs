using System;
using System.Collections.Generic;
using System.Text;

namespace cdjs.entities
{
    public class TaskHandler
    {
        public int UsersId { set; get; }
        public int Id { get; set; }
        /// <summary>
        /// Task for the day. [cant use task as it is a reserrved word]
        /// </summary>
        public Tasks Work { get; set; }
        public Days Day { get; set; }
    }
}
