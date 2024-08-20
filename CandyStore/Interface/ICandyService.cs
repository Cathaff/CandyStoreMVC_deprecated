using CandyStore.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CandyStore.Interface
{
    public interface ICandyService
    {
        Task<List<CandyDto>> GetAllCandies();


    }
}
