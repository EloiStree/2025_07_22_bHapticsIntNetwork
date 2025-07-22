using System;
using Bhaptics.SDK2;
using UnityEngine;



namespace Eloi {


    public class HapticsMono_IntToMotorOnOff : MonoBehaviour
    {

        public TactSuitPro32MotorState m_motorState;
        public int m_millisecondsByDefault = 200;
        public int m_previousRequestId;

        public void PlayMotor(TactSuitPro32 suitId, bool onOff)
        {

            int idVest = (int)PositionType.Vest;
            m_motorState.SetMotorValue(suitId, onOff);
            PushMotorState();

        }

        [ContextMenu(nameof(PlayAllMotor))]
        public void PlayAllMotor()
        {
            m_motorState.AllOn();
            PushMotorState();
        }


        [ContextMenu(nameof(PlayAllMotorBack))]
        public void PlayAllMotorBack()
        {
            m_motorState.AllOnBack();
            PushMotorState();
        }
        [ContextMenu(nameof(PlayAllMotorFront))]
        public void PlayAllMotorFront()
        {
            m_motorState.AllOnFront();
            PushMotorState();
        }

        [ContextMenu(nameof(PlayRandomValue))]
        public void PlayRandomValue()
        {
            m_motorState.SetFullRandomValue();
            PushMotorState();
        }

        [ContextMenu(nameof(PlayCurrentInspectorValue))]
        public void PlayCurrentInspectorValue()
        {

            PushMotorState();
        }


        public void SetNextArrayRawValue(params int[] rawValue)
        {

            m_motorState.SetArrayRawValue(rawValue);
        }
        public void SetNextArrayPercent01Value(params float[] percentValue)
        {

            m_motorState.SetArrayPercent01Value(percentValue);
        }


        [ContextMenu(nameof(Ping))]
        public void Ping()
        {
            BhapticsLibrary.Ping(PositionType.Vest);
        }



        [ContextMenu(nameof(StopAllMotor))]
        public void StopAllMotor()
        {
            m_motorState.AllOff();
            PushMotorState();
            BhapticsLibrary.StopAll();
        }


        private void PushMotorState()
        {
            m_previousRequestId = BhapticsLibrary.PlayMotors((int)PositionType.Vest, m_motorState.GetMotorRawValue(), m_millisecondsByDefault);
        }



        public void PlayOneIndex3D(TactSuitCoordinate3D index)
        {
            StopAllMotor();
            TactSuitPro32Group.GetTactSuitPro32Index(index.m_backFront, index.m_horizontal, index.m_vertical, out TactSuitPro32 i);
            BhapticsLibrary.PlaySingleMotor(PositionType.Vest, (int) i, 100, m_millisecondsByDefault);
            m_motorState.SetMotorValueOn(i);

        }
        public void PlayOneFrontIndex2D(TactSuitCoordinate2D index )
        {

            StopAllMotor();
            TactSuitPro32Group.GetTactSuitPro32Index(TactSuitPro32HandBackFront.Front, index.m_horizontal, index.m_vertical, out TactSuitPro32 i);
            BhapticsLibrary.PlaySingleMotor(PositionType.Vest, (int)i, 100, m_millisecondsByDefault);
            m_motorState.SetMotorValueOn(i);
        }
        public void PlayOneBackIndex2D(TactSuitCoordinate2D index )
        {

            StopAllMotor();
            TactSuitPro32Group.GetTactSuitPro32Index(TactSuitPro32HandBackFront.Back, index.m_horizontal, index.m_vertical, out TactSuitPro32 i);
            BhapticsLibrary.PlaySingleMotor(PositionType.Vest, (int)i, 100, m_millisecondsByDefault);
            m_motorState.SetMotorValueOn(i);
        }
    }

}
