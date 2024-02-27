
class Array_LeetCode_PrintMatrixInSpiralForm
{

    public static void Print(){
        Console.WriteLine("Array_LeetCode_PrintMatrixInSpiralForm");

        int[,] xs = {
            {1,2,3,4},
            {5,6,7,8},
            {9,10,11,12},
            {13,14,15,16}
        };

        var rs = Build(xs);

        Console.WriteLine(string.Join(",", rs));
        
    }

    enum DIR { RIGHT, DOWN, LEFT, UP }

    private static int[] Build(int[,] xs)
    {
        int w = xs.GetUpperBound(0) + 1;
        int h = xs.GetUpperBound(1) + 1;
        int n = w * h;
        var rs = new int[n];
        
        int i = 0;
        int j = 0;

        int x0 = 0;
        int y0 = 0;

        var dir = DIR.RIGHT;        

        int q = 0;
        while(q < n) {
            int x = xs[i,j];
            //Console.WriteLine($"dir={dir} w:{w} h:{h} x:{x},i:{i},j:{j},x0:{x0},y0:{y0}");
            rs[q++] = x;
            switch(dir){
                case DIR.RIGHT:
                    if (j == w - 1) {
                        dir = DIR.DOWN;
                        i++;
                    }
                    else {
                        j++;
                    }
                break;
                case DIR.DOWN:
                    if (i == h - 1) {
                        dir = DIR.LEFT;
                        y0++;
                        j--;
                    }
                    else {
                        i++;
                    }
                break;
                case DIR.LEFT:
                    if (j == x0) {
                        i--;
                        w--;
                        h--;
                        dir = DIR.UP;
                    }
                    else {
                        j--;
                    }
                break;
                case DIR.UP:
                    if (i == y0) {
                        j++;
                        x0++;
                        dir = DIR.RIGHT;
                    }
                    else {
                        i--;
                    }

                break;
            }
        }
        return rs;
    }
}