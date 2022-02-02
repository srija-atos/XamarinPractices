using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;


using Student_Management_1.CustomRenderes;
using Student_Management_1.Droid.CustomRenderer;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryBorderRenderer), typeof(DroidEntryBorderRenderer))]
namespace Student_Management_1.Droid.CustomRenderer
{
    public class DroidEntryBorderRenderer : EntryRenderer
    {
        public DroidEntryBorderRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var nativeEditText = (Android.Widget.EditText)Control;
                float[] arr1 = { 40, 40, 40, 40, 40, 40, 40, 40 };
                float[] arr2 = { 40, 40, 40, 40, 40, 40, 40, 40 };
                var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RoundRectShape(arr1, null, arr2));
                shape.Paint.Color = Xamarin.Forms.Color.White.ToAndroid();
                shape.Paint.SetStyle(Paint.Style.Stroke);
                shape.Paint.StrokeWidth = 4;
                nativeEditText.Background = shape;
            }
        }
    }
}