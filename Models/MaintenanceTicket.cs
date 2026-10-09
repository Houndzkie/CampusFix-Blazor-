namespace AppDev.Models;

public sealed class MaintenanceTicket
{
	public int Id { get; set; }
	public int ReporterId { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
	public string Category { get; set; } = string.Empty;
	public string Building { get; set; } = string.Empty;
	public string Room { get; set; } = string.Empty;
	public string Priority { get; set; } = "Medium";
	public string Status { get; set; } = "Open";
	public string Assigned { get; set; } = "Unassigned";
	public DateTime Submitted { get; set; }

	public CampusUser? Reporter { get; set; }
	public ICollection<TicketComment> Comments { get; } = new List<TicketComment>();
	public ICollection<TicketNotification> Notifications { get; } = new List<TicketNotification>();
}
