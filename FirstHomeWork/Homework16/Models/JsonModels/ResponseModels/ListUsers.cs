namespace Homework16.Models.JsonModels.ResponseModels
{
    public class ListUsers
    {
        public int Page { get; set; }
        public int Per_page { get; set; }
        public int Total { get; set; }
        public int Total_pages { get; set; }
        public SingleUser[] Data { get; set; }
    }
}
