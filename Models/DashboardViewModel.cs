namespace RoleBasedAuthorization.Models
{
    public class DashboardViewModel
    {
        public int admin_count { get; set; }
        public int manager_count { get; set; }
        public int projectmanager_count { get; set; }
        public int projectcoordinator_count { get; set; }

        public int annotator_count { get; set; }
        public int totalusers_count { get; set; }

        public string month_count { get; set; }
        public string annotate_count { get; set; }
        public int sumoftimeactive_count { get; set; }
        public int sumoftimeinactive_count { get; set; }
        public int totaltime_count { get; set; }
        public decimal activehours_count { get; set; }
        public decimal inactivehours_count { get; set; }
        public decimal billableinactivehours_count { get; set; }
        public decimal totalhours_count { get; set; }
        public decimal productivity_count { get; set; }
        public decimal productivitypercentage_count { get; set; }
        public decimal averagerating_count { get; set; }
        public decimal quality_count { get; set; }
        public decimal qualitypercentage_count { get; set; }
        public decimal averagescore_count { get; set; }
        public decimal finalamountpayable_count { get; set; }
        public decimal USDTotal_count { get; set; }
        public string oneformaid_count { get; set; }

        public string dashboardstatus_count { get; set; }
        public string status_count { get; set; }
    }
}
