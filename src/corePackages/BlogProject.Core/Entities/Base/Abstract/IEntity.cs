namespace BlogProject.Core.Entities.Base.Abstract
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }


    }
}
