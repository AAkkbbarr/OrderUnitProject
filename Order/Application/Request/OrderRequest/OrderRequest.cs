using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Request.OrderRequest
{
    public class OrderRequest: BaseRequest

    {
    public int Id { get; set; }
    public string Number { get; set; }
    public DateTime Date { get; set; }
    public int ProviderId { get; set; }
    }
}
