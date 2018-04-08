using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programs
{
    public class ParkingLot
    {
        private Level[] levels;
        //private int Number {get; set;}

        public ParkingLot( )
        {
            levels = new Level[3];
        }

        public void parkIn(vehicle vehicle)
        {
        }
    }

    public class Level
    {
        private ParkingSpot[] parkingSpots;
        private int size;

        public Level (int size)
        {
            this.size= size;
            parkingSpots= new ParkingSpot[size];
        }
    }

    public class ParkingSpot
    {
        public enum parking { Generatl, Reserved, handicap };
        public Boolean isOccupied {get; set;}

        public parking park {get;set;}
    }

    public class vehicle
    {
        public int numberOfSpotsNeed { get; set; }
        public enum vehlicleType { motor, bike, truck };

        public vehlicleType vehicleType { get; set; }

    }
}
