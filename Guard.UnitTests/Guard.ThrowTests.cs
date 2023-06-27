using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guard.UnitTests
{
    public class GuardThrowTests
    {
        [Fact]
        public void Throw_WhenGenericTypeIsDefined_ExceptionIsCaughtInAction_ShouldThrowWithGenericType()
        {
            Assert.Throws<ArithmeticException>(() => Guard.Throw<ArithmeticException>(() => { Guard.ThrowIfLessThan(1, 2, "value"); }));
        }

        [Fact]
        public void Throw_WhenGenericTypeIsDefined_MessageParameterNotNull_ExceptionIsCaughtInAction_ShouldThrowWithGenericTypeAndCustomMessage()
        {
            string message = "Throw an ArithmeticException";
            var exception = Assert.Throws<ArithmeticException>(() => Guard.Throw<ArithmeticException>(() => { Guard.ThrowIfLessThan(1, 2, "value"); }, message));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void Throw_WhenGenericTypeIsNotDefined_ExceptionIsCaughtInAction_ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.Throw(() => { Guard.ThrowIfLessThan(1, 2, "value"); }));
        }

        [Fact]
        public void Throw_WhenGenericTypeIsDefined_NoExceptionIsCaughtInAction_ShouldNotThrow()
        {
            Guard.Throw<ArithmeticException>(() => { Guard.ThrowIfLessThan(3, 2, "value"); });
        }

        [Fact]
        public void Throw_WhenGenericTypeIsDefined_MessageParameterNotNull_NoExceptionIsCaughtInAction_ShouldNotThrow()
        {
            string message = "Throw an ArithmeticException";
            Guard.Throw<ArithmeticException>(() => { Guard.ThrowIfLessThan(3, 2, "value"); }, message);
        }

        [Fact]
        public void Throw_WhenGenericTypeIsNotDefined_NoExceptionIsCaughtInAction_ShouldNotThrow()
        {
            Guard.Throw(() => { Guard.ThrowIfLessThan(3, 2, "value"); });
        }
    }
}
