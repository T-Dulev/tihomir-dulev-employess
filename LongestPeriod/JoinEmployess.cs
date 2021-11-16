using System.Collections.Generic;
using System.Linq;

namespace LongestPeriod
{
    public class JoinEmployess
    {
        public int EmpFirstId { get; set; }

        public int EmpSecondId { get; set; }

        public int ProjectId { get; set; }

        public int Interval { get; set; }

        public static List<JoinEmployess> JoinEmp(List<Employee> employess)
        {
            var resJoin = from e1 in employess
                          join e2 in employess on e1.ProjectId equals e2.ProjectId
                         select new JoinEmployess() { EmpFirstId = e1.EmpId, EmpSecondId = e2.EmpId, ProjectId = e1.ProjectId, Interval = e1.MatchingPeriod(e2) };

            var res = resJoin
                .Where(x => x.Interval > 0 && x.EmpFirstId < x.EmpSecondId)
                .OrderBy(x => x.EmpFirstId)
                .ThenBy(x => x.EmpSecondId)
                .ToList();
            
            return res;
        } 

        public static JoinTeam GetMaxInterval (List<JoinEmployess> joinEmployess)
        {
            var res = joinEmployess
                    .GroupBy(x => new { x.EmpFirstId, x.EmpSecondId })
                    .Select(x => new JoinTeam() {
                        EmpFirstId = x.Key.EmpFirstId,
                        EmpSecondId = x.Key.EmpSecondId,
                        DaysWorked = x.Select(x => x.Interval).Sum()
                    });

            return res.OrderByDescending(x => x.DaysWorked).First();
        }
    }

    public struct JoinTeam
    {
        public int EmpFirstId { get; set; }

        public int EmpSecondId { get; set; }

        public int DaysWorked { get; set; }
    }
}
