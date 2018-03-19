using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animation
{
    public partial class Animator
    {
        public Boolean IsPlaying { get; private set; }

        /// <summary>
        /// 当前激活的路径
        /// </summary>
        public Path ActivatedPath { get; private set; } = null;

        public FrameGenerator FrameGenerator { get; private set; }

        public Animator()
        {
            this.FrameGenerator = new FrameGenerator();
            this.FrameGenerator.FrameHappend += FrameGenerator_FrameHappend;
        }
        public Animator(FPSMode mode) : this()
        {
            this.FrameGenerator.FPSMode = mode;
        }

        private void FrameGenerator_FrameHappend(FrameGenerator generator, Object state)
        {
            this.Tick(generator,state);
        }

     

        private void Tick(FrameGenerator generator, Object state)
        {

        }

        public void AddPath(Path path)
        {

        }
        //每一帧
        //先计算，后绘制
        public void Play(Control actor, Action<Control, Vector> rending)
        {





        }
    }
}
