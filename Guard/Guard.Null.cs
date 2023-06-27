using System.Diagnostics.CodeAnalysis;

namespace Guard
{
    public static partial class Guard
    {
        public static T ThrowIfNull<T>([NotNull] T value, string paramName, string? message = null)
        {
            if (value is null)
                throw new ArgumentNullException(paramName, message ?? $"{paramName} cannot be null.");

            return value;
        }

        public static T ThrowIfNotNull<T>([NotNull] T value, string paramName, string? message = null)
        {
            if (value is not null)
                throw new ArgumentNullException(paramName, message ?? $"{paramName} must be null.");

            return value;
        }

        public static string ThrowIfNullOrEmpty(string? value, string paramName, string? message = null)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException(message ?? $"{paramName} cannot be null or empty.", paramName);

            return value;
        }

        public static string ThrowIfNullOrWhiteSpace(string? value, string paramName, string? message = null)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentException(message ?? $"{paramName} cannot be null or empty.", paramName);

            return value;
        }

        public static Guid ThrowIfNullOrEmpty(Guid? value, string paramName, string? message = null)
        {
            Guard.ThrowIfNull(value, paramName, message);

            if (value == Guid.Empty)
                throw new ArgumentException(message ?? $"{paramName} cannot be empty.", paramName);

            return value.Value;
        }

        public static IEnumerable<T> ThrowIfNullOrEmpty<T>([NotNull] IEnumerable<T>? value, string paramName, string? message = null)
        {
            Guard.ThrowIfNull(value, paramName, message);

            if (!value.Any())
                throw new ArgumentException(message ?? $"{paramName} cannot be empty.", paramName);

            return value;
        }
    }
}
