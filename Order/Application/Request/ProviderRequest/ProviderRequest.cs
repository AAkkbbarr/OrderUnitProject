using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.ProviderRequest
{
    public class ProviderRequest : BaseRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
