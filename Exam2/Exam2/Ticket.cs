using System;

namespace Exam2
{
    class Ticket
    {
        #region ---- Private class props ----
        private int ticketNo;
        private DateTime timeIn;
        private DateTime timeOut;
        private decimal cost;
        #endregion
        #region ---- getters and setters ----
        public int TicketNo { get => ticketNo; set => ticketNo = value; }
        public DateTime TimeIn { get => timeIn; set => timeIn = value; }
        public DateTime TimeOut { get => timeOut; set => timeOut = value; }
        public decimal Cost { get => cost; set => cost = value; }
        #endregion
        #region ---- Constructors ----
        public Ticket() { }

        public Ticket(int ticketNo, DateTime timeIn, DateTime timeOut)
        {
            this.ticketNo = ticketNo;
            this.timeIn = timeIn;
            this.timeOut = timeOut;
        }
        #endregion
        #region ---- Class Methods ----
        /// <summary>
        /// override to ToString method 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ticketInfo = "";
            ticketInfo = $"Ticket #: {TicketNo} Time In: {TimeIn} Time Out: {TimeOut}";
            return ticketInfo;
        }

        /// <summary>
        /// Method recieves the number of time spent in garage
        /// calculates the charge to be collected.
        /// </summary>
        /// <param name="numHrs"></param>
        /// <returns>total charge for parking</returns>
        public decimal CalculateCharge(int numHrs)
        {
            decimal minCharge = 2.0m; // minimum
            decimal maxCharge = 10.0m; // maximum
            int hours = 0;

            if (hours >= 0 && hours <= 3)   // within 3 hour timeframe
            {
                cost = minCharge;
                return cost;
            }
            else if (hours > 3 || hours < 24) // outside of 3 hours
            {
                hours -= 3; // find out the number of hours still in need of charge
                cost = (hours * .5m) + minCharge; // total it
                // check to see if maxcharge is reached or not
                if (cost < maxCharge)
                {
                    return cost;
                }
                else
                {
                    cost = maxCharge;
                    return cost;
                }
            }
            else
            {
                cost = maxCharge;
                return cost;
            }
        }
        #endregion
    }
}
