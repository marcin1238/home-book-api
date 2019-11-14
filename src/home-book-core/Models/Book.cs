using System;

namespace HomeBook.Core.Models
{
    public class Book
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public override bool Equals(object value)
        {
            Book book = value as Book;

            return (book != null)
                && (Key == book.Key)
                && (Name == book.Name)
                && (CreatedAt == book.CreatedAt)
                && (Pages == book.Pages);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Key: {Key}, Title: {Name}, Pages: {Pages}, CreatedAt: {CreatedAt},";
        }
    }
}