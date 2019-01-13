using Volo.Abp.DependencyInjection;
using Volo.Abp.Guids;

namespace DGCorERM.API
{
    public class APITestDataBuilder : ITransientDependency
    {
        private readonly IGuidGenerator _guidGenerator;
        private APITestData _testData;

        public APITestDataBuilder(
            IGuidGenerator guidGenerator,
            APITestData testData)
        {
            _guidGenerator = guidGenerator;
            _testData = testData;
        }

        public void Build()
        {
            
        }
    }
}