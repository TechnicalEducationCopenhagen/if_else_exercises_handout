using System;
using Xunit;
using System.IO;
using System.Text.RegularExpressions;

using skudaar;

namespace skudaarTest
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
        public void aar1984()
        {
            input = new StringReader("1984\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "1984 ER skudår!", resultat
            );

        }

        [Fact]
        public void aar1986()
        {
            input = new StringReader("1986\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "1986 er IKKE skudår!", resultat
            );

        }

        [Fact]
        public void aar1900()
        {
            input = new StringReader("1900\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "1900 er IKKE skudår!", resultat
            );

        }

        [Fact]
        public void aar2020()
        {
            input = new StringReader("2020\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "2020 ER skudår!", resultat
            );

        }

        [Fact]
        public void aar2019()
        {
            input = new StringReader("2019\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "2019 er IKKE skudår!", resultat
            );

        }
    }
}
