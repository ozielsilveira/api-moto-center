﻿
namespace MotoCenter.API
{
    internal class WeatherForecast
    {
        private DateOnly dateOnly;
        private int v1;
        private string v2;

        public WeatherForecast(DateOnly dateOnly, int v1, string v2)
        {
            this.dateOnly = dateOnly;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}