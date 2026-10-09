namespace AppDev.Models;

public sealed class TicketComment
{
	public int Id { get; set; }
	public int TicketId { get; set; }
	public int AuthorId { get; set; }
	public string AuthorName { get; set; } = string.Empty;
	public string Body { get; set; } = string.Empty;
	public DateTime Created { get; set; }

	public MaintenanceTicket? Ticket { get; set; }
	public CampusUser? Author { get; set; }
}
