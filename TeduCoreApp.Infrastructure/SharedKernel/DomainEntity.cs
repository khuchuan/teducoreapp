namespace TeduCoreApp.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }

        /// <summary>
        /// True if domain entity has and identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}