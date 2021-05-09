using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Krohn
{
    class DeskQuote
    {
        private const float BasePrice = 200, DrawerPrice = 50, SurfaceAreaPPI = 1, Oak = 200, Laminate = 100, Pine = 50, Rosewood = 300, Veneer = 125;
        private int id;
        private String customerName;
        private int productionTime;
        private DateTime date;
        private Desk desk;

        public DeskQuote(String name, int productionTime, Desk desk)
        {
            Random random = new Random();
            this.customerName = name;
            this.productionTime = productionTime;
            this.desk = desk;
            this.date = DateTime.Now;
            this.id = random.Next(0, 10000);
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        public String CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                this.customerName = value;
            }
        }

        private float rushOrdersCalc()
        {
            int surfaceArea = this.desk.Width * this.desk.Depth;
            switch (this.productionTime)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        return 60;
                    }
                    else if (surfaceArea <= 2000)
                    {
                        return 70;
                    }
                    else
                    {
                        return 80;
                    }
                case 5:
                    if (surfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (surfaceArea <= 2000)
                    {
                        return 50;
                    }
                    else
                    {
                        return 60;
                    }
                case 7:
                    if (surfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (surfaceArea <= 2000)
                    {
                        return 35;
                    }
                    else
                    {
                        return 40;
                    }
                default:
                    return 0;

            }
        }

        public float surfaceMaterialCalc()
        {
            switch (this.desk.SurfaceMaterial)
            {
                case "Oak":
                    return Oak;
                case "Laminate":
                    return Laminate;
                case "Pine":
                    return Pine;
                case "Rosewood":
                    return Rosewood;
                case "Veneer":
                    return Veneer;
                default:
                    return 0;
            }
        }

        public float createQuote()
        {
            return BasePrice + (this.desk.Width * this.desk.Depth * SurfaceAreaPPI) + (this.desk.Drawers * DrawerPrice) + surfaceMaterialCalc() + rushOrdersCalc();
        }
    }
}