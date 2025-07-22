using UnityEngine;
using UnityEngine.Events;



namespace Eloi {
    public class HapticsMono_RelayTactSuitIndex2D : MonoBehaviour
    {

        public TactSuitCoordinate2D m_index;
        public UnityEvent<TactSuitCoordinate2D> m_onRelayed;
        
        [ContextMenu("Relay Current Value")]
        public void RelayCurrentValue()
        {

            m_onRelayed?.Invoke(m_index);

        }

    }

}
