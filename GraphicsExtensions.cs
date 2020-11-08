/*
Maneubo is an application that provides a virtual maneuvering board and target
motion analysis.

http://www.adammil.net/Maneubo
Copyright (C) 2011-2020 Adam Milazzo

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
*/
using System.Drawing;
using AdamMil.Mathematics.Geometry;

namespace Maneubo
{
  static class GraphicsExtensions
  {
    public static void DrawArrow(this Graphics graphics, Pen pen, PointF start, PointF end) =>
      graphics.DrawArrow(pen, start.X, start.Y, end.X, end.Y);

    public static void DrawArrow(this Graphics graphics, Pen pen, float x, float y, float x2, float y2)
    {
      // draw the main line
      graphics.DrawLine(pen, x, y, x2, y2);

      // draw the end cap
      const double Angle = 60 * MathConst.DegreesToRadians;
      Vector2 vector = new Vector2(x-x2, y-y2).GetNormal(8); // the length of the end cap segments

      Vector2 rotated = vector.Rotate(Angle/2);
      graphics.DrawLine(pen, x2, y2, x2+(float)rotated.X, y2+(float)rotated.Y);

      rotated = vector.Rotate(-Angle/2);
      graphics.DrawLine(pen, x2, y2, x2+(float)rotated.X, y2+(float)rotated.Y);
    }

    public static void DrawCircle(this Graphics graphics, Pen pen, float x, float y, float radius)
    {
      float diameter = radius*2;
      graphics.DrawEllipse(pen, x-radius, y-radius, diameter, diameter);
    }

    public static void DrawCircle(this Graphics graphics, Pen pen, PointF center, float radius)
    {
      float diameter = radius*2;
      graphics.DrawEllipse(pen, center.X-radius, center.Y-radius, diameter, diameter);
    }

    public static void DrawHLine(this Graphics graphics, Pen pen, int x, int y, int x2) =>
      graphics.DrawLine(pen, x, y, x2, y);

    public static void DrawVLine(this Graphics graphics, Pen pen, int x, int y, int y2) =>
      graphics.DrawLine(pen, x, y, x, y2);

    public static void DrawRectangle(this Graphics graphics, Pen pen, RectangleF rectangle) =>
      graphics.DrawRectangle(pen, rectangle.X, rectangle.Y, rectangle.Height, rectangle.Width);
  }
}