using System.Collections.Generic;
using Bridges.Models;

namespace Bridges.Services
{
    public class BridgesService
    {
// #if DEBUG
//        public IList<Bridge> GetBridges => new List<Bridge>
//        {
//            new Bridge("Image1.jpg", "Image 1", "desc"),
//            new Bridge("Image2.jpg", "Image 2", "desc"),
//            new Bridge("Image3.jpg", "Image 3", "desc"),
//            new Bridge("Image4.jpg", "Image 4", "desc")
//        };
//#else
        public IList<Bridge> GetBridges => new List<Bridge>
        {
            new Bridge("Image1.jpg", "Image 1", "desc"),
            new Bridge("Image2.jpg", "Image 2", "desc"),
            new Bridge("Image3.jpg", "Image 3", "desc"),
            new Bridge("Image4.jpg", "Image 4", "desc"),
            new Bridge("Image5.jpg", "Image 5", "desc"),
            new Bridge("Image6.jpg", "Image 6", "desc"),
            new Bridge("Image7.jpg", "Image 7", "desc"),
            new Bridge("Image8.jpg", "Image 8",
                "This is a bridge.\n" +
                "Some info when lazy bones gets round to it.\n" +
                "Some more info......\n" +
                "Some more info......\n" +
                "Some more info......\n" +
                "Some more info......\n" +
                "Some more info......\n" +
                "Some more info......\n" +
                "Some more info......\n",
                52.7831845656961, -1.933417902451652),
            new Bridge("Image9.jpg", "Image 9", "desc"),
            new Bridge("Image10.jpg", "Image 10", "desc"),
            new Bridge("Image11.jpg", "Image 11", "desc"),
            new Bridge("Image12.jpg", "Image 12", "desc"),
            new Bridge("Image13.jpg", "Image 13", "desc"),
            new Bridge("Image14.jpg", "Image 14", "desc"),
            new Bridge("Image15.jpg", "Image 15", "desc"),
            new Bridge("Image16.jpg", "Image 16", "desc"),
            new Bridge("Image17.jpg", "Image 17", "desc"),
            new Bridge("Image18.jpg", "Image 18", "desc"),
            new Bridge("Image19.jpg", "Image 19", "desc"),
            new Bridge("Image20.jpg", "Image 20", "desc"),
            new Bridge("Image21.jpg", "Image 21", "desc"),
            new Bridge("Image22.jpg", "Image 22", "desc"),
            new Bridge("Image23.jpg", "Image 23", "desc"),
            new Bridge("Image24.jpg", "Image 24", "desc"),
            new Bridge("Image25.jpg", "Image 25", "desc"),
            new Bridge("Image26.jpg", "Image 26", "desc"),
            new Bridge("Image27.jpg", "Image 27", "desc"),
            new Bridge("Image28.jpg", "Image 28", "desc"),
            new Bridge("Image29.jpg", "Image 29", "desc"),
            new Bridge("Image30.jpg", "Image 30", "desc"),
            new Bridge("Image31.jpg", "Image 31", "desc"),
            new Bridge("Image32.jpg", "Image 32", "desc"),
            new Bridge("Image33.jpg", "Image 33", "desc"),
            new Bridge("Image34.jpg", "Image 34", "desc"),
            new Bridge("Image35.jpg", "Image 35", "desc"),
            new Bridge("Image36.jpg", "Image 36", "desc"),
            new Bridge("Image37.jpg", "Image 37", "desc"),
            new Bridge("Image38.jpg", "Image 38", "desc"),
            new Bridge("Image39.jpg", "Image 39", "desc"),
            new Bridge("Image40.jpg", "Image 40", "desc"),
            new Bridge("Image41.jpg", "Image 41", "desc"),
            new Bridge("Image42.jpg", "Image 42", "desc"),
            new Bridge("Image43.jpg", "Image 43", "desc"),
            new Bridge("Image44.jpg", "Image 44", "desc"),
            new Bridge("Image45.jpg", "Image 45", "desc"),
            new Bridge("Image46.jpg", "Image 46", "desc"),
            new Bridge("Image47.jpg", "Image 47", "desc"),
            new Bridge("Image48.jpg", "Image 48", "desc"),
            new Bridge("Image49.jpg", "Image 49", "desc"),
            new Bridge("Image50.jpg", "Image 50", "desc"),
            new Bridge("Image51.jpg", "Image 51", "desc"),
            new Bridge("Image52.jpg", "Image 52", "desc"),
            new Bridge("Image53.jpg", "Image 53", "desc"),
            new Bridge("Image54.jpg", "Image 54", "desc"),
            new Bridge("Image55.jpg", "Image 55", "desc"),
            new Bridge("Image56.jpg", "Image 56", "desc"),
            new Bridge("Image57.jpg", "Image 57", "desc"),
            new Bridge("Image58.jpg", "Image 58", "desc"),
            new Bridge("Image59.jpg", "Image 59", "desc"),
            new Bridge("Image60.jpg", "Image 60", "desc"),
            new Bridge("Image61.jpg", "Image 61", "desc"),
            new Bridge("Image62.jpg", "Image 62", "desc")
        };

//#endif
    }
}