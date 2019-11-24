using System;
using System.Collections.Generic;
using System.Text;

namespace cdjs.entities
{
    public class TaskHandler
    {
        public int Id { set; get; }
        /// <summary>
        /// Task for the day. [cant use task as it is a reserrved word]
        /// </summary>
        public Tasks Work { get; set; }
    }
}
