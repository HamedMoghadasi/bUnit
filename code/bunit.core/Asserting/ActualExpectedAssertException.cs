using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunit.Asserting
{
	/// <summary>
	/// Represents a generic assert exception used when an actual result does not match an expected result.
	/// </summary>
	public class ActualExpectedAssertException : Exception
	{
		/// <summary>
		/// Creates an instance of the <see cref="ActualExpectedAssertException"/>.
		/// </summary>
		/// <param name="actual">The actual result</param>
		/// <param name="expected">The expected result</param>
		/// <param name="actualText">A text explaining the actual result</param>
		/// <param name="expectedText">A text explaining the expected result</param>
		/// <param name="message">An error message explaining the context of the assertion</param>
		public ActualExpectedAssertException(string actual, string expected, string actualText, string expectedText, string message)
			: base(CreateMessage(actual, expected, actualText, expectedText, message))
		{
		}

		private static string CreateMessage(string actual, string expected, string actualText, string expectedText, string message)
		{
			return $"{message}{Environment.NewLine}{actualText}: {actual}{Environment.NewLine}{expectedText}: {expected}";
		}
	}
}
