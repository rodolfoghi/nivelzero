namespace NivelZero.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; } = Guid.NewGuid();

    public DateTime CreatedAt { get; } = DateTime.Now;
}