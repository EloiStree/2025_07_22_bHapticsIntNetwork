namespace Eloi {
    public static class TactSuitPro32Group {


        // Front left right
        // 0  1  2  3
        // 4  5  6  7
        // 8  9  10 11
        // 12 13 14 15
        public static readonly int[,] m_frontLeftRight = new int[4, 4] {
            { 0,  1,  2,  3 },
            { 4,  5,  6,  7 },
            { 8,  9, 10, 11 },
            { 12, 13, 14, 15 }
        };

        // Back left right
        // 16 17 18 19
        // 20 21 22 23
        // 24 25 26 27
        // 28 29 30 31
        public static readonly int[,] m_backLeftRight = new int[4, 4] {
            { 16, 17, 18, 19 },
            { 20, 21, 22, 23 },
            { 24, 25, 26, 27 },
            { 28, 29, 30, 31 }
        };


        //TactSuitPro32Group.GetTactSuitPro32Index()
        public static void GetTactSuitPro32Index(
            TactSuitPro32HandBackFront backFront,
            TactSuitPro32HandLeftRight horizontal,
            TactSuitPro32HandTopDown vertical,
            out TactSuitPro32 index) {
            
            int[,] target = backFront== TactSuitPro32HandBackFront.Back?m_backLeftRight:m_frontLeftRight;
            int indexLeftRight =0;
            int indexTopDown =0;

            switch (vertical)
            {
                case TactSuitPro32HandTopDown.HTD0: indexTopDown = 0; break;
                case TactSuitPro32HandTopDown.HTD1: indexTopDown = 1; break;
                case TactSuitPro32HandTopDown.HTD2: indexTopDown = 2; break;
                case TactSuitPro32HandTopDown.HTD3: indexTopDown = 3; break;
                case TactSuitPro32HandTopDown.HDT0: indexTopDown = 3; break;
                case TactSuitPro32HandTopDown.HDT1: indexTopDown = 2; break;
                case TactSuitPro32HandTopDown.HDT2: indexTopDown = 1; break;
                case TactSuitPro32HandTopDown.HDT3: indexTopDown = 0; break;
            }

            switch (horizontal)
            {

                case TactSuitPro32HandLeftRight.HLR0: indexLeftRight = 0; break;
                case TactSuitPro32HandLeftRight.HLR1: indexLeftRight = 1; break;
                case TactSuitPro32HandLeftRight.HLR2: indexLeftRight = 2; break;
                case TactSuitPro32HandLeftRight.HLR3: indexLeftRight = 3; break;
                case TactSuitPro32HandLeftRight.HRL0: indexLeftRight = 3; break;
                case TactSuitPro32HandLeftRight.HRL1: indexLeftRight = 2; break;
                case TactSuitPro32HandLeftRight.HRL2: indexLeftRight = 1; break;
                case TactSuitPro32HandLeftRight.HRL3: indexLeftRight = 0; break;
            }


            int value = target[indexTopDown, indexLeftRight];
            index = (TactSuitPro32)value;

        }


        public static TactSuitPro32[] AllFront = new TactSuitPro32[] {

        TactSuitPro32.Front_HandRLTDL0C0,
        TactSuitPro32.Front_HandRLTDL0C1,
        TactSuitPro32.Front_HandRLTDL0C2,
        TactSuitPro32.Front_HandRLTDL0C3,
        TactSuitPro32.Front_HandRLTDL1C0,
        TactSuitPro32.Front_HandRLTDL1C1,
        TactSuitPro32.Front_HandRLTDL1C2,
        TactSuitPro32.Front_HandRLTDL1C3,
        TactSuitPro32.Front_HandRLTDL2C0,
        TactSuitPro32.Front_HandRLTDL2C1,
        TactSuitPro32.Front_HandRLTDL2C2,
        TactSuitPro32.Front_HandRLTDL2C3,
        TactSuitPro32.Front_HandRLTDL3C0,
        TactSuitPro32.Front_HandRLTDL3C1,
        TactSuitPro32.Front_HandRLTDL3C2,
        TactSuitPro32.Front_HandRLTDL3C3
        };


        public static TactSuitPro32[] AllBack = new TactSuitPro32[] {

         TactSuitPro32.Back_HandRLTDL0C0,
         TactSuitPro32.Back_HandRLTDL0C1,
         TactSuitPro32.Back_HandRLTDL0C2,
         TactSuitPro32.Back_HandRLTDL0C3,
         TactSuitPro32.Back_HandRLTDL1C0,
         TactSuitPro32.Back_HandRLTDL1C1,
         TactSuitPro32.Back_HandRLTDL1C2,
         TactSuitPro32.Back_HandRLTDL1C3,
         TactSuitPro32.Back_HandRLTDL2C0,
         TactSuitPro32.Back_HandRLTDL2C1,
         TactSuitPro32.Back_HandRLTDL2C2,
         TactSuitPro32.Back_HandRLTDL2C3,
         TactSuitPro32.Back_HandRLTDL3C0,
         TactSuitPro32.Back_HandRLTDL3C1,
         TactSuitPro32.Back_HandRLTDL3C2,
         TactSuitPro32.Back_HandRLTDL3C3
        };

        public static TactSuitPro32[] BackLineDown = new TactSuitPro32[] {

         TactSuitPro32.Back_HandRLTDL0C0,
         TactSuitPro32.Back_HandRLTDL0C1,
         TactSuitPro32.Back_HandRLTDL0C2,
         TactSuitPro32.Back_HandRLTDL0C3

        };
        public static TactSuitPro32[] BackLineTop = new TactSuitPro32[] {

         TactSuitPro32.Back_HandRLTDL0C0,
         TactSuitPro32.Back_HandRLTDL0C1,
         TactSuitPro32.Back_HandRLTDL0C2,
         TactSuitPro32.Back_HandRLTDL0C3
        };
        public static TactSuitPro32[] FrontLineDown = new TactSuitPro32[] {

         TactSuitPro32.Front_HandRLTDL0C0,
         TactSuitPro32.Front_HandRLTDL0C1,
         TactSuitPro32.Front_HandRLTDL0C2,
         TactSuitPro32.Front_HandRLTDL0C3

        };
        public static TactSuitPro32[] FrontLineTop = new TactSuitPro32[] {

         TactSuitPro32.Front_HandRLTDL0C0,
         TactSuitPro32.Front_HandRLTDL0C1,
         TactSuitPro32.Front_HandRLTDL0C2,
         TactSuitPro32.Front_HandRLTDL0C3
        };



        public static TactSuitPro32[] BackSideLeft = new TactSuitPro32[] {

         TactSuitPro32.Back_HandRLTDL3C0,
         TactSuitPro32.Back_HandRLTDL3C1,
         TactSuitPro32.Back_HandRLTDL3C2,
         TactSuitPro32.Back_HandRLTDL3C3

        };
        public static TactSuitPro32[] BackSideRight = new TactSuitPro32[] {

         TactSuitPro32.Back_HandRLTDL0C0,
         TactSuitPro32.Back_HandRLTDL0C1,
         TactSuitPro32.Back_HandRLTDL0C2,
         TactSuitPro32.Back_HandRLTDL0C3
        };
        public static TactSuitPro32[] FrontSideLeft = new TactSuitPro32[] {

         TactSuitPro32.Front_HandRLTDL3C0,
         TactSuitPro32.Front_HandRLTDL3C1,
         TactSuitPro32.Front_HandRLTDL3C2,
         TactSuitPro32.Front_HandRLTDL3C3

        };
        public static TactSuitPro32[] FrontSideRight = new TactSuitPro32[] {

         TactSuitPro32.Front_HandRLTDL0C0,
         TactSuitPro32.Front_HandRLTDL0C1,
         TactSuitPro32.Front_HandRLTDL0C2,
         TactSuitPro32.Front_HandRLTDL0C3
        };

    }

}
