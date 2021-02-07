using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductsAdmin;
using System.Threading.Tasks;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    [Authorize(Policy = "Manager")]
    public class ProductsController : Controller
    {
        [HttpGet("")]
        public IActionResult GetProducts([FromServices] GetProducts getProducts) =>
            Ok(getProducts.Do());

        [HttpGet("{id}")]
        public IActionResult GetProduct(
            int id,
            [FromServices] GetProduct getProduct) =>
            Ok(getProduct.Do(id));

        [HttpPost("")]
        public async Task<IActionResult> CreateProduct(
            [FromBody] CreateProduct.Request request,
            [FromServices] CreateProduct createProduct) =>
            Ok((await createProduct.Do(request)));

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(
            int id,
            [FromServices] DeleteProduct deleteProduct) =>
            Ok((await deleteProduct.Do(id)));

        [HttpPut("")]
        public async Task<IActionResult> UpdateProduct(
            [FromBody] UpdateProduct.Request request,
            [FromServices] UpdateProduct updateProduct) =>
            Ok((await updateProduct.Do(request)));
    }
}