using System.Collections.Generic;
using Bridges.Models;

namespace Bridges.Services
{
    public class BridgesService
#if DEBUG
    {
        public IList<Bridge> GetBridges => new List<Bridge>
        {
            new Bridge("Image1.jpg", "Image 1"),
            new Bridge("Image2.jpg", "Image 2"),
            new Bridge("Image3.jpg", "Image 3"),
            new Bridge("Image4.jpg", "Image 4"),
            new Bridge("Image5.jpg", "Image 5"),
            new Bridge("Image6.jpg", "Image 6"),
            new Bridge("Image7.jpg", "Image 7"),
            new Bridge("Image8.jpg", "Image 8"),
            new Bridge("Image9.jpg", "Image 9"),
            new Bridge("Image10.jpg", "Image 10")
        };
#else
public IList<Bridge> GetBridges => new List<Bridge>
        {
            new Bridge("Image1.jpg", "Image 1"),
            new Bridge("Image2.jpg", "Image 2"),
            new Bridge("Image3.jpg", "Image 3"),
            new Bridge("Image4.jpg", "Image 4"),
            new Bridge("Image5.jpg", "Image 5"),
            new Bridge("Image6.jpg", "Image 6"),
            new Bridge("Image7.jpg", "Image 7"),
            new Bridge("Image8.jpg", "Image 8"),
            new Bridge("Image9.jpg", "Image 9"),
            new Bridge("Image10.jpg", "Image 10"),
            new Bridge("Image11.jpg", "Image 11"),
            new Bridge("Image12.jpg", "Image 12"),
            new Bridge("Image13.jpg", "Image 13"),
            new Bridge("Image14.jpg", "Image 14"),
            new Bridge("Image15.jpg", "Image 15"),
            new Bridge("Image16.jpg", "Image 16"),
            new Bridge("Image17.jpg", "Image 17"),
            new Bridge("Image18.jpg", "Image 18"),
            new Bridge("Image19.jpg", "Image 19"),
            new Bridge("Image20.jpg", "Image 20"),
            new Bridge("Image21.jpg", "Image 21"),
            new Bridge("Image22.jpg", "Image 22"),
            new Bridge("Image23.jpg", "Image 23"),
            new Bridge("Image24.jpg", "Image 24"),
            new Bridge("Image25.jpg", "Image 25"),
            new Bridge("Image26.jpg", "Image 26"),
            new Bridge("Image27.jpg", "Image 27"),
            new Bridge("Image28.jpg", "Image 28"),
            new Bridge("Image29.jpg", "Image 29"),
            new Bridge("Image30.jpg", "Image 30"),
            new Bridge("Image31.jpg", "Image 31"),
            new Bridge("Image32.jpg", "Image 32"),
            new Bridge("Image33.jpg", "Image 33"),
            new Bridge("Image34.jpg", "Image 34"),
            new Bridge("Image35.jpg", "Image 35"),
            new Bridge("Image36.jpg", "Image 36"),
            new Bridge("Image37.jpg", "Image 37"),
            new Bridge("Image38.jpg", "Image 38"),
            new Bridge("Image39.jpg", "Image 39"),
            new Bridge("Image40.jpg", "Image 40"),
            new Bridge("Image41.jpg", "Image 41"),
            new Bridge("Image42.jpg", "Image 42"),
            new Bridge("Image43.jpg", "Image 43"),
            new Bridge("Image44.jpg", "Image 44"),
            new Bridge("Image45.jpg", "Image 45"),
            new Bridge("Image46.jpg", "Image 46"),
            new Bridge("Image47.jpg", "Image 47"),
            new Bridge("Image48.jpg", "Image 48"),
            new Bridge("Image49.jpg", "Image 49"),
            new Bridge("Image50.jpg", "Image 50"),
            new Bridge("Image51.jpg", "Image 51"),
            new Bridge("Image52.jpg", "Image 52"),
            new Bridge("Image53.jpg", "Image 53"),
            new Bridge("Image54.jpg", "Image 54"),
            new Bridge("Image55.jpg", "Image 55"),
            new Bridge("Image56.jpg", "Image 56"),
            new Bridge("Image57.jpg", "Image 57"),
            new Bridge("Image58.jpg", "Image 58"),
            new Bridge("Image59.jpg", "Image 59"),
            new Bridge("Image60.jpg", "Image 60"),
            new Bridge("Image61.jpg", "Image 61"),
            new Bridge("Image62.jpg", "Image 62")
        };
#endif
    }
}