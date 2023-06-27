using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guard
{
    public static partial class Guard
    {
        public static T ThrowIfEqual<T>(T value, T other, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.Equals(other))
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be {other}.");

            return value;
        }

        public static T ThrowIfNotEqual<T>(T value, T other, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (!value.Equals(other))
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} must be {other}.");

            return value;
        }

        public static T ThrowIfGreaterThan<T>(T value, T other, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(other) > 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be greater than {other}.");

            return value;
        }

        public static T ThrowIfGreaterThanOrEqual<T>(T value, T other, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            Guard.ThrowIfEqual(value, other, paramName, message);

            if (value.CompareTo(other) >= 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be greater than or equal {other}.");

            return value;
        }

        public static T ThrowIfLessThan<T>(T value, T other, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(other) < 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be less than {other}.");

            return value;
        }

        public static T ThrowIfLessThanOrEqual<T>(T value, T other, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            Guard.ThrowIfEqual(value, other, paramName, message);

            if (value.CompareTo(other) <= 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be less than or equal {other}.");

            return value;
        }

        public static T ThrowIfNegative<T>(T value, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(default(T)) < 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be negative.");

            return value;
        }

        public static T ThrowIfNegativeOrZero<T>(T value, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(default(T)) <= 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be zero or negative.");

            return value;
        }

        public static T ThrowIfPositive<T>(T value, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(default(T)) > 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be negative.");

            return value;
        }

        public static T ThrowIfPositiveOrZero<T>(T value, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(default(T)) >= 0)
                throw new ArgumentOutOfRangeException(message ?? $"{paramName} cannot be zero or negative.", paramName);

            return value;
        }

        public static T ThrowIfZero<T>(T value, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (value.CompareTo(default(T)) == 0)
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} cannot be zero.");

            return value;
        }

        public static T ThrowIfNotZero<T>(T value, string paramName, string? message = null) where T : struct, IComparable, IComparable<T>
        {
            if (!value.Equals(default(T)))
                throw new ArgumentOutOfRangeException(paramName, message ?? $"{paramName} must be zero.");

            return value;
        }
    }
}
