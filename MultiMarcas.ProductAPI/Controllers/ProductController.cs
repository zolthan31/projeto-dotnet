﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiMarcas.ProductAPI.Data.ValueObjects;
using MultiMarcas.ProductAPI.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MultiMarcas.ProductAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository ?? throw new
                ArgumentNullException(nameof(repository));
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductVO>> FindById(long id)
        {
            var product = await _repository.FindById(id);
            if (product.Id <= 0)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductVO>>> FindAll()
        {
            var products = await _repository.FindAll();            
            return Ok(products);
        }
        [HttpPost]
        public async Task<ActionResult<ProductVO>> Created(ProductVO vo)
        {           
            if (vo == null)
            {
                return BadRequest();
            }
            var product = await _repository.Create(vo);
            return Ok(product);
        }
        [HttpPut]
        public async Task<ActionResult<ProductVO>> Update(ProductVO vo)
        {
            if (vo == null)
            {
                return BadRequest();
            }
            var product = await _repository.Update(vo);
            return Ok(product);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) {
                return BadRequest(); 
            }
            return Ok(status);
        }
    }
}
