namespace KEM.EventManager.API.Dto
{
    public class ManagedEventResponseDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}
