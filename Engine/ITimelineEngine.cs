using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimelineStudio.Models.exhibition.Domain;

namespace TimelineStudio.Models.exhibition.Engine
{
    public interface ITimelineEngine
    {
        void Init(ITimelineContext timelineContext);
        void Start();
        void Pause();
        void Stop();
        void Go(int timeTicked);
        event Func<int, bool> TimeTickEvent;
    }
}
