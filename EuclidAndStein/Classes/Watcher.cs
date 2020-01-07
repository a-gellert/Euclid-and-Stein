using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidAndStein.Classes
{
    public class Watcher : IDisposable
    {
        private Action<TimeSpan> _action;
        readonly Stopwatch _timer;

        Watcher(Action<TimeSpan> action)
        {
            _timer = new Stopwatch();
            _action = action;
            _timer.Start();
        }

        public void Dispose()
        {
            _timer.Stop();

            if (_action != null)
            {
                _action(_timer.Elapsed);
            }
        }
        public static Watcher Start(Action<TimeSpan> action)

        {
            return new Watcher(action);
        }
    }
}
