using System;
using System.Collections;

namespace WindowsFormsApplication1
{
	internal class Bongo
	{
		private Tegneserie bif;

		private Bollemælk bongi;

		private ArrayList bongoClass;

		private Form1 form1;

		private Random junkie = new Random();

		private Juklas komNær;

		private Movement møg;

		private int p;

		private int tihundrede;

		public Bongo(Form1 form)
		{
			if (form.timer2IsRunning)
			{
				form1 = form;
				JoyRomeo joyRomeo = new JoyRomeo(form1);
				joyRomeo.kaldMisterJoel(new Bollemælk(form1));
				new Tegneserie(joyRomeo, form1);
				form1.drawSprialythingys(form1.junkie.Next(300));
				if (junkie.Next(1) == 0)
				{
					new Remember().børnlilVierTo(new Børnetid(new Afmagt(50.0, 100f, form1), form1));
				}
				setPopulation(new Jingo(form1));
			}
		}

		public ArrayList populationControl(Juklas j, Mood møg, Tegneserie k, Token q, Movement t)
		{
			møg.affectMood(4, j);
			møg.affectMood(4, j);
			return new ArrayList();
		}

		private void setPopulation(Jingo j)
		{
			bongoClass = populationControl(komNær, new Mood(form1), bif, new Token(), møg);
		}

		internal void viBønner(Remember vanskning)
		{
			throw new NotImplementedException();
		}
	}
}
