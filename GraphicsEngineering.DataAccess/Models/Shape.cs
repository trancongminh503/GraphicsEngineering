﻿using System;
using System.Drawing;
using GraphicsEngineering.DataAccess.Common;

namespace GraphicsEngineering.DataAccess.Models
{
	public abstract class Shape : IDisposable
	{
		public Point Begin;
		public Point End;
		public Point Kernel;
		public Rectangle Region;
		public Graphics Graphics { get; set; }
		public Color Color { get; set; }

		// Constructor cho elip, circle, rectangle...
		public Shape(Rectangle rect)
		{
			rect.Width *= 5;
			rect.Height *= 5;
			rect.Location = rect.Location.ToComputerCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			Region = rect;
			Kernel = new Point(rect.X + (rect.Width / 2), rect.Y + (rect.Height / 2));
		}
		public Shape(Rectangle rect, Color color)
			: this(rect) => Color = color;
		// Constructor cho line
		public Shape(Point begin, Point end)
		{
			Begin = begin.ToComputerCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
			End = end.ToComputerCoordinates(Constant.WIDTH_DRAWING_AREA, Constant.HEIGHT_DRAWING_AREA);
		}
		public Shape(Point begin, Point end, Color color)
			: this(begin, end) => Color = color;

		public void PutPixel(Color color, int x, int y)
		{
			Brush aBrush = new SolidBrush(color);
			Graphics.FillRectangle(aBrush, x - 1, y - 1, 3, 3);
		}
		public void Dispose() => Graphics.Dispose();

		public abstract void Draw(Graphics graphics);
		public abstract void TranslatingTransform(int trX, int trY);
		public abstract void ScaleTransform(Point origin, double scaleX, double scaleY);
		public abstract void RotateTransform(Point origin, int angle);
		public abstract void OppositeTransform(Point origin, OppositeType oppositeType);
	}
}