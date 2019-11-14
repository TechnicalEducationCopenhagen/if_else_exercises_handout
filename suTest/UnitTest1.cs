using System;
using Xunit;
using System.IO;
using System.Text.RegularExpressions;

using su;

namespace suTest
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
        public void alder17()
        {
            input = new StringReader("17\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "Din su er 0", resultat
            );
        }

        [Fact]
        public void alder18()
        {
            input = new StringReader("18\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "Din su er 1382", resultat
            );
        }

        [Fact]
        public void alder19()
        {
            input = new StringReader("19\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "Din su er 1382", resultat
            );
        }

        [Fact]
        public void alder20()
        {
            input = new StringReader("20\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "Din su er 6166", resultat
            );
        }

        [Fact]
        public void alder30()
        {
            input = new StringReader("30\n");

            Console.SetIn(input);
            Program.Main(new String[] { });
            string resultat = this.output.ToString();

            Assert.Contains(
                "Din su er 6166", resultat
            );
        }
    }
}
