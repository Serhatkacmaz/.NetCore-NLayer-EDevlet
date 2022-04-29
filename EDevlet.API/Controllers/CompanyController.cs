using AutoMapper;
using EDevlet.Core.DTOs;
using EDevlet.Core.Models;
using EDevlet.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EDevlet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IService<Company> _companyService;

        public CompanyController(IMapper mapper, IService<Company> companyService)
        {
            _mapper = mapper;
            _companyService = companyService;
        }

        //GET api/company
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var companies = await _companyService.GetAllAsync();
            var companiesDtos = _mapper.Map<List<CompanyDto>>(companies.ToList());
            return CreateActionResult(CustomResponseDto<List<CompanyDto>>.Success(200, companiesDtos));
        }

        //GET api/company/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var company = await _companyService.GetByIdAsync(id);
            var companyDto = _mapper.Map<CompanyDto>(company);
            return CreateActionResult(CustomResponseDto<CompanyDto>.Success(200, companyDto));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CompanyDto companyDto)
        {
            var company = await _companyService.AddAsync(_mapper.Map<Company>(companyDto));
            var companysDto = _mapper.Map<CompanyDto>(company);
            return CreateActionResult(CustomResponseDto<CompanyDto>.Success(201, companysDto));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CompanyDto productDto)
        {
            await _companyService.UpdateAsync(_mapper.Map<Company>(productDto));
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        //DELETE api/company/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var company = await _companyService.GetByIdAsync(id);
            await _companyService.RemoveAsync(company);
            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

    }
}
