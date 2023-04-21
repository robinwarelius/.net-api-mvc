using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.DbContext.Db;
using API.Models.Entities;
using API.Models.DTO.Product;
using API.Helpers.Repositories;
using API.Filters;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;

        public ProductController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/Product
        // <-*-> ALL PRODUCTS
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetProductsAsync()
        {
            List<ProductResponseDTO> response = await _productRepository.GetProductsAsync();

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);
        }


        // GET: api/Product/5
        // <-*-> GET PRODUCT
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseDTO>> GetProductAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var response = await _productRepository.GetProductAsync(id);
            if (response == null)
            {
                return Problem(detail: "Invalid Id", statusCode: 400, title: "Product Search");
            }

            return Ok(response);
        }


        // POST: api/Product/GetSortedProductsAsync
        // <-*-> GET SORTED PRODUCTS
       
        [HttpGet("/api/Product/GetSortedProducts/{category}")]
        public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetSortedProductsAsync(string? category)
        {
            if (category == null)
            {
                return NotFound();
            }

            List<ProductResponseDTO> response = await _productRepository.GetSortedProductsAsync(category);

            if (response == null)
            {
                return NotFound();
            }

            return Ok(response);

        }

        // POST: api/Product
        // <-*-> POST PRODUCT

        [HttpPost]
        [Authorize(Roles = ("Admin, ProductManager"))]
        public async Task<ActionResult<ProductResponseDTO>> PostProductAsync(ProductAddRequestDTO? productAddRequestDTO)
        {
            if(!ModelState.IsValid)
            {
                string errorMessage = string.Join(" | ", ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage));
                return Problem(errorMessage);
            }
        
            ProductResponseDTO? response = await _productRepository.PostProductAsync(productAddRequestDTO);

            if (response == null)
            {
                return NotFound();
            }

            return NoContent();
      
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin, ProductManager")]
        public async Task<ActionResult> DeleteProductAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            bool response = await _productRepository.DeleteProductAsync(id);

            if (!response)
            {
                return NotFound();
            }
         
            return NoContent();
        }     
    }
}



