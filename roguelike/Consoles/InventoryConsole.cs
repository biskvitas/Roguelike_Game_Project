﻿using Microsoft.Xna.Framework;

namespace roguelike.Consoles
{
    class InventoryConsole : SadConsole.Consoles.Console
    {
        public InventoryConsole(int width, int height): base(width, height)
        {
            // Draw the side bar
            SadConsole.Shapes.Line line = new SadConsole.Shapes.Line();
            line.EndingLocation = new Point(0, height - 1);
            line.CellAppearance.GlyphIndex = 179;
            line.UseEndingCell = false;
            line.UseStartingCell = false;
            line.Draw(this);
        }
    }
}
