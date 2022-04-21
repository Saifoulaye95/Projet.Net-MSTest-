namespace SolutionRechercheDichoTest
{
	public class Util
	{
		public static int rechercheDicho(int[] T, int nbElts, int clé)
		{
			int position, d, g;
			g = 0;
			d = nbElts - 1;
			while (g <= d)
			{
				position = (g + d) / 2;
				if (T[position] == clé)
					return position; // clé trouvée				

				else
					   if (T[position]> clé)
					
				     d = position - 1;
				else
				
				     g = position + 1;
			}
			return -1; // clé non trouvée 
		}

	}
}