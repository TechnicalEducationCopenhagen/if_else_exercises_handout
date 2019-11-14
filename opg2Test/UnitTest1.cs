using System;
using Xunit;
using System.IO;
using System.Text.RegularExpressions;

using opg2;

namespace opg2Test
{
	public class UnitTest1
	{
		StringWriter output;
		StringReader input;

		String pattern;
		Regex regex;

		public UnitTest1()
		{
			output = new StringWriter();
			Console.SetOut(output);

			input = new StringReader("");
			Console.SetIn(input);
		}

		[Fact]
		public void x5()
		{
			input = new StringReader("5\n");

			Console.SetIn(input);
			Program.Main(new String[] { });
			string resultat = this.output.ToString();

			Assert.Contains(
				"y: 5", resultat
			);

		}

		[Fact]
		public void x0()
		{
			input = new StringReader("0\n");

			Console.SetIn(input);
			Program.Main(new String[] { });
			string resultat = this.output.ToString();

			Assert.Contains(
				"y: 0", resultat
			);

		}

		[Fact]
		public void xMinus5()
		{
			input = new StringReader("-5\n");

			Console.SetIn(input);
			Program.Main(new String[] { });
			string resultat = this.output.ToString();

			Assert.Contains(
				"y: 5", resultat
			);

		}

	}
}
