using System;

using Foundation;
using Ricardo.SDWebImage.iOS;
using UIKit;

namespace Ricardo.SDWebImage.iOS.Sample
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ImageView.Sd_setImageWithURL(new NSUrl("https://img.ricardostatic.ch/t_600/pl/764675504/0/1/14-carats-et-moins-gelbgoldring-mit-brillant-6298"));
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
