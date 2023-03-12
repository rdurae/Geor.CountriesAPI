using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Geor.CountriesAPI.Application.Dto;
using Geor.CountriesAPI.Authorization.Roles;
using Geor.CountriesAPI.Authorization.Users;
using Geor.CountriesAPI.Roles.Dto;
using Geor.CountriesAPI.Users.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geor.CountriesAPI.Application
{
    public class CountryAppService : CountriesAPIAppServiceBase
    //controlador
    {
        // private readonly IRepository<Country> 
        private readonly IRepository<Country, int> _countryRepository;

        public CountryAppService(IRepository<Country, int> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<string> Test()
        {
            return "Ok";
        }

        public async Task<List<CountryDTO>> GetAllCountries()
        {
            var items = await _countryRepository.GetAllListAsync();
            return items.Select(x => new CountryDTO { Id = x.Id, CountryName = x.CountryName, CountryCode = x.CountryCode }).ToList();
        }

        public async Task DeleteCountry(int id)
        {
            await _countryRepository.DeleteAsync(id);
        }

        public async Task<CountryDTO> CreateCountry(CountryDTO item)
        {
            var countryItem = await _countryRepository.InsertAsync(new Country() { CountryName = item.CountryName, CountryCode = item.CountryCode, Id = item.Id });
            return new CountryDTO { CountryName = item.CountryName, CountryCode = item.CountryCode, Id = item.Id };
        }

        public async Task<CountryDTO> GetCountry(int id)
        {
            var item = await _countryRepository.GetAsync(id);
            return new CountryDTO { CountryName = item.CountryName, CountryCode = item.CountryCode, Id = item.Id };
        }

        public async Task<CountryDTO> UpdateCountry(CountryDTO input)
        {
            //var item = await _countryRepository.FirstOrDefaultAsync(x => x.Id == id);
            await DeleteCountry(input.Id);
            await CreateCountry(input);

            //var item = await _countryRepository.GetAsync(input.Id);
            //return new CountryDTO { CountryName = item.CountryName, CountryCode = item.CountryCode, Id = item.Id };
            //MapToEntity(input, user);
            //ObjectMapper.Map(item, input);
            //ObjectMapper.Map(input, item);
            //ObjectMapper.Map<CountryDTO, Country>(input, item);

            //await _countryRepository.UpdateAsync(item);
            return new CountryDTO { CountryName = input.CountryName, CountryCode = input.CountryCode, Id = input.Id };

            //var newitem = await _countryRepository.UpdateAsync(item);

            ////await _countryRepository.SetCountr(user, input.RoleNames)
            ////await _countryRepository.

            //return new CountryDTO { CountryName = newitem.CountryName, CountryCode = newitem.CountryCode, Id = newitem.Id };
            ////return item == null ? null : new CountryDTO { CountryName = item.CountryName, CountryCode = item.CountryCode, Id = item.Id };
        }
    }
}
