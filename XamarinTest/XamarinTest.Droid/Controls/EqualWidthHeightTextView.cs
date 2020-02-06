using System;
using Android.Content;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;

namespace XamarinTest.Droid.Controls
{
    public class EqualWidthHeightTextView : AppCompatTextView
    {
        public EqualWidthHeightTextView(Context context) : base(context)
        {
        }

        public EqualWidthHeightTextView(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public EqualWidthHeightTextView(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        protected EqualWidthHeightTextView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
            int r = Math.Max(MeasuredWidth, MeasuredHeight);
            SetMeasuredDimension(r, r);
        }
       
    }
}
