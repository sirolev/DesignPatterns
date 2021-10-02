using Chapter2;

namespace Code
{
    public class Chapter2 : IChapter
    {
        void IChapter.Run() {
            WeatherStation weatherStation = new WeatherStation();
        }
    }
}