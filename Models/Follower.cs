namespace planetnineserver.Models
{
    public class Follower
    {
        public int FollowerId { get; set; }

        public int FollowerUser { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
    }
}