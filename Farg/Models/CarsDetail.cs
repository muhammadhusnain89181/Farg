using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Farg.Models
{
    
    public class CarsDetail
    {
        public string Name { get; set; }
        public CarType Type { get; set; }
        public string Model { get; set; }
        public long Price { get; set; }
        public DateTime F_registration { get; set; }
        public string Mileage { get; set; }
        public string Fuel { get; set; }
        public string Engine_size { get; set; }
        public string Power { get; set; }
        public string Gearbox { get; set; }
        public int seats { get; set; }
        public string Doors { get; set; }
        public string Color { get; set; }
        public SearchCriteria SearchCriteria { get; set; } = SearchCriteria.singleName;
        public IList<CarPic> CarPics { get; set; }
    }
    public class CarPic
    {
        /// <summary>
        /// relative path
        /// </summary>
        public string Path { get; set; }
    }
    public enum CarType
    {
        Used,
        New
    }
    public enum SearchCriteria
    {
        singleName,
        Menu
    }
}