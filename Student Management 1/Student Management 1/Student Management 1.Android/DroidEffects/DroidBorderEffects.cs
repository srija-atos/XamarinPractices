using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CreatingCuromRenderer.Droid.DroidEffects.Student_Management_1.Droid.DroidEffects;
using Student_Management_1.UIEffects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("CreatingCuromRenderer")]
[assembly: ExportEffect(typeof(DroidBorderEffects), nameof(EntryBorderEffects))]
namespace CreatingCuromRenderer.Droid.DroidEffects
{

    namespace Student_Management_1.Droid.DroidEffects
    {
        public class DroidBorderEffects : PlatformEffect
        {
            protected override void OnAttached()
            {
                if (Control != null)
                {

                    var nativeEditText = (Android.Widget.EditText)Control;
                    float[] arr1 = { 40, 40, 40, 40, 40, 40, 40, 40 };
                    float[] arr2 = { 40, 40, 40, 40, 40, 40, 40, 40 };
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RoundRectShape(arr1, null, arr2));
                    
                    shape.Paint.Color = Xamarin.Forms.Color.LightBlue.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.FillAndStroke);
                    shape.Paint.StrokeWidth = 4;
                   
                    nativeEditText.Background = shape;
                }
            }

            protected override void OnDetached()
            {

            }
        }
    }
}