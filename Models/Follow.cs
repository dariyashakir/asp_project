using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_project.Models
{
    public class Follow
    {
        public int Id { get; set; }
        public int FollowerId { get; set; }
        public virtual User Follower { get; set; }
        public int FollowingId { get; set; }
        public virtual User Following { get; set; }
    }

}