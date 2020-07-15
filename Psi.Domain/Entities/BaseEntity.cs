namespace Psi.Domain.Entities
{
    public abstract class BaseEntity<TKeyType, TEntity>
    {
        protected BaseEntity(TKeyType id = default)
        {
            Id = id;
        }

        public virtual TKeyType Id { get; protected set; }
    }
}