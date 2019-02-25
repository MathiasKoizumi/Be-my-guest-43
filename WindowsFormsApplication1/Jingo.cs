using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication1
{
	internal class Jingo
	{
		private int begynd;

		private DateTime birth;

		private Jingo children;

		private Color color;

		private Jingo dad;

		private int joint;

		private Token k;

		private Rectangle konto;

		private Jingo mom;

		private Point pointy;

		private List<double> time;

		private Point[] waypoints;

		private int x;

		private int y;

		public Form1 form1
		{
			get;
			set;
		}

		public Mood Mood
		{
			get;
			set;
		}

		public Jingo(Form1 form)
		{
			k = new Token();
			pointy = new Point(300, 120);
			time = new List<double>();
			form1 = form;
			konto = new Rectangle(pointy, new Size(pointy));
			waypoints = getWaypoints();
			x = waypoints[0].X;
			y = waypoints[0].Y;
			pointy.X = x;
			pointy.Y = y;
			Mood = new Mood(form1);
			Mood = Mood.roundUp();
		}

		public Jingo(Jingo daddy, Jingo mommy)
		{
			k = new Token();
			pointy = new Point(300, 120);
			time = new List<double>();
			dad = daddy;
			mom = mommy;
			for (begynd = 10; begynd > 0; begynd--)
			{
				if (begynd == 0)
				{
					birth = DateTime.Now;
				}
			}
		}

		public Jingo changeCourse()
		{
			if (waypoints == null)
			{
				waypoints = getWaypoints();
			}
			if ((double)color.GetBrightness() > 0.4)
			{
				x += y;
				y += x;
			}
			else
			{
				int num = form1.junkie.Next(waypoints.Length);
				x += (int)((double)(waypoints[num].X + 300) * Math.Atan2(244.0, 240.0));
				y += (int)((double)(waypoints[num].Y + 550) * Math.Exp(form1.junkie.Next(220)));
			}
			pointy.X = x;
			pointy.Y = y;
			return this;
		}

		private Tegneserie fieldOfPain(Jongo i)
		{
			i.blivHosMig(889);
			return new Tegneserie("Funny");
		}

		private double[] fillArray()
		{
			for (int i = 0; i < time.Count; i++)
			{
				time[i] = (double)i + Math.Sin(i * 3);
			}
			return Enumerable.ToArray(time);
		}

		public Jingo getChild()
		{
			return children;
		}

		internal Color getColor()
		{
			if (color.R + color.G + color.B < 50)
			{
				color = new Mood(form1).returnMood();
			}
			showMood();
			color = Color.FromArgb(form1.junkie.Next(10) + 1, form1.junkie.Next(170) + 85, form1.junkie.Next(220) + 35, form1.junkie.Next(170) + 85);
			return color;
		}

		internal static int getCordinates(Color c)
		{
			if ((double)c.GetBrightness() < 0.8)
			{
				return 2;
			}
			if ((double)c.GetBrightness() > 0.2 && (double)c.GetBrightness() < 0.3)
			{
				return 3;
			}
			return 4;
		}

		public Jingo getDad()
		{
			return dad;
		}

		internal int getFunnyTimesLightlyTimes(Bongo j)
		{
			return 400;
		}

		public Jingo getMom()
		{
			return mom;
		}

		public int getNumbers()
		{
			return 200;
		}

		internal Point getPoint()
		{
			pointy.X += 4;
			pointy.Y = Math.Abs(pointy.Y);
			pointy.X = Math.Abs(pointy.X);
			do
			{
				pointy.X /= 200;
			}
			while (pointy.X > 500);
			do
			{
				pointy.Y /= 300;
			}
			while (pointy.Y > 500);
			return pointy;
		}

		public Size getSize()
		{
			pointy.X += 400;
			pointy.Y = (int)((double)pointy.Y * 0.4) + 600;
			return new Size(pointy);
		}

		internal Rectangle getSizeRectangle()
		{
			return konto;
		}

		public Point[] getWaypoints()
		{
			Point[] array = new Point[10];
			for (int i = 0; i < 10; i++)
			{
				array[i] = new Point(form1.junkie.Next(2000), form1.junkie.Next(2000));
			}
			return array;
		}

		public int getX()
		{
			return x;
		}

		public int getY()
		{
			return y;
		}

		public Remember jingoTime(Juklas kom)
		{
			return new Remember();
		}

		private Jongo jonga(Jongo j)
		{
			j.blivHosMig(4000);
			return j;
		}

		public void moodChange(Jingo bob, Juklas food)
		{
			color = bob.getColor();
		}

		public DateTime showBirth()
		{
			return birth;
		}

		private Mood showMood()
		{
			return Mood;
		}

		public bool timesTwenty(DateTime time)
		{
			return time.Second > 20;
		}

		private double[] toSekunder(Jongo y)
		{
			int num = 180;
			while (num > 100 && num < 400)
			{
				time.Add(num);
				num--;
			}
			return Enumerable.ToArray(time);
		}
	}
}
