using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace DGCorERM.API.EntityFrameworkCore
{
    public class APIModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public APIModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = APIConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = APIConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}