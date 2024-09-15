namespace CodingTrackerLibrary.Models;

internal class CodingSession
{
    public static string[] headers = { "Id", "StartDate", "EndDate", "Duration", "Units" };
    public int? Id { get; set; }
    public string? StartDate { get; set; }
    public string? EndDate { get; set; }
    public float? Duration { get; set; }
    public string? Units { get; set; } 

    public CodingSession(int id, string startDate, string endDate, float duration)
    {
        this.Id = id; 
        this.StartDate = startDate; 
        this.EndDate = endDate;
        this.Duration = duration;
    }

    public CodingSession(int id, string startDate, string endDate, float duration, string units)
    {
        this.Id = id;
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.Duration = duration;
        this.Units = units;
    }

    public CodingSession(string startDate, string endDate, float duration)
    {
        this.StartDate = startDate;
        this.EndDate = endDate;
        this.Duration = duration;
    }

    public CodingSession(string startDate)
    {
        this.StartDate = startDate;
    }

    public CodingSession(int id)
    {
        this.Id = id;
    }
}