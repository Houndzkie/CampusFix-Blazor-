namespace AppDev.Models;

public sealed class TicketNotification
{
	public int Id { get; set; }
	public int RecipientId { get; set; }
	public int TicketId { get; set; }
	public string Message { get; set; } = string.Empty;
	public DateTime Created { get; set; }
	public bool IsRead { get; set; }

	public CampusUser? Recipient { get; set; }
	public MaintenanceTicket? Ticket { get; set; }
}
