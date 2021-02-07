using Shop.Domain.Infrastructure;
using System.Threading.Tasks;

namespace Shop.Application.StockAdmin
{
    [Service]
    public class DeleteStock
    {
        private IStockManager _stockManager;

        public DeleteStock(IStockManager stockManager)
        {
            _stockManager = stockManager;
        }

        public Task<int> Do(int id)
        {
            return _stockManager.DeleteStock(id);
        }
    }
}
