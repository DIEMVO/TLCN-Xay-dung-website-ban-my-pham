﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebMyPham.Application.Catalog.Products;
using WebMyPham.ViewModels.Catalog.ProductImages;
using WebMyPham.ViewModels.Catalog.Products;
using WebMyPham.ViewModels.Catalog.Products.Manage;

namespace WebMyPham.BackendApi.Controllers
{
    //api//products
    [Route("api/[controller]")] //đường dẫn localhost /controller
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly IPublicProductService _publicProductService;
        private readonly IProductService _ProductService;

        public ProductsController(IProductService manageProductService)
        {
            //_publicProductService = publicProductService;
            _ProductService = manageProductService;
        }
        //http://localhost:port/products
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var products = await _publicProductService.GetAll(request);
        //    return Ok(products);
        //}
        //http://localhost:port/products?pageIndex=1&pageSize=10&CategoryId=
        [HttpGet("public-paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery]GetPublicProductPagingRequest request) //chỉ định dc map từ đâu
        {
            var products = await _ProductService.GetAllByCategoryId(request);
            return Ok(products);
        }
        //http://localhost:post/product/1
        [HttpGet("{productId}")] //routing
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _ProductService.GetById(productId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {

            if (!ModelState.IsValid) //ktra =false
            {
                return BadRequest(ModelState); //trả về modelstate, ktra vali ok k
            }
            var productId = await _ProductService.Create(request);
            if (productId == 0)
                return BadRequest();

            var product = await _ProductService.GetById(productId);

            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut("{productId}")] //các phương thức của restful nếu trùng nhau methou phải phân biệt bằng ameus
        [Consumes("multipart/form-data")] //update toàn bộ là httpputput
        public async Task<IActionResult> Update([FromRoute] int productId, [FromForm]ProductUpdateRequest request) //fromfrom chỉ định quan trọng cho biết requess dc quairing từ đâu
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            request.Id = productId;
            var affectedResult = await _ProductService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _ProductService.Delete(productId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpPatch("{productId}/{newPrice}")] //truyền vào, update 1 phần httppatch 
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _ProductService.UpdatePrice(productId, newPrice);
            if (isSuccessful) //trả về
                return Ok(); //true

            return BadRequest();
        }
        //Images
        [HttpPost("{productId}/images")] //truyền lên image với product id
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _ProductService.AddImage(productId, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _ProductService.GetImageById(imageId); //truyền vào image truyền vào

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image); 
        }
        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _ProductService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok(); //trả về 200
        }
        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _ProductService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _ProductService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }
    }
}