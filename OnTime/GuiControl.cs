using System.Drawing;

namespace OnTime
{
    class GuiControl
    {

        private readonly MainWindow _gui;

        public GuiControl(MainWindow main)
        {
            _gui = main;
        }

        public void ColorSwitch(int i)
        {
            switch (i)
            {
                case 1:
                    _gui.info1.FillColor = Color.Blue;
                    _gui.dptLBL1.BackColor = Color.Blue;
                    _gui.LBLsw1.BackColor = Color.Blue;
                    _gui.LBLtt1.BackColor = Color.Blue;
                    _gui.swLBL1.BackColor = Color.Blue;
                    _gui.trtLBL1.BackColor = Color.Blue;

                    _gui.info2.FillColor = Color.Transparent;
                    _gui.dptLBL2.BackColor = Color.Transparent;
                    _gui.LBLsw2.BackColor = Color.Transparent;
                    _gui.LBLtt2.BackColor = Color.Transparent;
                    _gui.swLBL2.BackColor = Color.Transparent;
                    _gui.trtLBL2.BackColor = Color.Transparent;
                    _gui.info3.FillColor = Color.Transparent;
                    _gui.dptLBL3.BackColor = Color.Transparent;
                    _gui.LBLsw3.BackColor = Color.Transparent;
                    _gui.LBLtt3.BackColor = Color.Transparent;
                    _gui.swLBL3.BackColor = Color.Transparent;
                    _gui.trtLBL3.BackColor = Color.Transparent;
                    _gui.info4.FillColor = Color.Transparent;
                    _gui.dptLBL4.BackColor = Color.Transparent;
                    _gui.LBLsw4.BackColor = Color.Transparent;
                    _gui.LBLtt4.BackColor = Color.Transparent;
                    _gui.swLBL4.BackColor = Color.Transparent;
                    _gui.trtLBL4.BackColor = Color.Transparent;
                    break;
                case 2:
                    _gui.info2.FillColor = Color.Blue;
                    _gui.dptLBL2.BackColor = Color.Blue;
                    _gui.LBLsw2.BackColor = Color.Blue;
                    _gui.LBLtt2.BackColor = Color.Blue;
                    _gui.swLBL2.BackColor = Color.Blue;
                    _gui.trtLBL2.BackColor = Color.Blue;

                    _gui.info1.FillColor = Color.Transparent;
                    _gui.dptLBL1.BackColor = Color.Transparent;
                    _gui.LBLsw1.BackColor = Color.Transparent;
                    _gui.LBLtt1.BackColor = Color.Transparent;
                    _gui.swLBL1.BackColor = Color.Transparent;
                    _gui.trtLBL1.BackColor = Color.Transparent;
                    _gui.info3.FillColor = Color.Transparent;
                    _gui.dptLBL3.BackColor = Color.Transparent;
                    _gui.LBLsw3.BackColor = Color.Transparent;
                    _gui.LBLtt3.BackColor = Color.Transparent;
                    _gui.swLBL3.BackColor = Color.Transparent;
                    _gui.trtLBL3.BackColor = Color.Transparent;
                    _gui.info4.FillColor = Color.Transparent;
                    _gui.dptLBL4.BackColor = Color.Transparent;
                    _gui.LBLsw4.BackColor = Color.Transparent;
                    _gui.LBLtt4.BackColor = Color.Transparent;
                    _gui.swLBL4.BackColor = Color.Transparent;
                    _gui.trtLBL4.BackColor = Color.Transparent;
                    break;
                case 3:
                    _gui.info3.FillColor = Color.Blue;
                    _gui.dptLBL3.BackColor = Color.Blue;
                    _gui.LBLsw3.BackColor = Color.Blue;
                    _gui.LBLtt3.BackColor = Color.Blue;
                    _gui.swLBL3.BackColor = Color.Blue;
                    _gui.trtLBL3.BackColor = Color.Blue;

                    _gui.info1.FillColor = Color.Transparent;
                    _gui.dptLBL1.BackColor = Color.Transparent;
                    _gui.LBLsw1.BackColor = Color.Transparent;
                    _gui.LBLtt1.BackColor = Color.Transparent;
                    _gui.swLBL1.BackColor = Color.Transparent;
                    _gui.trtLBL1.BackColor = Color.Transparent;
                    _gui.info2.FillColor = Color.Transparent;
                    _gui.dptLBL2.BackColor = Color.Transparent;
                    _gui.LBLsw2.BackColor = Color.Transparent;
                    _gui.LBLtt2.BackColor = Color.Transparent;
                    _gui.swLBL2.BackColor = Color.Transparent;
                    _gui.trtLBL2.BackColor = Color.Transparent;
                    _gui.info4.FillColor = Color.Transparent;
                    _gui.dptLBL4.BackColor = Color.Transparent;
                    _gui.LBLsw4.BackColor = Color.Transparent;
                    _gui.LBLtt4.BackColor = Color.Transparent;
                    _gui.swLBL4.BackColor = Color.Transparent;
                    _gui.trtLBL4.BackColor = Color.Transparent;
                    break;
                case 4:
                    _gui.info4.FillColor = Color.Blue;
                    _gui.dptLBL4.BackColor = Color.Blue;
                    _gui.LBLsw4.BackColor = Color.Blue;
                    _gui.LBLtt4.BackColor = Color.Blue;
                    _gui.swLBL4.BackColor = Color.Blue;
                    _gui.trtLBL4.BackColor = Color.Blue;

                    _gui.info1.FillColor = Color.Transparent;
                    _gui.dptLBL1.BackColor = Color.Transparent;
                    _gui.LBLsw1.BackColor = Color.Transparent;
                    _gui.LBLtt1.BackColor = Color.Transparent;
                    _gui.swLBL1.BackColor = Color.Transparent;
                    _gui.trtLBL1.BackColor = Color.Transparent;
                    _gui.info2.FillColor = Color.Transparent;
                    _gui.dptLBL2.BackColor = Color.Transparent;
                    _gui.LBLsw2.BackColor = Color.Transparent;
                    _gui.LBLtt2.BackColor = Color.Transparent;
                    _gui.swLBL2.BackColor = Color.Transparent;
                    _gui.trtLBL2.BackColor = Color.Transparent;
                    _gui.info3.FillColor = Color.Transparent;
                    _gui.dptLBL3.BackColor = Color.Transparent;
                    _gui.LBLsw3.BackColor = Color.Transparent;
                    _gui.LBLtt3.BackColor = Color.Transparent;
                    _gui.swLBL3.BackColor = Color.Transparent;
                    _gui.trtLBL3.BackColor = Color.Transparent;
                    break;
            }
        }
    }
}
