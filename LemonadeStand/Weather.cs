using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    class Weather
    {



        //member variables (HAS A)
        public string currentWeather;
        public string forecastedWeather;
        




        //Constructor (BUILDS OBJECT)
        public Weather()
        {
            currentWeather = null;
            forecastedWeather = null;
        }




        //member methods(CAN DO)
        public void WeatherChooserToday()                   
        {                                                  
            int weatherDecision = RandomNumber(1, 4);
            switch (weatherDecision)
            {
                case 1:
                    currentWeather = "Hot";
                    break;
                case 2:
                    currentWeather = "Cold";
                    break;
                case 3:
                    currentWeather = "Rainy";
                    break;
                case 4:
                    currentWeather = "Nice";
                    break;
                default:
                    UserInterface.WeatherChooserError();
                     break;
            }
        }


        public void WeatherChooserTomorrow()
        {
            int weatherDecision = RandomNumber(1, 4);
            switch (weatherDecision)
            {
                case 1:
                    forecastedWeather = "Hot";
                    break;
                case 2:
                    forecastedWeather = "Cold";
                    break;
                case 3:
                    forecastedWeather = "Rainy";
                    break;
                case 4:
                    forecastedWeather = "Nice";
                    break;
                default:
                    UserInterface.WeatherChooserError();
                    break;
            }
        }


        public int RandomNumber(int min, int max)
        {
            Random rando = new Random();
            return rando.Next(min, max);
        }

        public void WeekOfWeather()
        {
            WeatherChooserToday();
            UserInterface.TodaysWeatherText(this);
            Thread.Sleep(500);
            WeatherChooserTomorrow();
            UserInterface.ForcastedWeatherText(this);
            Thread.Sleep(500);
            WeatherChooserTomorrow();
            UserInterface.ForcastedWeatherText(this);
            Thread.Sleep(500);
            WeatherChooserTomorrow();
            UserInterface.ForcastedWeatherText(this);
            Thread.Sleep(500);
            WeatherChooserTomorrow();
            UserInterface.ForcastedWeatherText(this);
            Thread.Sleep(500);
            WeatherChooserTomorrow();
            UserInterface.ForcastedWeatherText(this);
            Thread.Sleep(500);
            WeatherChooserTomorrow();
            UserInterface.ForcastedWeatherText(this);
        }

        public void OneDayOrSeven()
        {
            string weatherDecision = Console.ReadLine();
            switch (weatherDecision)
            {
                case "One":
                    WeatherChooserToday();
                    UserInterface.TodaysWeatherText(this);
                    break;
                case "Seven":
                    WeekOfWeather();
                    break;               
                default:
                    UserInterface.NotAnOption();
                    OneDayOrSeven();
                    break;
            }
        }



    }   
}


