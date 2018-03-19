using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Animation
{

    public partial class FrameGenerator
    {
        /// <summary>
        /// 到达指定时间时，触发一次帧
        /// </summary>
        public event Action<FrameGenerator, Object> FrameHappend;
        public Object State { get; private set; }

        public FPSMode FPSMode
        {
            get => this._fpsMode;  set
            {
                lock (_sync)
                {
                    this._fpsMode = value;
                    this.FrameInterval = SEC_MS / (Int32)this._fpsMode;
                    if (FPSMode.Unlimited == this._fpsMode)
                    {
                        this.FrameInterval = 0;
                    }
                }
            }
        }
        private FPSMode _fpsMode;
        public Int32 FrameInterval { get; private set; }

        /// <summary>
        /// 帧发生器自上次启动以来运行经过的时间 ms
        /// </summary>
        public Double ElapsedMilliseconds
        {
            get
            {
                return this._lastTickTime - this._lastStartTime;
            }
        }

        public Double LastStartTime
        {
            get => this._lastStartTime;
            private set
            {
                Interlocked.Exchange(ref this._lastStartTime, value);
            }
        }
        private Double _lastStartTime = 0;

        public Double LastTickTime
        {
            get => this._lastTickTime; private set
            {
                Interlocked.Exchange(ref this._lastStartTime, value);
            }
        }
        private Double _lastTickTime = 0;

        public Boolean IsBusying
        {
            get
            {
                return this._isBusying;
            }
            private set
            {
                this._isBusying = value;
            }
        }
        private Boolean _isBusying = false;

        public Boolean Started
        {
            get
            {
                return this._started;
            }
            private set
            {
                lock (_sync)
                    this._started = value;
            }
        }
        private Boolean _started = false;



        private Int32 _hashCode;
        private Object _sync = new Object();




        public void Start(Object state = null)
        {
            this.Started = true;
            this.State = state;
            this.ResetStartTime();
            AddGenerator(this);
        }
        /// <summary>
        /// 重置发生器的启动时间
        /// </summary>
        public void ResetStartTime()
        {
            this.IsBusying = true;
            var currentTime = GetTime();
            this.LastStartTime = currentTime;
            this.IsBusying = false;
        }
        public void Stop()
        {
            this.Started = false;
            RemoveGenerator(this);

        }

        public override Int32 GetHashCode()
        {
            return this._hashCode;
        }
        private Boolean CanTick(Double currentTime)
        {
            if (!this.IsBusying && this.Started)
            {
                if (currentTime - this.LastTickTime > this.FrameInterval)
                {
                    return true;
                }
            }
            return false;
        }
        private void Tick(Double currentTime)
        {
            if (this.CanTick(currentTime))
            {
                this.IsBusying = true;
                this.OnFrameHappend();
                this.LastTickTime = currentTime;
                this.IsBusying = false;
            }
        }
        private void OnFrameHappend()
        {
            this.FrameHappend?.Invoke(this, this.State);
        }

        public FrameGenerator()
        {
            this._hashCode = GenerateHashCode();
            this.FPSMode = FPSMode.Limited30;
        }
        public FrameGenerator(FPSMode mode) : this()
        {
            this.FPSMode = mode;
        }
        public FrameGenerator(Object state) : this()
        {
            this.State = state;
        }






    }
}
