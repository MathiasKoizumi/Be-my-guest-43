using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class JoyRomeo
	{
		private Form1 form1;

		public JoyRomeo(Form1 form)
		{
			form1 = form;
			new Jonga(400, form1);
			form1.BlackHoleoneTwothousand(50, new Rectangle(0, 0, 1200, 1200));
			if (form1.junkie.Next(3) == 0)
			{
				form1.jongoTime();
			}
		}

		internal Jongo kaldMisterJoel(Bollemælk bollemælk)
		{
			bollemælk.effectShow();
			return new Jongo(form1);
		}

		internal Jingo partyTime()
		{
			new Bolledej(200.0, "TeleBubble", form1).tumbeDej().lightly("JubbleTubble");
			form1.junkieBeMyGuest(200);
			return new Jingo(form1);
		}
	}
}
