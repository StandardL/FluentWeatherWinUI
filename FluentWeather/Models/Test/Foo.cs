namespace FluentWeather.Models.Test;

class Foo
{
    public static WeatherLocation FooWeather = new()
    {
        Id = 0,
        LocationName = "北京",
        Weather = new()
        {
            updateTime = DateTime.Now,
            fxLink = "https://www.qweather.com",
            weatherNow = new()
            {
                obsTime = DateTime.Now,
                Temperature = 20,
                FeelsLike = 20,
                Icon = "100",
                Description = "晴",
                Wind360 = 0,
                WindDir = "北风",
                WindScale = 1,
                WindSpeed = 1,
                Humidity = 50,
                Precip = 0,
                Pressure = 1000,
                Vis = 10,
                Cloud = 0
            },
            daily = new()
            {
                new()
                {
                    fxDate = DateTime.Now,
                    sunrise = "06:00",
                    sunset = "18:00",
                    moonrise = "19:00",
                    moonset = "03:00",
                    moonPhase = "满月",
                    moonPhaseIcon = 0,
                    tempMax = 30,
                    tempMin = 10,
                    iconDay = 100,
                    textDay = "晴",
                    iconNight = 100,
                    textNight = "晴",
                    wind360Day = 0,
                    windDirDay = "北风",
                    windScaleDay = "1级",
                    windSpeedDay = 1,
                    wind360Night = 0,
                    windDirNight = "南风",
                    windScaleNight = "2级",
                    windSpeedNight = 2,
                    humidity = 50,
                    precip = 0,
                    pressure = 1000,
                    vis = 10,
                    cloud = 0,
                    uvIndex = 0
                },
                new()
                {
                    fxDate = DateTime.Now.AddDays(1),
                    sunrise = "06:00",
                    sunset = "18:00",
                    moonrise = "19:00",
                    moonset = "03:00",
                    moonPhase = "满月",
                    moonPhaseIcon = 0,
                    tempMax = 26,
                    tempMin = 18,
                    iconDay = 100,
                    textDay = "晴",
                    iconNight = 100,
                    textNight = "晴",
                    wind360Day = 0,
                    windDirDay = "北风",
                    windScaleDay = "1级",
                    windSpeedDay = 1,
                    wind360Night = 0,
                    windDirNight = "南风",
                    windScaleNight = "2级",
                    windSpeedNight = 2,
                    humidity = 50,
                    precip = 0,
                    pressure = 1000,
                    vis = 10,
                    cloud = 0,
                    uvIndex = 0
                }
            },
            minutely = new()
            {
                new()
                {
                    fxTime = DateTime.Now,
                    precip = 15
                },
                new()
                {
                    fxTime = DateTime.Now.AddMinutes(15),
                    precip = 30
                }
            },
            MinutelySummary = "2小时内有雨",
            hourly = new()
            { 
                new()
                {
                    fxTime = DateTime.Now,
                    temp = 20,
                    icon = 100,
                    text = "晴",
                    wind360 = 0,
                    windDir = "北风",
                    windScale = "1级",
                    windSpeed = 1,
                    humidity = 50,
                    pop = 0,
                    precip = 0,
                    pressure = 1000,
                    cloud = 0,
                    dew = 0
                },
                new()
                {
                    fxTime = DateTime.Now.AddHours(1),
                    temp = 21,
                    icon = 100,
                    text = "晴",
                    wind360 = 0,
                    windDir = "北风",
                    windScale = "1级",
                    windSpeed = 1,
                    humidity = 50,
                    pop = 0,
                    precip = 0,
                    pressure = 1000,
                    cloud = 0,
                    dew = 1
                }
            },
            refer = new()
            {
                Sources = new string[] { "Foo假数据" },
                License = new string[] { "MIT" }
            }
        }
    };
}
