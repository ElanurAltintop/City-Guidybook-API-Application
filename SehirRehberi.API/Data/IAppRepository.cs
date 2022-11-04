using SehirRehberi.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SehirRehberi.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity);
        void Delete<T>(T entity);
        bool SaveAll();

        List<City> GetCities(); //Bütün Şehirleri getirecek
        List<Photo> GetPhotosByCity(int CityId); //Şehirlerin Fotoğrafları gelecek
        City GetCityById(int cityId); //Sadece belli şehrin datasını getirecek

        Photo GetPhoto(int id);
        object GetCityById();
    }
}
