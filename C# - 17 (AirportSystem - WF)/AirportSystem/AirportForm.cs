using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportSystem
{
    public partial class AirportForm : Form
    {
        private AirportEntities db = new AirportEntities();

        public AirportForm()
        {
            InitializeComponent();
            fillCompany();
            fillCountry();
            fillGate();
            fillRunway();
            fillFlightsData();
        }

        private void fillFlightsData()
        {
            dgvFlights.DataSource = db.Flights.OrderByDescending(f => f.Id).Select(f => new
            {
                f.Id,
                Type = f.Type == 1 ? "Arrival" : "Departure",
                f.Date,
                Company = f.Company.Name,
                Destination = f.City.Name + "," + f.City.Country.Name,
                Airport = f.Airport.Name,
                Gate = f.Gate.Name,
                Runway = f.Runway.Name
            }).ToList();

            dgvFlights.Columns[0].Visible = false;
        }

        private void fillCompany()
        {
            foreach (Company item in db.Companies.ToList())
            {
                cmbCompany.Items.Add(item.Name);
            }
        }

        private void fillCountry()
        {
            foreach (Country item in db.Countries.ToList())
            {
                cmbCountry.Items.Add(item.Name);
            }
        }

        private void fillGate()
        {
            foreach (Gate item in db.Gates.ToList())
            {
                cmbGate.Items.Add(item.Name);
            }
        }

        private void fillRunway()
        {
            foreach (Runway item in db.Runways.ToList())
            {
                cmbRunway.Items.Add(item.Name);
            }
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = cmbCountry.Text;
            if (country == string.Empty)
            {
                MessageBox.Show("Ölkə seçin");
                return;
            }

            cmbCity.Items.Clear();
            cmbCity.Text = "";
            cmbAirport.Items.Clear();
            cmbAirport.Text = "";

            int countryId = this.getCountryIdByName(country);

            List<City> cities = db.Cities.Where(c => c.CountryId == countryId).ToList();

            foreach (City item in cities)
            {
                cmbCity.Items.Add(item.Name);
            }
        }

        private int getCountryIdByName(string countryName)
        {
            return db.Countries.FirstOrDefault(c => c.Name == countryName).Id;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city = cmbCity.Text;
            if (city == string.Empty)
            {
                MessageBox.Show("Şəhər seçin");
                return;
            }

            cmbAirport.Items.Clear();
            cmbAirport.Text = "";

            int cityId = this.getCityIdByName(city);

            List<Airport> airports = db.Airports.Where(a => a.CityId == cityId).ToList();

            foreach (Airport item in airports)
            {
                cmbAirport.Items.Add(item.Name);
            }
        }

        private int getCityIdByName(string cityName)
        {
            return db.Cities.FirstOrDefault(c => c.Name == cityName).Id;
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            string companyName = cmbCompany.Text;
            string cityName = cmbCity.Text;
            string airportName = cmbAirport.Text;
            string gateName = cmbGate.Text;
            string runwayName = cmbRunway.Text;
            DateTime date = dtpDate.Value;
            int errorCount = 0;
            if (companyName == string.Empty)
            {
                lblcompanyName.ForeColor = Color.Red;
                errorCount++;
            }
            else
            {
                lblcompanyName.ForeColor = SystemColors.ControlText;
            }

            if (cmbCountry.Text == string.Empty)
            {
                lblCountry.ForeColor = Color.Red;
                errorCount++;
            }
            else
            {
                lblCountry.ForeColor = SystemColors.ControlText;
            }

            if (cityName == string.Empty)
            {
                lblCity.ForeColor = Color.Red;
                errorCount++;
            }
            else
            {
                lblCity.ForeColor = SystemColors.ControlText;
            }

            if (airportName == string.Empty)
            {
                lblAirport.ForeColor = Color.Red;
                errorCount++;
            }
            else
            {
                lblAirport.ForeColor = SystemColors.ControlText;
            }

            if (gateName == string.Empty)
            {
                lblGate.ForeColor = Color.Red;
                errorCount++;
            }
            else
            {
                lblGate.ForeColor = SystemColors.ControlText;
            }

            if (runwayName == string.Empty)
            {
                lblRunway.ForeColor = Color.Red;
                errorCount++;
            }
            else
            {
                lblRunway.ForeColor = SystemColors.ControlText;
            }

            if (errorCount > 0)
            {
                return;
            }

            int type = 1;

            if (rbtTypeDeparture.Checked)
            {
                type = 0;
            }

            Flight flt = new Flight
            {
                Type = type,
                Date = date,
                Late = 0,
                CityId = this.getCityIdByName(cityName),
                GateId = this.getGateIdByName(gateName),
                RunwayId = this.getRunwayIdByName(runwayName),
                AirportId = this.getAirportIdByName(airportName),
                CompanyId = this.getCompanyIdByName(companyName)
            };

            db.Flights.Add(flt);
            db.SaveChanges();

            Reset();
        }

        private void Reset()
        {
            fillFlightsData();
            cmbCity.Items.Clear();
            cmbCity.Text = "";
            cmbAirport.Items.Clear();
            cmbAirport.Text = "";
            cmbCompany.Text = "";
            cmbCountry.Text = "";
            cmbGate.Text = "";
            cmbRunway.Text = "";
        }
        private int getGateIdByName(string gateName)
        {
            return db.Gates.FirstOrDefault(g => g.Name == gateName).Id;
        }

        private int getRunwayIdByName(string runwayName)
        {
            return db.Runways.FirstOrDefault(r => r.Name == runwayName).Id;
        }

        private int getAirportIdByName(string airportName)
        {
            return db.Airports.FirstOrDefault(a => a.Name == airportName).Id;
        }

        private int getCompanyIdByName(string companyName)
        {
            return db.Companies.FirstOrDefault(c => c.Name == companyName).Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Places plc = new Places();
            plc.selectedId = 15;
            plc.ShowDialog();
        }
    }
}
