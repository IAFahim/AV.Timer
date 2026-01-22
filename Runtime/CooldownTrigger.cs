using UnityEngine;
using UnityEngine.Events;
using Variable.Timer;

namespace AV.Timer.Runtime
{
    public class CooldownTrigger : MonoBehaviour
    {
        public Cooldown cooldown = new(1);
        public UnityEvent onTimeTriggered;

        public void Update()
        {
            if (cooldown.TickAndCheckReady(Time.deltaTime)) onTimeTriggered.Invoke();
        }

        private void OnEnable()
        {
            cooldown.Reset();
        }
    }
}