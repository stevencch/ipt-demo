namespace Demo.Ipt.Web.Core.Entities;
public abstract class BaseEntity
{
    public virtual int Id { get; protected set; }
    public DateTime DateCreated { get; protected set; }
    public DateTime DateModified { get; protected set; }
}
