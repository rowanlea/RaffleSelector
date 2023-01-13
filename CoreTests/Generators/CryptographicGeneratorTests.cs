using Core.Generators;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTests.Generators
{
    internal class CryptographicGeneratorTests
    {
        [TestCase(1, 10)]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        public void GetNumberBetween_WhenFirstAndSecondGiven_ResultBetweenTheTwoNumbers(int firstNumber, int secondNumber)
        {
            for (int i = 0; i < 1000; i++)
            {
                int result = CryptographicGenerator.GetNumberBetween(firstNumber, secondNumber);
                result.Should().BeInRange(firstNumber, secondNumber);
            }
        }

        [Test]
        public void GetNumberBetween_WhenRun1000Times_ResultDistributedEvenly()
        {
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            for (int i = 0; i < 1000; i++)
            {
                int result = CryptographicGenerator.GetNumberBetween(1, 10);
                if (frequencies.TryGetValue(result, out _))
                {
                    frequencies[result]++;
                }
                else
                {
                    frequencies.Add(result, 1);
                }
            }
            for (int i = 1; i <= 10; i++)
            {
                frequencies[i].Should().BeGreaterThan(80);
            }
        }
    }
}
