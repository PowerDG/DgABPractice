
using AutoMapper;
using RQCore.RQEnitity;
using RQCore.RQEnitity.Dtos;

namespace RQCore.RQEnitity.Mapper
{

	/// <summary>
    /// 配置Invoice的AutoMapper
    /// </summary>
	internal static class InvoiceMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Invoice,InvoiceListDto>();
            configuration.CreateMap <InvoiceListDto,Invoice>();

            configuration.CreateMap <InvoiceEditDto,Invoice>();
            configuration.CreateMap <Invoice,InvoiceEditDto>();

        }
	}
}
