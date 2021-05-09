using System;
using System.Collections.Generic;
using System.Text;

namespace MegaDesk_Krohn
{
    class Desk
    {
        private const int MinWidth = 24, MaxWidth = 96, MinDepth = 12, MaxDepth = 48, MaxDrawers = 7;

        private int width, depth, drawers;
        private String surfaceMaterial;

        public Desk(int width, int depth, int drawers, String surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public int Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value <= MaxWidth && value >= MinWidth)
                {
                    width = value;
                }
            }
        }
        public int Depth
        {
            get
            {
                return depth;
            }

            set
            {
                if (value <= MaxDepth && value >= MinDepth)
                {
                    depth = value;
                }
            }
        }
        public int Drawers
        {
            get
            {
                return drawers;
            }

            set
            {
                if (value <= MaxDrawers && value >= 0)
                {
                    drawers = value;
                }
            }
        }
        public String SurfaceMaterial
        {
            get
            {
                return surfaceMaterial;
            }
            set
            {
                this.surfaceMaterial = value;
            }
        }
    }
}
