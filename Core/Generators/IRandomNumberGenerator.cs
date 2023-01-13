using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace Core.Generators
{
    internal interface IRandomNumberGenerator
    {
        int[] GenerateNumberOfUniquePositions(int maximum, int numberToGenerate);
    }
}
