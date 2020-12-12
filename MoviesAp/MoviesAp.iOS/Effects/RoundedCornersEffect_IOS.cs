using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CoreAnimation;
using Foundation;
using MoviesAp.Effects;
using MoviesAp.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MoviesAp")]
[assembly: ExportEffect(typeof(RoundedCornersEffect_IOS), nameof(RoundCornersEffect))]
namespace MoviesAp.iOS.Effects
{
    public class RoundedCornersEffect_IOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                PrepareContainer();
                SetCornerRadius();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        protected override void OnDetached()
        {
            try
            {
                Container.Layer.CornerRadius = new nfloat(0);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            if (args.PropertyName == RoundCornersEffect.CornerRadiusProperty.PropertyName)
                SetCornerRadius();
        }

        private void PrepareContainer()
        {
            Container.ClipsToBounds = true;
            Container.Layer.AllowsEdgeAntialiasing = true;
            Container.Layer.EdgeAntialiasingMask = CAEdgeAntialiasingMask.All;
        }

        private void SetCornerRadius()
        {
            var cornerRadius = RoundCornersEffect.GetCornerRadius(Element);
            Container.Layer.CornerRadius = new nfloat(cornerRadius);
        }
    }
}