using Shop.Domain.Infrastructure;
using System.Collections.Generic;

namespace Shop.Application.Cart
{
    [Service]
    public class GetCart
    {
        private ISessionManager _sessionManager;

        public GetCart(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public class Response
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public decimal RealValue { get; set; }
            public int Qty { get; set; }

            public int StockId { get; set; }
        }

        public IEnumerable<Response> Do()
        {
            return _sessionManager
                .GetCart(x => new Response
                {
                    Name = x.ProductName,
                    Value = x.Value.GetValueString(),
                    RealValue = x.Value,
                    StockId = x.StockId,
                    Qty = x.Qty
                });
        }
    }
}
