using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Guard.UnitTests
{
    public class GuardNullTests
    {
        [Fact]
        public void ThrowIfNull_WhenValuesNotNull_ShouldNotThrow()
        {
            Guard.ThrowIfNull(String.Empty, "String");
            Guard.ThrowIfNull(1, "Int");
            Guard.ThrowIfNull(Guid.Empty, "Guid");
            Guard.ThrowIfNull(DateTime.Now, "DateTime");
            Guard.ThrowIfNull(new Object(), "Object");
            Guard.ThrowIfNull(Enumerable.Empty<string>(), "Enumarable");
        }

        [Fact]
        public void ThrowIfNull_WhenValuesNull_ShouldThrow()
        {
            string? str = null;
            int? num = null;
            Guid? guid = null;
            object? obj = null;
            DateTime? datetime = null;
            IEnumerable<string>? list = null;

            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNull(str, nameof(str)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNull(num, nameof(num)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNull(guid, nameof(guid)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNull(datetime, nameof(datetime)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNull(obj, nameof(obj)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNull(list, nameof(list)));
        }


        [Fact]
        public void ThrowIfNotNull_WhenValuesNull_ShouldNotThrow()
        {
            string? str = null;
            int? num = null;
            Guid? guid = null;
            object? obj = null;
            DateTime? datetime = null;
            IEnumerable<string>? list = null;

            Guard.ThrowIfNotNull(str, nameof(str));
            Guard.ThrowIfNotNull(num, nameof(num));
            Guard.ThrowIfNotNull(guid, nameof(guid));
            Guard.ThrowIfNotNull(datetime, nameof(datetime));
            Guard.ThrowIfNotNull(obj, nameof(obj));
            Guard.ThrowIfNotNull(list, nameof(list));
        }

        [Fact]
        public void ThrowIfNotNull_WhenValuesNotNull_ShouldThrow()
        {
            string str = String.Empty;
            int num = 0;
            Guid guid = new Guid();
            object obj = new Object();
            DateTime datetime = DateTime.Now;
            IEnumerable<string> list = Enumerable.Empty<string>();

            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNotNull(str, nameof(str)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNotNull(num, nameof(num)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNotNull(guid, nameof(guid)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNotNull(datetime, nameof(datetime)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNotNull(obj, nameof(obj)));
            Assert.Throws<ArgumentNullException>(() => Guard.ThrowIfNotNull(list, nameof(list)));
        }

        [Fact]
        public void ThrowIfNullOrEmpty_WhenValuesNotEmpty_ShouldNotThrow()
        {
            string? str = "str";
            Guard.ThrowIfNullOrEmpty(str, nameof(str));

            Guid guid = Guid.NewGuid();
            Guard.ThrowIfNullOrEmpty(guid, nameof(guid));

            IEnumerable<string> list = new List<string>() { "str" };
            Guard.ThrowIfNullOrEmpty(list, nameof(list));
        }

        [Fact]
        public void ThrowIfNullOrEmpty_WhenValuesEmpty_ShouldThrow()
        {
            string? str = String.Empty;
            Assert.Throws<ArgumentException>(() => Guard.ThrowIfNullOrEmpty(str, nameof(str)));

            Guid guid = new Guid();
            Assert.Throws<ArgumentException>(() => Guard.ThrowIfNullOrEmpty(guid, nameof(guid)));

            IEnumerable<string> list = new List<string>();
            Assert.Throws<ArgumentException>(() => Guard.ThrowIfNullOrEmpty(list, nameof(list)));
        }

        [Fact]
        public void ThrowIfNullOrWhiteSpace_WhenValuesNotWhiteSpace_ShouldNotThrow()
        {
            string? str = "str";
            Guard.ThrowIfNullOrWhiteSpace(str, nameof(str));
        }

        [Fact]
        public void ThrowIfNullOrWhiteSpace_WhenValuesWhiteSpace_ShouldThrow()
        {
            string? str = "   ";
            Assert.Throws<ArgumentException>(() => Guard.ThrowIfNullOrWhiteSpace(str, nameof(str)));
        }


    }
}
