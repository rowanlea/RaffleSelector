using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Core.Generators
{
    internal interface INumberGenerator
    {
        int[] GenerateRandomNumbers(int maximum, int numberToGenerate);
    }
}
