using System;

namespace HomeBook.Core.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public string EntityType { get; }

        public string EntityKey { get; }

        public EntityNotFoundException(string entityType, string entityKey)
            : base($"{entityType} ({entityKey}) was not found.")
        {
            EntityType = entityType;
            EntityKey = entityKey;
        }

        public EntityNotFoundException(string entityType, string entityKey, Exception innerException)
            : base($"{entityType} ({entityKey}) was not found.", innerException)
        {
            EntityType = entityType;
            EntityKey = entityKey;
        }
    }
}