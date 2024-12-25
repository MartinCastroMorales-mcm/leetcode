namespace Intervals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();

        bool result = sol.CanAttendMeetings(
            [
            //new Interval(15,20)
            new Interval(0,30), 
            new Interval(5,10), 
            new Interval(15,20)
            ]);
        Console.WriteLine(result);

        /*
        
            new Interval(5,8), 
            new Interval(9,15), 
        
        
        
        */
    }


// Definition of Interval:
 public class Interval {
     public int start, end;
     public Interval(int start, int end) {
         this.start = start;
         this.end = end;
     }

 }

    public class Solution
    {
        public bool CanAttendMeetings(List<Interval> intervals) {
            intervals.Sort((x, y) => {
                if(x.start < y.start) {
                    return -1;
                }else {
                    return 1;
                }
            });
            foreach(Interval interval in intervals) {
                Console.Write("(" + interval.start + "," + interval.end + ")");
            }
            Interval prev = intervals[0];
            for(int i = 1; i < intervals.Count; i++) {
                if(prev.end > intervals[i].start) {
                    return false;
                }
                prev = intervals[i];
            }
            return true;

            
         }
    }
}
