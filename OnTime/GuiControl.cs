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
                    //back and fill color
                    _gui.info1.FillColor = Color.FromArgb(0, 154, 224);
                    _gui.dptLBL1.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLsw1.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLtt1.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.swLBL1.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.trtLBL1.BackColor = Color.FromArgb(0, 154, 224);

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

                    //text color
                    _gui.swLBL1.ForeColor = Color.White;
                    _gui.trtLBL1.ForeColor = Color.White;
                    _gui.LBLtt1.ForeColor = Color.White;
                    _gui.LBLsw1.ForeColor = Color.White;
                    _gui.dptLBL1.ForeColor = Color.White;

                    _gui.dptLBL2.ForeColor = Color.Black;
                    _gui.LBLsw2.ForeColor = Color.Black;
                    _gui.LBLtt2.ForeColor = Color.Black;
                    _gui.swLBL2.ForeColor = Color.Black;
                    _gui.trtLBL2.ForeColor = Color.Black;
                    _gui.dptLBL3.ForeColor = Color.Black;
                    _gui.LBLsw3.ForeColor = Color.Black;
                    _gui.LBLtt3.ForeColor = Color.Black;
                    _gui.swLBL3.ForeColor = Color.Black;
                    _gui.trtLBL3.ForeColor = Color.Black;
                    _gui.dptLBL4.ForeColor = Color.Black;
                    _gui.LBLsw4.ForeColor = Color.Black;
                    _gui.LBLtt4.ForeColor = Color.Black;
                    _gui.swLBL4.ForeColor = Color.Black;
                    _gui.trtLBL4.ForeColor = Color.Black;
                    break;
                case 2:
                    //back and fill color
                    _gui.info2.FillColor = Color.FromArgb(0, 154, 224);
                    _gui.dptLBL2.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLsw2.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLtt2.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.swLBL2.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.trtLBL2.BackColor = Color.FromArgb(0, 154, 224);

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

                    //text color
                    _gui.swLBL1.ForeColor = Color.Black;
                    _gui.trtLBL1.ForeColor= Color.Black;
                    _gui.LBLtt1.ForeColor = Color.Black;
                    _gui.LBLsw1.ForeColor = Color.Black;
                    _gui.dptLBL1.ForeColor = Color.Black;

                    _gui.dptLBL2.ForeColor = Color.White;
                    _gui.LBLsw2.ForeColor = Color.White;
                    _gui.LBLtt2.ForeColor = Color.White;
                    _gui.swLBL2.ForeColor = Color.White;
                    _gui.trtLBL2.ForeColor = Color.White;

                    _gui.dptLBL3.ForeColor = Color.Black;
                    _gui.LBLsw3.ForeColor = Color.Black;
                    _gui.LBLtt3.ForeColor = Color.Black;
                    _gui.swLBL3.ForeColor = Color.Black;
                    _gui.trtLBL3.ForeColor = Color.Black;
                    _gui.dptLBL4.ForeColor = Color.Black;
                    _gui.LBLsw4.ForeColor = Color.Black;
                    _gui.LBLtt4.ForeColor = Color.Black;
                    _gui.swLBL4.ForeColor = Color.Black;
                    _gui.trtLBL4.ForeColor = Color.Black;
                    break;
                case 3:
                    //back and fill color
                    _gui.info3.FillColor = Color.FromArgb(0, 154, 224);
                    _gui.dptLBL3.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLsw3.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLtt3.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.swLBL3.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.trtLBL3.BackColor = Color.FromArgb(0, 154, 224);

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

                    //text color
                    _gui.swLBL1.ForeColor = Color.Black;
                    _gui.trtLBL1.ForeColor= Color.Black;
                    _gui.LBLtt1.ForeColor = Color.Black;
                    _gui.LBLsw1.ForeColor = Color.Black;
                    _gui.dptLBL1.ForeColor = Color.Black;
                    _gui.dptLBL2.ForeColor = Color.Black;
                    _gui.LBLsw2.ForeColor = Color.Black;
                    _gui.LBLtt2.ForeColor = Color.Black;
                    _gui.swLBL2.ForeColor = Color.Black;
                    _gui.trtLBL2.ForeColor = Color.Black;

                    _gui.dptLBL3.ForeColor = Color.White;
                    _gui.LBLsw3.ForeColor = Color.White;
                    _gui.LBLtt3.ForeColor = Color.White;
                    _gui.swLBL3.ForeColor = Color.White;
                    _gui.trtLBL3.ForeColor = Color.White;

                    _gui.dptLBL4.ForeColor = Color.Black;
                    _gui.LBLsw4.ForeColor = Color.Black;
                    _gui.LBLtt4.ForeColor = Color.Black;
                    _gui.swLBL4.ForeColor = Color.Black;
                    _gui.trtLBL4.ForeColor = Color.Black;
                    break;
                case 4:
                    //back and fill color
                    _gui.info4.FillColor = Color.FromArgb(0, 154, 224);
                    _gui.dptLBL4.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLsw4.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.LBLtt4.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.swLBL4.BackColor = Color.FromArgb(0, 154, 224);
                    _gui.trtLBL4.BackColor = Color.FromArgb(0, 154, 224);

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

                    //text color
                    _gui.swLBL1.ForeColor  = Color.Black;
                    _gui.trtLBL1.ForeColor= Color.Black;
                    _gui.LBLtt1.ForeColor = Color.Black;
                    _gui.LBLsw1.ForeColor = Color.Black;
                    _gui.dptLBL1.ForeColor = Color.Black;
                    _gui.dptLBL2.ForeColor = Color.Black;
                    _gui.LBLsw2.ForeColor = Color.Black;
                    _gui.LBLtt2.ForeColor = Color.Black;
                    _gui.swLBL2.ForeColor = Color.Black;
                    _gui.trtLBL2.ForeColor = Color.Black;
                    _gui.dptLBL3.ForeColor = Color.Black;
                    _gui.LBLsw3.ForeColor = Color.Black;
                    _gui.LBLtt3.ForeColor = Color.Black;
                    _gui.swLBL3.ForeColor = Color.Black;
                    _gui.trtLBL3.ForeColor = Color.Black;

                    _gui.dptLBL4.ForeColor = Color.White;
                    _gui.LBLsw4.ForeColor = Color.White;
                    _gui.LBLtt4.ForeColor = Color.White;
                    _gui.swLBL4.ForeColor = Color.White;
                    _gui.trtLBL4.ForeColor = Color.White;
                    break;
            }
        }
    }
}
