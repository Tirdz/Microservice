namespace Microservice.DataAccess.Entities;

public class EntityBase
{
    public long Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
}
