public class CourseScheduleSolution {
    // Course Schedule    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        return EvalCourses(numCourses, prerequisites);        
    }

    bool EvalCourses(int numCourses, int[][] prerequisites)
    {
        var coursePaths = new Dictionary<int, List<int>>(); // course-id, path 3-2-1-0

        foreach(var ps in prerequisites)
        {
            int cid = ps[0];
            int pre = ps[1];
            if (!coursePaths.TryGetValue(cid, out List<int>? path))
            {
                path = new List<int>();
                coursePaths.Add(cid, path);
            }
            path.Add(pre);
        }

        int cnt = 1;

        foreach(var x in coursePaths)
            if (!EvalPaths(numCourses, coursePaths, x.Key, x.Value, new HashSet<int>(), ref cnt))
                return false;

        return true;
    }

    bool EvalPaths(int numCourses, Dictionary<int, List<int>> coursePaths, int courseId, List<int> pres, HashSet<int> visited, ref int cnt)
    {
        // Console.WriteLine($"{courseId}: {string.Join("-", pres)}");
        visited.Add(courseId);
        foreach(int pre in pres)
        {
            if (!coursePaths.ContainsKey(pre)) 
            {
                cnt++;
                continue;
            }
            if (visited.Contains(pre)) return false;
            if (cnt > 1 && cnt == numCourses - 1) return true;
            if (!EvalPaths(numCourses, coursePaths, pre, coursePaths[pre], visited, ref cnt))
                return false;
        }
        cnt++;
        return true;
    }
}
