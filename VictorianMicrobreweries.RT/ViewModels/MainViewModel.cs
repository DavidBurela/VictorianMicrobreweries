using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VictorianMicrobreweries.RT.Helpers;
using VictorianMicrobreweries.RT.Models;

namespace VictorianMicrobreweries.RT.ViewModels
{
    public class MainViewModel
    {
        public SortedObservableCollection<LocationData> Locations { get; set; }

        public MainViewModel()
        {
            Locations = new SortedObservableCollection<LocationData>();

            CreateData();
        }

        private void CreateData()
        {
            Locations.Add(new LocationData { LocationName = "Arctic Fox Brewing", Address = "1/45-47 Sinclair Road, Dandenong", Latitude = -37.988505, Longitude = 145.197162, Phone = "9792 1800", Website = @"http://www.arcticfox.com.au" });
            Locations.Add(new LocationData { LocationName = "Bellarine Brewing Company", Address = "2270 Portarlington Road, Bellarine ", Latitude = -38.137468, Longitude = 144.610376, Phone = "03 5259 3310", Website = @"http://www.bellarineestate.com.au" });
            Locations.Add(new LocationData { LocationName = "Bintara Brewery", Address = "Fraser Road, Rutherglen", Latitude = -36.050597, Longitude = 146.584322, Phone = "0447 327 517", Website = @"http://www.vintara.com.au" });
            Locations.Add(new LocationData { LocationName = "Boynton’s Brewing Company", Address = "6619 Great Alpine Road, Porepunkah", Latitude = -36.675300, Longitude = 146.889032, Phone = "03 5756 2356", Website = @"http://www.boynton.com.au/" });
            Locations.Add(new LocationData { LocationName = "Bridge Road Brewers", Address = "50 Ford St, Beechworth", Latitude = -36.360517, Longitude = 146.685872, Phone = "5728 2703", Website = @"http://www.bridgeroadbrewers.com.au" });
            Locations.Add(new LocationData { LocationName = "Bright Brewery", Address = "121 Great Alpine Road, Bright", Latitude = -36.726597, Longitude = 146.961809, Phone = "03 5755 1301", Website = @"http://www.brightbrewery.com.au" });
            Locations.Add(new LocationData { LocationName = "Buckley’s Beers", Address = "30 Hunter Road, Healesville", Latitude = -37.655065, Longitude = 145.505366, Phone = "03 5962 2701", Website = @"http://www.buckleysbeer.com.au" });
            Locations.Add(new LocationData { LocationName = "Coldstream Brewery", Address = "694 Maroondah Highway, Coldstream", Latitude = -37.724201, Longitude = 145.379153, Phone = "03 9739 1794", Website = @"http://www.coldstreambrewery.com.au" });
            Locations.Add(new LocationData { LocationName = "Flying Horse Bar & Brewery", Address = "10691-10695 Princes Highway, Warrnambool", Latitude = -38.385021, Longitude = 142.533205, Phone = "03 5562 2254", Website = @"http://www.theflyinghorse.com.au" });
            Locations.Add(new LocationData { LocationName = "Grand Ridge Brewery", Address = "1 Baromi Road, Mirboo North", Latitude = -38.400869, Longitude = 146.162129, Phone = "9778 6996", Website = @"http://www.grand-ridge.com.au" });
            Locations.Add(new LocationData { LocationName = "Hargreaves Hill Brewing Co.", Address = "25 Bell Street, Yarra Glen", Latitude = -37.658336, Longitude = 145.374217, Phone = "9730 1905", Website = @"http://www.hargreaveshill.com.au" });
            Locations.Add(new LocationData { LocationName = "Holgate Brewhouse", Address = "79 High Street, Woodend", Latitude = -37.356929, Longitude = 144.527011, Phone = "5427 3522", Website = @"http://www.holgatebrewhouse.com" });
            Locations.Add(new LocationData { LocationName = "James Squire Brewhouse - Portland Hotel", Address = "115-127 Russell Street, Melbourne", Latitude = -37.813510, Longitude = 144.968323, Phone = "03 9810 0064", Website = @"http://www.portlandhotel.com.au" });
            Locations.Add(new LocationData { LocationName = "Jamieson Brewery", Address = "Eildon Road, Jamieson", Latitude = -37.281281, Longitude = 146.131814, Phone = "03 5777 0515", Website = @"http://www.jamiesonbrewery.com.au" });
            Locations.Add(new LocationData { LocationName = "Mildura Brewery", Address = "20 Langtree Avenue, Mildura", Latitude = -34.183338, Longitude = 142.162799, Phone = "5021 5399", Website = @"http://www.mildurabrewery.com.au" });
            Locations.Add(new LocationData { LocationName = "Mountain Goat Brewery", Address = "80 North Street, Richmond", Latitude = -37.816753, Longitude = 145.012984, Phone = "03 9428 1180", Website = @"http://www.goatbeer.com.au" });
            Locations.Add(new LocationData { LocationName = "Otway Estate", Address = "10 - 30 Hoveys Road, Barongarook", Latitude = -38.445039, Longitude = 143.564024, Phone = "5233 8400", Website = @"http://www.otwayestate.com.au" });
            Locations.Add(new LocationData { LocationName = "Red Hill Brewery", Address = "88 Shoreham Road, Red Hill South", Latitude = -38.402759, Longitude = 145.015842, Phone = "03 5989 2959", Website = @"http://www.redhillbrewery.com.au" });
            Locations.Add(new LocationData { LocationName = "Sweetwater Brewery", Address = "211 Kiewa Valley Hwy, Tawonga South", Latitude = -36.736165, Longitude = 147.159068, Phone = "5754 1881", Website = @"http://www.sweetwaterbrewing.com.au" });
            Locations.Add(new LocationData { LocationName = "Temple Brewing Company", Address = "122 Weston Street, Melbourne", Latitude = -37.775964, Longitude = 144.971539, Phone = "0418 557 875", Website = @"http://www.templebrewing.com.au" });
            Locations.Add(new LocationData { LocationName = "The 3 Ravens Brewing Company", Address = "1 Theobald Street, Thornbury", Latitude = -37.755797, Longitude = 145.026785, Phone = "03 9495 1026", Website = @"http://www.3ravens.com.au" });
            Locations.Add(new LocationData { LocationName = "Tooborac Hoand Brewery", Address = "5115 Northern Highway, Tooborac", Latitude = -37.042001, Longitude = 144.798361, Phone = "03 5433 5201", Website = @"http://www.tooborachotel.com.au" });
            Locations.Add(new LocationData { LocationName = "University of Ballarat Brewery", Address = "University Drive, Mt Helen, Ballarat", Latitude = -37.626207, Longitude = 143.891734, Phone = "03 5327 9243", Website = @"http://www.ballarat.edu.au/ard/scieng/courses/food.shtml" });
            Locations.Add(new LocationData { LocationName = "White Rabbit Brewery", Address = "316 Maroondah Highway, Healesville", Latitude = -37.652088, Longitude = 145.521731, Phone = "03 5962 6516", Website = @"http://www.whiterabbitbeer.com.au" });
            Locations.Add(new LocationData { LocationName = "2 Brothers Brewery", Address = "4 Joyner Street , Moorabbin", Latitude = -37.942712, Longitude = 145.068652, Phone = "9553 1177", Website = @"http://www.2brothers.com.au" });
        }
    }
}
