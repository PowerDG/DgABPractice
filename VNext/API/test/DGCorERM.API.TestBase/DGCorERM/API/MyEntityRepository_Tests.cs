using System.Threading.Tasks;
using Volo.Abp.Modularity;
using Xunit;

namespace DGCorERM.API
{
    public abstract class MyEntityRepository_Tests<TStartupModule> : APITestBase<TStartupModule>
        where TStartupModule : IAbpModule
    {
        [Fact]
        public async Task Test1()
        {

        }
    }
}
