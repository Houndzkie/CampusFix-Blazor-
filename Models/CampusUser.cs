namespace AppDev.Models;

public sealed class CampusUser
{
	public int Id { get; set; }
	public string SchoolId { get; set; } = string.Empty;
	public string FullName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Role { get; set; } = "Student";
	public string Bio { get; set; } = string.Empty;

	public ICollection<MaintenanceTicket> SubmittedTickets { get; } = new List<MaintenanceTicket>();
	public ICollection<TicketComment> Comments { get; } = new List<TicketComment>();
	public ICollection<TicketNotification> Notifications { get; } = new List<TicketNotification>();
}
