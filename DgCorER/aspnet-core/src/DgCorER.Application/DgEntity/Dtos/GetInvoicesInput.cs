
using Abp.Runtime.Validation;
using DgCorER.Dtos;
using RQCore.RQEnitity;

namespace RQCore.RQEnitity.Dtos
{
    public class GetInvoicesInput : PagedSortedAndFilteredInputDto, IShouldNormalize
    {

        /// <summary>
        /// 正常化排序使用
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }

    }
}
