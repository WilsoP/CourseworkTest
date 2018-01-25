using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Booking
    {

        private int totalDays;
        private int totalGuest;
        private DateTime startDate;
        private DateTime endDate;
        private Boolean breakfast;
        private Boolean dinner;
        private Boolean carHire;


        public int TotalDays
        {
            get { return totalDays; }

            set {

                if (value < 1)
                {
                    throw new ArgumentException(" Cannot stay for 0 days");
                }
                    totalDays = value; }
        }

        public int TotalGuest
        {
            get { return totalGuest; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException(" Cannot have less than one guest");
                }
                totalGuest = value;
            }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Please insert a start date");
                }
                startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Please insert an end date");
                }
                endDate = value; }
        }

        public Boolean Breakfast
        {
            get {return breakfast;}
            set { breakfast = value;}
        }

        public Boolean Dinner
        {
            get { return dinner; }
            set { dinner = value; }
        }

        public Boolean CarHire
        {
            get { return carHire; }
            set { carHire = value; }
        }
    }
}
