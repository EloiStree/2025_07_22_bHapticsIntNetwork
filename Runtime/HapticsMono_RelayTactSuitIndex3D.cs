using UnityEngine;
using UnityEngine.Events;



namespace Eloi {
    public class HapticsMono_RelayTactSuitIndex3D : MonoBehaviour
    {

        public TactSuitCoordinate3D m_index;
        public UnityEvent<TactSuitCoordinate3D> m_onRelayed;


        [ContextMenu("Relay Current Value")]
        public void RelayCurrentValue() {

            m_onRelayed?.Invoke(m_index);
        
        }

    }

}
