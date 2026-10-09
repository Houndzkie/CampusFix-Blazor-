# CampusFix class diagram

This diagram models the first database entities for the CampusFix maintenance
request portal. Help Center FAQ entries remain static demo content and are not
included as database entities.

```mermaid
classDiagram
    class CampusUser {
        +int Id
        +string SchoolId
        +string FullName
        +string Email
        +string Role
        +string Bio
    }

    class MaintenanceTicket {
        +int Id
        +int ReporterId
        +string Title
        +string Description
        +string Category
        +string Building
        +string Room
        +string Priority
        +string Status
        +string Assigned
        +DateTime Submitted
    }

    class TicketComment {
        +int Id
        +int TicketId
        +int AuthorId
        +string AuthorName
        +string Body
        +DateTime Created
    }

    class TicketNotification {
        +int Id
        +int RecipientId
        +int TicketId
        +string Message
        +DateTime Created
        +bool IsRead
    }

    CampusUser "1" --> "0..*" MaintenanceTicket : reports
    MaintenanceTicket "1" *-- "0..*" TicketComment : has
    CampusUser "1" --> "0..*" TicketComment : writes
    MaintenanceTicket "1" --> "0..*" TicketNotification : triggers
    CampusUser "1" --> "0..*" TicketNotification : receives
```

`ReporterId`, `TicketId`, `AuthorId`, and `RecipientId` are the foreign-key
fields shown by the associations. Passwords are deliberately excluded from
this initial profile model; authentication should be handled by a secure
identity provider rather than stored as plain text.
