using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cdjs_home_management.Models.HttpModels
{
    public class TaskRequestModel
    {
        /// <summary>
        ///Name of the User
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Task of the day {eg: dishes,litter}
        /// </summary>
        public int Work{ get; set; }
        /// <summary>
        /// Day of the week {eg: sunday,monday,etc..}
        /// </summary>
        public string Day{ get; set; }
    }
}
