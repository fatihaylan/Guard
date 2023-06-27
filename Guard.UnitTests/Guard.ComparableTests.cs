using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guard.UnitTests
{
    public class GuardComparableTests
    {
        [Fact]
        public void ThrowIfEqual_WhenValuesNotEqual_ShouldNotThrow()
        {
            Guard.ThrowIfEqual(3, 4, "int");
            Guard.ThrowIfEqual(3.3d, 3.4d, "double");
            Guard.ThrowIfEqual(3.3M, 3.4M, "decimal");
            Guard.ThrowIfEqual(3.3f, 3.4f, "float");
            Guard.ThrowIfEqual(TimeSpan.Zero, TimeSpan.MinValue, "timespan");
            Guard.ThrowIfEqual(DateTime.Now, DateTime.Now.AddMinutes(1), "datetime");
        }

        [Fact]
        public void ThrowIfEqual_WhenValuesEqual_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfEqual(3, 3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfEqual(3.3d, 3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfEqual(3.3M, 3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfEqual(3.3f, 3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfEqual(TimeSpan.Zero, TimeSpan.Zero, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfEqual(DateTime.Now.Date, DateTime.Now.Date, "datetime"));
        }

        [Fact]
        public void ThrowIfNotEqual_WhenValuesEqual_ShouldNotThrow()
        {
            Guard.ThrowIfNotEqual(3, 3, "int");
            Guard.ThrowIfNotEqual(3.3d, 3.3d, "double");
            Guard.ThrowIfNotEqual(3.3M, 3.3M, "decimal");
            Guard.ThrowIfNotEqual(3.3f, 3.3f, "float");
            Guard.ThrowIfNotEqual(TimeSpan.Zero, TimeSpan.Zero, "timespan");
            Guard.ThrowIfNotEqual(DateTime.Now.Date, DateTime.Now.Date, "datetime");
        }

        [Fact]
        public void ThrowIfNotEqual_WhenValuesNotEqual_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotEqual(3, 4, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotEqual(3.3d, 3.4d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotEqual(3.3M, 3.4M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotEqual(3.3f, 3.4f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotEqual(TimeSpan.Zero, TimeSpan.MinValue, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotEqual(DateTime.Now, DateTime.Now.AddMinutes(1), "datetime")); 
        }

        [Fact]
        public void ThrowIfGreaterThan_WhenValueNotGreatherThanOther_ShouldNotThrow()
        {
            Guard.ThrowIfGreaterThan(3, 4, "int");
            Guard.ThrowIfGreaterThan(3.3d, 3.4d, "double");
            Guard.ThrowIfGreaterThan(3.3M, 3.4M, "decimal");
            Guard.ThrowIfGreaterThan(3.3f, 3.4f, "float");
            Guard.ThrowIfGreaterThan(TimeSpan.Zero, TimeSpan.MaxValue, "timespan");
            Guard.ThrowIfGreaterThan(DateTime.Now, DateTime.Now.AddMinutes(1), "datetime");
        }

        [Fact]
        public void ThrowIfGreaterThan_WhenValueGreatherThanOther_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThan(3, 2, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThan(3.3d, 3.2d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThan(3.3M, 3.2M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThan(3.3f, 3.2f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThan(TimeSpan.Zero, TimeSpan.MinValue, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThan(DateTime.Now.AddMinutes(1), DateTime.Now, "datetime"));
        }

        [Fact]
        public void ThrowIfGreaterThanOrEqual_WhenValueNotGreaterThanOther_ShouldNotThrow()
        {
            Guard.ThrowIfGreaterThanOrEqual(3, 4, "int");
            Guard.ThrowIfGreaterThanOrEqual(3.3d, 3.4d, "double");
            Guard.ThrowIfGreaterThanOrEqual(3.3M, 3.4M, "decimal");
            Guard.ThrowIfGreaterThanOrEqual(3.3f, 3.4f, "float");
            Guard.ThrowIfGreaterThanOrEqual(TimeSpan.Zero, TimeSpan.MaxValue, "timespan");
            Guard.ThrowIfGreaterThanOrEqual(DateTime.Now, DateTime.Now.AddMinutes(1), "datetime");
        }

        [Fact]
        public void ThrowIfGreaterThanOrEqual_WhenValueGreaterThanOther_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3, 2, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3.3d, 3.2d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3.3M, 3.2M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3.3f, 3.2f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(TimeSpan.Zero, TimeSpan.MinValue, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(DateTime.Now.AddMinutes(1), DateTime.Now, "datetime"));
        }

        [Fact]
        public void ThrowIfGreaterThanOrEqual_WhenValueEqualToOther_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3, 3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3.3d, 3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3.3M, 3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(3.3f, 3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(TimeSpan.Zero, TimeSpan.Zero, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfGreaterThanOrEqual(DateTime.Now.Date, DateTime.Now.Date, "datetime"));
        }

        [Fact]
        public void ThrowIfLessThan_WhenValueNotLessThanOther_ShouldNotThrow()
        {
            Guard.ThrowIfLessThan(3, 2, "int");
            Guard.ThrowIfLessThan(3.3d, 3.2d, "double");
            Guard.ThrowIfLessThan(3.3M, 3.2M, "decimal");
            Guard.ThrowIfLessThan(3.3f, 3.2f, "float");
            Guard.ThrowIfLessThan(TimeSpan.Zero, TimeSpan.MinValue, "timespan");
            Guard.ThrowIfLessThan(DateTime.Now.AddMinutes(1), DateTime.Now, "datetime");
        }

        [Fact]
        public void ThrowIfLessThan_WhenValueLessThanOther_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThan(3, 4, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThan(3.3d, 3.4d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThan(3.3M, 3.4M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThan(3.3f, 3.4f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThan(TimeSpan.Zero, TimeSpan.MaxValue, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThan(DateTime.Now, DateTime.Now.AddMinutes(1), "datetime"));
        }

        [Fact]
        public void ThrowIfLessThanOrEqual_WhenValueNotLessThanOther_ShouldNotThrow()
        {
            Guard.ThrowIfLessThanOrEqual(3, 2, "int");
            Guard.ThrowIfLessThanOrEqual(3.3d, 3.2d, "double");
            Guard.ThrowIfLessThanOrEqual(3.3M, 3.2M, "decimal");
            Guard.ThrowIfLessThanOrEqual(3.3f, 3.2f, "float");
            Guard.ThrowIfLessThanOrEqual(TimeSpan.Zero, TimeSpan.MinValue, "timespan");
            Guard.ThrowIfLessThanOrEqual(DateTime.Now.AddMinutes(1), DateTime.Now, "datetime");
        }

        [Fact]
        public void ThrowIfLessThanOrEqual_WhenValueLessThanOther_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3, 4, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3.3d, 3.4d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3.3M, 3.4M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3.3f, 3.4f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(TimeSpan.Zero, TimeSpan.MaxValue, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(DateTime.Now, DateTime.Now.AddMinutes(1), "datetime"));
        }

        [Fact]
        public void ThrowIfLessThanOrEqual_WhenValueEqualToOther_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3, 3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3.3d, 3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3.3M, 3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(3.3f, 3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(TimeSpan.Zero, TimeSpan.Zero, "timespan"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfLessThanOrEqual(DateTime.Now.Date, DateTime.Now.Date, "datetime"));
        }

        [Fact]
        public void ThrowIfNegative_WhenValueNotNegative_ShouldNotThrow()
        {
            Guard.ThrowIfNegative(3, "int");
            Guard.ThrowIfNegative(3.3d, "double");
            Guard.ThrowIfNegative(3.3M, "decimal");
            Guard.ThrowIfNegative(3.3f, "float");
            Guard.ThrowIfNegative(TimeSpan.Zero, "timespan");
        }

        [Fact]
        public void ThrowIfNegative_WhenValueNegative_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegative(-3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegative(-3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegative(-3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegative(-3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegative(TimeSpan.MinValue, "timespan"));
        }

        [Fact]
        public void ThrowIfNegativeOrZero_WhenValueNotNegative_ShouldNotThrow()
        {
            Guard.ThrowIfNegativeOrZero(3, "int");
            Guard.ThrowIfNegativeOrZero(3.3d, "double");
            Guard.ThrowIfNegativeOrZero(3.3M, "decimal");
            Guard.ThrowIfNegativeOrZero(3.3f, "float");
            Guard.ThrowIfNegativeOrZero(TimeSpan.MaxValue, "timespan");
        }

        [Fact]
        public void ThrowIfNegativeOrZero_WhenValueZero_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(0, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(0d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(0M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(0f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(TimeSpan.Zero, "timespan"));
        }

        [Fact]
        public void ThrowIfNegativeOrZero_WhenValueNegative_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(-3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(-3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(-3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(-3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNegativeOrZero(TimeSpan.MinValue, "timespan"));
        }

        [Fact]
        public void ThrowIfPositive_WhenValueNotPositive_ShouldNotThrow()
        {
            Guard.ThrowIfPositive(0, "int");
            Guard.ThrowIfPositive(0d, "double");
            Guard.ThrowIfPositive(0M, "decimal");
            Guard.ThrowIfPositive(0f, "float");
            Guard.ThrowIfPositive(TimeSpan.Zero, "timespan");
        }

        [Fact]
        public void ThrowIfPositive_WhenValuePositive_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositive(3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositive(3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositive(3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositive(3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositive(TimeSpan.MaxValue, "timespan"));
        }

        [Fact]
        public void ThrowIfPositiveOrZero_WhenValueNotPositive_ShouldNotThrow()
        {
            Guard.ThrowIfPositiveOrZero(-3, "int");
            Guard.ThrowIfPositiveOrZero(-3.3d, "double");
            Guard.ThrowIfPositiveOrZero(-3.3M, "decimal");
            Guard.ThrowIfPositiveOrZero(-3.3f, "float");
            Guard.ThrowIfPositiveOrZero(TimeSpan.MinValue, "timespan");
        }

        [Fact]
        public void ThrowIfPositiveOrZero_WhenValueZero_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(0, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(0d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(0M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(0f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(TimeSpan.Zero, "timespan"));
        }

        [Fact]
        public void ThrowIfPositiveOrZero_WhenValuePositive_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfPositiveOrZero(TimeSpan.MaxValue, "timespan"));
        }

        [Fact]
        public void ThrowIfZero_WhenValueNotZero_ShouldNotThrow()
        {
            Guard.ThrowIfZero(3, "int");
            Guard.ThrowIfZero(-3.3d, "double");
            Guard.ThrowIfZero(3.3M, "decimal");
            Guard.ThrowIfZero(-3.3f, "float");
            Guard.ThrowIfZero(TimeSpan.MaxValue, "timespan");
        }

        [Fact]
        public void ThrowIfZero_WhenValueZero_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfZero(0, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfZero(0d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfZero(0M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfZero(0f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfZero(TimeSpan.Zero, "timespan"));
        }

        [Fact]
        public void ThrowIfNotZero_WhenValueZero_ShouldNotThrow()
        {
            Guard.ThrowIfNotZero(0, "int");
            Guard.ThrowIfNotZero(0d, "double");
            Guard.ThrowIfNotZero(0M, "decimal");
            Guard.ThrowIfNotZero(0f, "float");
            Guard.ThrowIfNotZero(TimeSpan.Zero, "timespan");
        }

        [Fact]
        public void ThrowIfNotZero_WhenValueNotZero_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotZero(3, "int"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotZero(-3.3d, "double"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotZero(3.3M, "decimal"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotZero(-3.3f, "float"));
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.ThrowIfNotZero(TimeSpan.MaxValue, "timespan"));
        }
    }
}
