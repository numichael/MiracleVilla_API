using MiracleVillaAPI.Models.Dto;

namespace MiracleVillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id=1, Name="Ocean View", Occupancy= 4, Sqft= 100 },
                new VillaDTO{Id=2, Name="Beach View", Occupancy= 3, Sqft= 300 }
            };
    }
}
