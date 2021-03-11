using DocManager.Domain.Core.UserEntities;
using System;
using System.Collections.Generic;

namespace DocManager.Domain.Core.OrderEntities
{
    public class DbDocument
    {
        public int Id { get; set; }

        public int SubscriptionId { get; set; }

        public string Species { get; set; }

        public string Name { get; set; }

        public DateTime? Date { get; set; }

        public virtual ICollection<DbDevice> Devices { get; set; }

        public virtual ICollection<DbWeatherDay> WeatherDays { get; set; }

        public int PerfomerId { get; set; }

        public virtual DbPerson Perfomer { get; set; }
    }
}