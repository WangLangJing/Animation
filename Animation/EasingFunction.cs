using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animation
{
    public delegate Double EasingFunctionHandler(Double time, Double begin, Double end, Double duration);

    public enum KnownEasingFuctionTypes
    {
        Linear,
  //      EaseIn, EaseOut, EaseInOut, BounceIn, BounceOut,
        QuadEaseOut, QuadEaseIn, QuadEaseInOut, QuadEaseOutIn,
        ExpoEaseOut, ExpoEaseIn, ExpoEaseInOut, ExpoEaseOutIn,
        CubicEaseOut, CubicEaseIn, CubicEaseInOut, CubicEaseOutIn,
        QuartEaseOut, QuartEaseIn, QuartEaseInOut, QuartEaseOutIn,
        QuintEaseOut, QuintEaseIn, QuintEaseInOut, QuintEaseOutIn,
        CircEaseOut, CircEaseIn, CircEaseInOut, CircEaseOutIn,
        SineEaseOut, SineEaseIn, SineEaseInOut, SineEaseOutIn,
        ElasticEaseOut, ElasticEaseIn, ElasticEaseInOut, ElasticEaseOutIn,
        BounceEaseOut, BounceEaseIn, BounceEaseInOut, BounceEaseOutIn,
        BackEaseOut, BackEaseIn, BackEaseInOut, BackEaseOutIn
    }
    public static class KnownEasingFunction
    {
  

        private static Dictionary<KnownEasingFuctionTypes, EasingFunctionHandler> _FunctionDict = new Dictionary<KnownEasingFuctionTypes, EasingFunctionHandler>
        {
                        { KnownEasingFuctionTypes.Linear,Linear},
                        //{ EasingFuctionTypes.EaseIn,EaseIn},
                        //{ EasingFuctionTypes.EaseOut,EaseOut},
                        //{ EasingFuctionTypes.EaseInOut,EaseInOut},
                        //{ EasingFuctionTypes.BounceIn,BounceIn},
                        //{ EasingFuctionTypes.BounceOut,BounceOut},
                        { KnownEasingFuctionTypes.QuadEaseOut,QuadEaseOut},
                        { KnownEasingFuctionTypes.QuadEaseIn,QuadEaseIn},
                        { KnownEasingFuctionTypes.QuadEaseInOut,QuadEaseInOut},
                        { KnownEasingFuctionTypes.QuadEaseOutIn,QuadEaseOutIn},
                        { KnownEasingFuctionTypes.ExpoEaseOut,ExpoEaseOut},
                        { KnownEasingFuctionTypes.ExpoEaseIn,ExpoEaseIn},
                        { KnownEasingFuctionTypes.ExpoEaseInOut,ExpoEaseInOut},
                        { KnownEasingFuctionTypes.ExpoEaseOutIn,ExpoEaseOutIn},
                        { KnownEasingFuctionTypes.CubicEaseOut,CubicEaseOut},
                        { KnownEasingFuctionTypes.CubicEaseIn,CubicEaseIn},
                        { KnownEasingFuctionTypes.CubicEaseInOut,CubicEaseInOut},
                        { KnownEasingFuctionTypes.CubicEaseOutIn,CubicEaseOutIn},
                        { KnownEasingFuctionTypes.QuartEaseOut,QuartEaseOut},
                        { KnownEasingFuctionTypes.QuartEaseIn,QuartEaseIn},
                        { KnownEasingFuctionTypes.QuartEaseInOut,QuartEaseInOut},
                        { KnownEasingFuctionTypes.QuartEaseOutIn,QuartEaseOutIn},
                        { KnownEasingFuctionTypes.QuintEaseOut,QuintEaseOut},
                        { KnownEasingFuctionTypes.QuintEaseIn,QuintEaseIn},
                        { KnownEasingFuctionTypes.QuintEaseInOut,QuintEaseInOut},
                        { KnownEasingFuctionTypes.QuintEaseOutIn,QuintEaseOutIn},
                        { KnownEasingFuctionTypes.CircEaseOut,CircEaseOut},
                        { KnownEasingFuctionTypes.CircEaseIn,CircEaseIn},
                        { KnownEasingFuctionTypes.CircEaseInOut,CircEaseInOut},
                        { KnownEasingFuctionTypes.CircEaseOutIn,CircEaseOutIn},
                        { KnownEasingFuctionTypes.SineEaseOut,SineEaseOut},
                        { KnownEasingFuctionTypes.SineEaseIn,SineEaseIn},
                        { KnownEasingFuctionTypes.SineEaseInOut,SineEaseInOut},
                        { KnownEasingFuctionTypes.SineEaseOutIn,SineEaseOutIn},
                        { KnownEasingFuctionTypes.ElasticEaseOut,ElasticEaseOut},
                        { KnownEasingFuctionTypes.ElasticEaseIn,ElasticEaseIn},
                        { KnownEasingFuctionTypes.ElasticEaseInOut,ElasticEaseInOut},
                        { KnownEasingFuctionTypes.ElasticEaseOutIn,ElasticEaseOutIn},
                        { KnownEasingFuctionTypes.BounceEaseOut,BounceEaseOut},
                        { KnownEasingFuctionTypes.BounceEaseIn,BounceEaseIn},
                        { KnownEasingFuctionTypes.BounceEaseInOut,BounceEaseInOut},
                        { KnownEasingFuctionTypes.BounceEaseOutIn,BounceEaseOutIn},
                        { KnownEasingFuctionTypes.BackEaseOut,BackEaseOut},
                        { KnownEasingFuctionTypes.BackEaseIn,BackEaseIn},
                        { KnownEasingFuctionTypes.BackEaseInOut,BackEaseInOut},
                        { KnownEasingFuctionTypes.BackEaseOutIn,BackEaseOutIn},
        };

        public static EasingFunctionHandler GetHandler(this KnownEasingFuctionTypes type)
        {
            return _FunctionDict[type];
        }
        /* EASING FUNCTIONS */

        #region Linear  

        /// <summary>  
        /// Easing equation function for a simple linear tweening, with no easing.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double Linear(Double t, Double b, Double c, Double d)
        {
            return c * t / d + b;
        }

        #endregion

        #region Expo  

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ExpoEaseOut(Double t, Double b, Double c, Double d)
        {
            return (t == d) ? b + c : c * (-Math.Pow(2, -10 * t / d) + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ExpoEaseIn(Double t, Double b, Double c, Double d)
        {
            return (t == 0) ? b : c * Math.Pow(2, 10 * (t / d - 1)) + b;
        }

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ExpoEaseInOut(Double t, Double b, Double c, Double d)
        {
            if (t == 0)
                return b;

            if (t == d)
                return b + c;

            if ((t /= d / 2) < 1)
                return c / 2 * Math.Pow(2, 10 * (t - 1)) + b;

            return c / 2 * (-Math.Pow(2, -10 * --t) + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for an exponential (2^t) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ExpoEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return ExpoEaseOut(t * 2, b, c / 2, d);

            return ExpoEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Circular  

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CircEaseOut(Double t, Double b, Double c, Double d)
        {

            return c * Math.Sqrt(1 - (t = t / d - 1) * t) + b;
        }

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CircEaseIn(Double t, Double b, Double c, Double d)
        {
            return -c * (Math.Sqrt(1 - (t /= d) * t) - 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CircEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2) < 1)
                return -c / 2 * (Math.Sqrt(1 - t * t) - 1) + b;

            return c / 2 * (Math.Sqrt(1 - (t -= 2) * t) + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a circular (sqrt(1-t^2)) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CircEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return CircEaseOut(t * 2, b, c / 2, d);

            return CircEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Quad  

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuadEaseOut(Double t, Double b, Double c, Double d)
        {
            return -c * (t /= d) * (t - 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuadEaseIn(Double t, Double b, Double c, Double d)
        {
            return c * (t /= d) * t + b;
        }

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuadEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t + b;

            return -c / 2 * ((--t) * (t - 2) - 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a quadratic (t^2) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuadEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return QuadEaseOut(t * 2, b, c / 2, d);

            return QuadEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Sine  

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double SineEaseOut(Double t, Double b, Double c, Double d)
        {
            return c * Math.Sin(t / d * (Math.PI / 2)) + b;
        }

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double SineEaseIn(Double t, Double b, Double c, Double d)
        {
            return -c * Math.Cos(t / d * (Math.PI / 2)) + c + b;
        }

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double SineEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * (Math.Sin(Math.PI * t / 2)) + b;

            return -c / 2 * (Math.Cos(Math.PI * --t / 2) - 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a sinusoidal (sin(t)) easing in/out:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double SineEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return SineEaseOut(t * 2, b, c / 2, d);

            return SineEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Cubic  

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CubicEaseOut(Double t, Double b, Double c, Double d)
        {
            return c * ((t = t / d - 1) * t * t + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CubicEaseIn(Double t, Double b, Double c, Double d)
        {
            return c * (t /= d) * t * t + b;
        }

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CubicEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t * t + b;

            return c / 2 * ((t -= 2) * t * t + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a cubic (t^3) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double CubicEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return CubicEaseOut(t * 2, b, c / 2, d);

            return CubicEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Quartic  

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuartEaseOut(Double t, Double b, Double c, Double d)
        {
            return -c * ((t = t / d - 1) * t * t * t - 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuartEaseIn(Double t, Double b, Double c, Double d)
        {
            return c * (t /= d) * t * t * t + b;
        }

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuartEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t * t * t + b;

            return -c / 2 * ((t -= 2) * t * t * t - 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a quartic (t^4) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuartEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return QuartEaseOut(t * 2, b, c / 2, d);

            return QuartEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Quintic  

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuintEaseOut(Double t, Double b, Double c, Double d)
        {
            return c * ((t = t / d - 1) * t * t * t * t + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuintEaseIn(Double t, Double b, Double c, Double d)
        {
            return c * (t /= d) * t * t * t * t + b;
        }

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuintEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2) < 1)
                return c / 2 * t * t * t * t * t + b;
            return c / 2 * ((t -= 2) * t * t * t * t + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a quintic (t^5) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double QuintEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return QuintEaseOut(t * 2, b, c / 2, d);
            return QuintEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Elastic  

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ElasticEaseOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d) == 1)
                return b + c;

            Double p = d * 0.3f;
            Double s = p / 4;

            return (c * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p) + c + b);
        }

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ElasticEaseIn(Double t, Double b, Double c, Double d)
        {
            if ((t /= d) == 1)
                return b + c;

            Double p = d * 0.3f;
            Double s = p / 4;

            return -(c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
        }

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ElasticEaseInOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d / 2f) == 2)
                return b + c;

            Double p = d * (0.3f * 1.5f);
            Double s = p / 4;

            if (t < 1)
                return -0.5f * (c * Math.Pow(2, 10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p)) + b;
            return c * Math.Pow(2, -10 * (t -= 1)) * Math.Sin((t * d - s) * (2 * Math.PI) / p) * 0.5f + c + b;
        }

        /// <summary>  
        /// Easing equation function for an elastic (exponentially decaying sine wave) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double ElasticEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return ElasticEaseOut(t * 2, b, c / 2, d);
            return ElasticEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Bounce  

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BounceEaseOut(Double t, Double b, Double c, Double d)
        {
            if ((t /= d) < (1 / 2.75f))
                return c * (7.5625f * t * t) + b;
            else if (t < (2 / 2.75f))
                return c * (7.5625f * (t -= (1.5f / 2.75f)) * t + 0.75f) + b;
            else if (t < (2.5f / 2.75f))
                return c * (7.5625f * (t -= (2.25f / 2.75f)) * t + 0.9375f) + b;
            else
                return c * (7.5625f * (t -= (2.625f / 2.75f)) * t + .984375f) + b;
        }

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BounceEaseIn(Double t, Double b, Double c, Double d)
        {
            return c - BounceEaseOut(d - t, 0, c, d) + b;
        }

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BounceEaseInOut(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return BounceEaseIn(t * 2, 0, c, d) * 0.5f + b;
            else
                return BounceEaseOut(t * 2 - d, 0, c, d) * 0.5f + c * 0.5f + b;
        }

        /// <summary>  
        /// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BounceEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return BounceEaseOut(t * 2, b, c / 2, d);
            return BounceEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion

        #region Back  

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out:   
        /// decelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BackEaseOut(Double t, Double b, Double c, Double d)
        {
            return c * ((t = t / d - 1) * t * ((1.70158f + 1) * t + 1.70158f) + 1) + b;
        }

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in:   
        /// accelerating from zero velocity.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BackEaseIn(Double t, Double b, Double c, Double d)
        {
            return c * (t /= d) * t * ((1.70158f + 1) * t - 1.70158f) + b;
        }

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing in/out:   
        /// acceleration until halfway, then deceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BackEaseInOut(Double t, Double b, Double c, Double d)
        {
            Double s = 1.70158f;
            if ((t /= d / 2) < 1)
                return c / 2 * (t * t * (((s *= (1.525f)) + 1) * t - s)) + b;
            return c / 2 * ((t -= 2) * t * (((s *= (1.525f)) + 1) * t + s) + 2) + b;
        }

        /// <summary>  
        /// Easing equation function for a back (overshooting cubic easing: (s+1)*t^3 - s*t^2) easing out/in:   
        /// deceleration until halfway, then acceleration.  
        /// </summary>  
        /// <param name="t">Current time in seconds.</param>  
        /// <param name="b">Starting value.</param>  
        /// <param name="c">Final value.</param>  
        /// <param name="d">Duration of animation.</param>  
        /// <returns>The correct value.</returns>  
        public static Double BackEaseOutIn(Double t, Double b, Double c, Double d)
        {
            if (t < d / 2)
                return BackEaseOut(t * 2, b, c / 2, d);
            return BackEaseIn((t * 2) - d, b + c / 2, c / 2, d);
        }

        #endregion
    }
}
