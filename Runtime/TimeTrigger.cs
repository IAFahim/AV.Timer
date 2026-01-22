using UnityEngine;
using UnityEngine.Events;
using Variable.Timer;

namespace AV.Timer.Runtime
{
    public class TimeTrigger : MonoBehaviour
    {
        public Variable.Timer.Timer timer = new(1);
        public UnityEvent onTimeTriggered;

        public void Update()
        {
            if (timer.TickAndCheckComplete(Time.deltaTime)) onTimeTriggered.Invoke();
        }

        private void OnEnable()
        {
            timer.Reset();
        }
    }
}