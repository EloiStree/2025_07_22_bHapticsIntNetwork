namespace Eloi {
    [System.Serializable]
    public class TactSuitPro32MotorState
    {
       public int[] m_motorValueArray = new int[] {
            50, 40, 30, 20, 10, 50, 40, 30,
            50, 40, 30, 20, 10, 50, 40, 30,
            50, 40, 30, 20, 10, 50, 40, 30,
            50, 40, 30, 20, 10, 50, 40, 30,
        };

        public int[] GetMotorRawValue() { 
        
            return m_motorValueArray;   
        }
        public void AllOff() { 
            for (int i = 0; i < m_motorValueArray.Length; i++) 
                m_motorValueArray[i] = 0;
        }
        
        public void AllOn() {

            for (int i = 0; i < m_motorValueArray.Length; i++)
                m_motorValueArray[i] = 100;
        }


        public void SetMotorValueOn(TactSuitPro32 type) {

            SetMotorValue(type, true);
        }

        public void SetMotorValue(TactSuitPro32 type, bool onOff)
        {

            int index = (int)type;
            if (index >= 0 && index < m_motorValueArray.Length)
            {

                m_motorValueArray[index] = onOff ? 100 : 0;

            }
        }
        public void SetMotorValueAsPercent(TactSuitPro32 type, float percent01)
        {

            int index = (int)type;
            if (index >= 0 && index < m_motorValueArray.Length)
            {

                m_motorValueArray[index] =(int) (percent01 * 100.0f);
            }
        }

        public void IsMotorOn(TactSuitPro32 type, out bool isOn)
        {

            GetMotorIntensityAsRawValue100 (type, out int value);
            isOn = value > 0;
        }
        
        public void GetMotorIntensityAsPercent(TactSuitPro32 type, out float percent)
        {
            GetMotorIntensityAsRawValue100(type, out int value);
            percent = value/100;
        }
        public void GetMotorIntensityAsRawValue100(TactSuitPro32 type, out int value)
        {
            int index = (int)type;
            if (index >= 0 && index < m_motorValueArray.Length)
            {
                value = m_motorValueArray[index];
            }
            else value = 0;
        }











       




        public void AllOnBack()
        {
            AllOff();
            foreach (var value in TactSuitPro32Group.AllBack) {

                SetMotorValue(value, true);
            }
        }

        public void AllOnFront()
        {
            AllOff();
            foreach (var value in TactSuitPro32Group.AllFront)
            {

                SetMotorValue(value,true);
            }

        }

        public void SetFullRandomValue()
        {

            for (int i = 0; i < m_motorValueArray.Length; i++) { 
            
                m_motorValueArray[i] = UnityEngine.Random.Range(0,100);
            }

        }



        public void SetArrayRawValue(params int[] rawValue)
        {
            int i = 0;
            foreach (var value in rawValue)
            {
                if (i >= m_motorValueArray.Length)
                    return;
                m_motorValueArray[i] = value;
                i++;
            }
        }

        public void SetArrayPercent01Value(params float[] percentValue)
        {
            int i = 0;
            foreach (var value in percentValue)
            {
                if (i>=m_motorValueArray.Length)
                    return;
                m_motorValueArray[i] = (int) (value*100.0f);
                i++;
            }

        }
    }

}
