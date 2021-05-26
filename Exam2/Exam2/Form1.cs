using System;
using System.Windows.Forms;
using System.Xml;

namespace Exam2
{
    public partial class Form1 : Form
    {
        #region ----- Form Properties -----
        int pkSpotOpen = 25;
        int tkNum = 0;
        int currentTik;
        Ticket tik = new Ticket();
        #endregion

        #region ----- Form Control Methods -----
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            EnterLot();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            ExitLot();
        }

        private void tixList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTicket();
        }
        #endregion
        #region ----- Form Method for Data Creation -----
        /// <summary>
        /// This method counts the number of spots open in the garage
        /// if there is space a new ticktet instance is created
        /// </summary>
        public void EnterLot()
        {
            if (pkSpotOpen > 0)
            {
                tik = new Ticket(); // new ticket instance
                DateTime today = DateTime.Now;  // logs the date and time entered
                tkNum += 1;                     // gives ticket number
                tik.TicketNo = tkNum;
                tik.TimeIn = today;
                tik.TimeOut = today;

                pkSpotOpen -= 1;
                lblRemain.Text = pkSpotOpen.ToString(); // Update to user how many spots remain

                tixList.Items.Add(tik);
            }
            else
            {
                MessageBox.Show("Garage is full."); // Message when garage is out of spaces
            }
        }

        /// <summary>
        /// Logs the number of spots opening up after cars leave
        /// when leaving the user is informed of time spent and charged 
        /// ticket gets logged into the xml file afterwards
        /// </summary>
        public void ExitLot()
        {
            if (pkSpotOpen > 0 && pkSpotOpen < 25)
            {
                DateTime exitTime = DateTime.Now;
                tik.TimeOut = exitTime;             // update to ticket field
                tixView.Items.Add(tik);             // ticket appears in second box 
                pkSpotOpen += 1;
                lblRemain.Text = pkSpotOpen.ToString();
                TotalTime();                                //time and cost measured here
                WriteXML();                                 // info shipped to xml file and stored
                tixList.Items.RemoveAt(currentTik);         // last two remove tickets so they can't cause errors
                tixView.Items.Clear();
            }
            else
            {
                pkSpotOpen = 25;
                lblRemain.Text = pkSpotOpen.ToString();
                MessageBox.Show("All spaces are available.");
            }
        }

        /// <summary>
        /// Method is used to selected a specific instance of a ticket
        /// Show selection in bottome listBox
        /// </summary>
        public void SelectTicket()
        {
            //try catch to prevent crash
            try
            {
                currentTik = tixList.SelectedIndex;
                tik = (Ticket)tixList.Items[currentTik];
                tixView.Items.Add(tik);
            }
            catch (Exception)
            {
                MessageBox.Show("Select a ticket or enter.");
            }

        }

        /// <summary>
        /// Calculates the overall time spent in garage and calculates the total
        /// </summary>
        public void TotalTime()
        {
            DateTime d1 = tik.TimeIn;
            DateTime d2 = tik.TimeOut;

            TimeSpan t = d1 - d2;                         // subtracts our two dates
            int numHrs = (int)Math.Ceiling(t.TotalHours); // converts hours to a usable number
            decimal cost = tik.CalculateCharge(numHrs);   // cost is figured in Ticket class
            MessageBox.Show($"The cost for using the parking garage is {cost:c}");
            
        }

        /// <summary>
        /// Stores all data created with tickets as an xml file
        /// </summary>
        public void WriteXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Tickets.xml");
            // create initial node
            XmlNode numtix = doc.CreateElement("ticket");
            // give it attributes
            XmlAttribute attnum = doc.CreateAttribute("ticketNo");
            XmlAttribute attin = doc.CreateAttribute("timeIn");
            XmlAttribute attout = doc.CreateAttribute("timeOut");
            XmlAttribute attcost = doc.CreateAttribute("cost");
            // give attributes their correct values
            attnum.Value = tik.TicketNo.ToString();
            attin.Value = tik.TimeIn.ToString();
            attout.Value = tik.TimeOut.ToString();
            attcost.Value = tik.Cost.ToString();
            numtix.Attributes.Append(attnum);
            numtix.Attributes.Append(attin);
            numtix.Attributes.Append(attout);
            numtix.Attributes.Append(attcost);
            doc.DocumentElement.AppendChild(numtix);

            doc.Save("Tickets.xml"); // saves results
            MessageBox.Show("File updated."); // cue to user
        }
        #endregion
    }
}
