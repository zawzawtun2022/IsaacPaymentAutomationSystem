namespace RoleBasedAuthorization.Controllers
{
    public class UserData
    {
        public string UserID { get; set;}
        public string UserGroup { get; set;}

        public string AccountID { get; set;}
        public string ProjectID { get; set;}
        public string Ticket { get; set;}
        public string JobID { get; set;}
        public string JobName { get; set;}
        public string JobTag { get; set; }
        public string PluginName { get; set; }
        public string PluginVersion { get; set; }
        public string timestampStartUTC { get; set; }
        public string timestampEndUTC { get; set; }
        public string AnnotationsAdded { get; set; }
        public string AnnotationsDeleted { get; set; }
        public string AnnotationsChanged { get; set; }
        public string TasksSolved { get; set; }
        public string TasksSubmitted { get; set; }
        public string TimeBillable { get; set; }
        public string TimeActive { get; set; }
        public string TimeInActive { get; set; }
        public string TimeNetwork { get; set; }
        public string TimeTotal { get; set; }
        public string TimePerTask { get; set; }
        public string NumberOfTasksWorked_Between_0_5 { get; set; }
        public string NumberOfTasksWorked_Between_5_10 { get; set; }
        
        public string NumberOfTasksWorked_Between_10_20 { get; set; }
                        
        public string NumberOfTasksWorked_Between_20_40 { get; set; }
        public string NumberOfTasksWorked_Between_40_80 { get; set; }
        public string NumberOfTasksWorked_Between_80_160 { get; set; }
        
        public string NumberOfTasksWorked_Between_160_320 { get; set; }
  
        public string NumberOfTasksWorked_Between_320_640 { get; set; }
        public string NumberOfTasksWorked_Between_640_1280 { get; set; }
        public string NumberOfTasksWorked_Between_1280_2560 { get; set; }
        public string NumberOfTasksWorked_Between_2560_5120 { get; set; }
        public string NumberOfTasksWorked_Between_longer_5120 { get; set; }
    }
}