using Moq;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MegaDesk_Core_Razor.Models
{
    public class DeskQuote
    {
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
        public const double BASE_COST = 200.00;
        public const double FREE_MAX_AREA = 1000;
        public const double EXTRA_AREA_COST = 1.00;
        public const double DRAWER_COST = 50.00;


        public int Id { get; set; }
        [Display(Name = "First Name"), StringLength(60, MinimumLength = 1)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name"), StringLength(60, MinimumLength = 1)]
        public string LastName { get; set; }
        [Range(24, 96)]
        public int Width { get; set; }
        [Range(12, 48)]
        public int Depth { get; set; }
        [Range(0, 7)]
        public int Drawers { get; set; }
        public string Material { get; set; }
        [Display(Name = "Shipping Option")]
        public string ShipOption { get; set; }
        [Display(Name = "Quote Date"), DefaultValue("DateTime.Now"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime QuoteDate { get; set; }
        [Display(Name = "Quote Created"),DefaultValue("DateTime.Now"), DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime CreatedDateTime { get; set; }

        public double getQuotePrice()
        {
            return BASE_COST + getMaterialCost(this.Material) + getDrawersCost(this.Drawers) + getShippingCharge(this.ShipOption) + getSurfaceAreaCost();
        }

        public double getBaseCost()
        {
            return BASE_COST;
        }

        public int getDrawersCost(int drawers)
        {
            int drawerCost = drawers * 50;
            return drawerCost;
        }
        private bool ValidateDeskDimensions()
        {
            return (Width >= MINWIDTH)
                & (Width <= MAXWIDTH)
                & (Depth >= MINDEPTH)
                & (Depth <= MAXDEPTH);
        }
        public int getSurfaceArea()
        {
            return ValidateDeskDimensions() ? Width * Depth : 0;
        }

        public double getSurfaceAreaCost()
        {
            double area = 0.00;
            Double.TryParse(this.getSurfaceArea().ToString(), out area);

            if (area > 1000)
            {
                double areaCost = area * EXTRA_AREA_COST;
                return areaCost;
            }
            else
            {
                return 0.00;
            }
        }

        public double getMaterialCost(string material)
        {
            double shippingCharge = 0.00;

            switch(material)
            {
                case "Laminate":
                    shippingCharge = 100.00;
                    break;
                case "Oak":
                    shippingCharge = 200.00;
                    break;

                case "Rosewood":
                    shippingCharge = 300.00;
                    break;

                case "Veneer":
                    shippingCharge = 125.00;
                    break;

                case "Pine":
                    shippingCharge = 50.00;
                    break;

                default:
                    shippingCharge = 0.00;
                    break;
            }

            return shippingCharge;
        }

        public double getShippingCharge(string orderShipType)
        {
            double shippingCharge = 0;
            int[,] Prices = { {60, 70, 80 }, { 40, 50, 60 }, { 30, 35, 40 } };

            if (this.getSurfaceArea() < 1000)
            {
                switch (orderShipType)
                {
                    case "3-day Shipping":
                        {
                            shippingCharge = Prices[0, 0];
                            break;
                        }
                    case "5-day Shipping":
                        {
                            shippingCharge = Prices[1, 0];
                            break;
                        }
                    case "7-day Shipping":
                        {
                            shippingCharge = Prices[2, 0];
                            break;
                        }
                    case "No Rush Shipping":
                        {
                            shippingCharge = 0;
                            break;
                        }

                }
            }
            else if (this.getSurfaceArea() > 2000)
            {
                switch (orderShipType)
                {
                    case "3-day Shipping":
                        {
                            shippingCharge = Prices[0, 2];
                            break;
                        }
                    case "5-day Shipping":
                        {
                            shippingCharge = Prices[1, 2];
                            break;
                        }
                    case "7-day Shipping":
                        {
                            shippingCharge = Prices[2, 2];
                            break;
                        }
                    case "No Rush Shipping":
                        {
                            shippingCharge = 0;
                            break;
                        }
                }
            }
            else
            {
                switch (orderShipType)
                {
                    case "3-day Shipping":
                        {
                            shippingCharge = Prices[0, 1];
                            break;
                        }
                    case "5-day Shipping":
                        {
                            shippingCharge = Prices[1, 1];
                            break;
                        }
                    case "7-day Shipping":
                        {
                            shippingCharge = Prices[2, 1];
                            break;
                        }
                    case "No Rush Shipping":
                        {
                            shippingCharge = 0;
                            break;
                        }
                }
            }

            return shippingCharge;        
        }
    }


}
