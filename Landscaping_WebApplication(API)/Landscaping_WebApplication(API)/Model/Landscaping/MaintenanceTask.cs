namespace Landscaping_WebApplication_API_.Model.Landscaping
{
    public class MaintenanceTask
    {
        public int Id {  get; set; }
        public string TaskName { get; set; }
        public int NoOfWorkers { get; set; }

        public DateTime Date { get; set; }
    }
}
