using System;
using System.Drawing;
using DevExpress.XtraSplashScreen;

namespace QuanLySanXuat.Class
{
    public class OverlayLoading
    {
        public void StartLoading(System.Windows.Forms.Control strlenh)
        {
            try
            {
                var backColor = Color.Transparent;
                var foreColor = Color.Transparent;
                var opacity = 0.5;
                var waitImage = Image.FromFile("Images\\2.gif");
                var options = new OverlayWindowOptions(false, false, backColor, foreColor, opacity, waitImage);
                handle = ShowProgressPanel(options, strlenh);
            }
            catch (Exception)
            {
                //null
            }

        }

        public void EndLoading()
        {
            CloseProgressPanel(handle);
        }
        IOverlaySplashScreenHandle ShowProgressPanel(OverlayWindowOptions option, System.Windows.Forms.Control strlenh)
        {
            return SplashScreenManager.ShowOverlayForm(strlenh, option);
        }
        void CloseProgressPanel(IOverlaySplashScreenHandle handle)
        {
            if (handle != null)
                SplashScreenManager.CloseOverlayForm(handle);
        }

        private IOverlaySplashScreenHandle handle = null;
    }
}
