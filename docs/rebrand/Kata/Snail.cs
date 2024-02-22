public class SnailSolution
{
  	public static int[] Snail(int[][] array)
	{
		int w = array[0].Length;
		int h = array.Length;
		
		int sz = w * h;
		
		int[] xs = new int[sz];
		
		int x = 0;
		int y = 0;
		int i = 0;
		int vx = 1;
		int vy = 0;
		int xi = 0;
		int yi = 1;
		while(i < sz){
			xs[i] = array[y][x];
			x += vx;
			y += vy;
			
			if (x == w && vx > 0) {
				vx = 0;
				x--;
				vy = 1;
				y += vy;
				w--;
			}
			else if (y == h && vy > 0) {
				vy = 0;
				y--;
				vx = -1;
				x += vx;
				h--;
			}
			else if (x == xi && vx < 0) {
				vx = 0;
				vy = -1;
				xi++;
			}
			else if (y == yi && vy < 0) {
				vy = 0;
				vx = 1;
				yi++;
			}
			i++;
		}
		
		return xs;
	}
}