namespace smartCooker.Models
{
    public class UserWorksInOutlet
    {
        public int Id { get; set; }

        public IdentityUserModel User { get; set; }
        public Outlet Outlet { get; set; }
    }
}
