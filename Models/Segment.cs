using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using TrainStationTestApp.ViewModels.Base;

namespace TrainStationTestApp.Models;

public class Segment : ViewModel
{
    public Guid Id { get; set; }
    public int GroupId { get; set; }

    private bool isSelectedSegment;
    public bool IsSelectedSegment {
        get => isSelectedSegment;
        set { isSelectedSegment = value; OnPropertyChanged(); }
    }
    public Geometry LineSegment { get; set; }
    public Segment(Geometry lineSegment, int groupId)
    {
        Id = Guid.NewGuid();
        GroupId = groupId;
        LineSegment = lineSegment;
        IsSelectedSegment = false;
    }
}
