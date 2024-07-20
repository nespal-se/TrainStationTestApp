using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TrainStationTestApp.Models
{
    public class Segment
    {
        public Guid LineId { get; set; }
        public Geometry LineSegment { get; set; }
        public Segment(Geometry lineSegment)
        {
            LineSegment = lineSegment;
            LineId = Guid.NewGuid();
        }

    }
}
