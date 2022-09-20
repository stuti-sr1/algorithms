using System;

public class QueriesonNumberofPointsInsideaCircleSolution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int len=queries.Length;
        int[] result=new int[len];
        int i=0;
        foreach (var query in queries)
        {
            int count=0;
            foreach (var point in points)
            {
                double x1=Math.Pow((double) Math.Abs(query[0]-point[0]),2);
                double y1=Math.Pow((double) Math.Abs(query[1]-point[1]),2);

                double dist=Math.Sqrt(x1+y1);
                if (dist<=query[2]) count++;
            }
            result[i++]=count;
        }
        return result;
    }
}