using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.IO;
using System.Threading;

namespace SmartHome.StyleControls
{
    /// <summary>
    /// 聲音撥放器類別
    /// </summary>
    public class SoundPlayer : IDisposable
    {
        private WaveOut _speaker = null;
        private ReaderWriterLockSlim _lock = null;
        public void Initialize(string name)
        {
            if (name == "")
            {
                MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
                MMDevice device = enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
                name = device.FriendlyName;
            }

            int deviceNumber = -1;
            for (int index = 0; index < WaveOut.DeviceCount; index++)
            {
                if (name.IndexOf(WaveOut.GetCapabilities(index).ProductName) == 0) { deviceNumber = index; break; }
            }
            if (deviceNumber == -1) { throw new ArgumentException("speaker does not exist"); }

            _lock = new ReaderWriterLockSlim();
            _speaker = new WaveOut();
            _speaker.DeviceNumber = deviceNumber;
        }
        /// <summary>
        /// 建構函式
        /// </summary>
        public SoundPlayer() : base()
        {
            Initialize("");
        }
        /// <summary>
        /// 建構函式
        /// </summary>
        /// <param name="name">名稱</param>
        public SoundPlayer(string name) : base()
        {
            Initialize(name);
        }

        private string _playId = "";
        private System.Threading.Timer _timer = null;
        private LoopStream _player = null;
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sound">聲音</param>
        /// <param name="looping">循環撥放</param>
        /// <param name="time">播放時間</param>
        public string Play(Stream sound, bool looping, TimeSpan time)
        {
            string r = "";
            Stop();
            if (_lock != null)
            {
                _player = new LoopStream(new WaveFileReader(sound));
                _player.EnableLooping = looping;
                _speaker.Init(_player);
                _speaker.Play();
                r = Guid.NewGuid().ToString();
                _playId = r;
                if (time != TimeSpan.Zero)
                {
                    _timer = new Timer((object e) => { Stop((string)e); }, r, time, TimeSpan.Zero);
                }
            }
            return r;
        }
        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sound">聲音</param>
        /// <param name="looping">循環撥放</param>
        public string Play(Stream sound, bool looping)
        {
            return Play(sound, looping, TimeSpan.Zero);
        }

        /// <summary>
        /// 播放
        /// </summary>
        /// <param name="sound">聲音</param>
        public string Play(Stream sound)
        {
            return Play(sound, false, TimeSpan.Zero);
        }

        /// <summary>
        /// 停止
        /// </summary>
        public bool Stop()
        {
            return Stop("");
        }

        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="playId">播放代號</param>
        public bool Stop(string playId)
        {
            bool r = false;
            if (_lock != null)
            {
                _lock.EnterWriteLock();
                try
                {
                    if (_playId != "")
                    {
                        if (playId == "" | _playId == playId)
                        {
                            if (_timer != null) { _timer.Dispose(); _timer = null; }
                            _speaker.Stop();
                            if (_player != null) { _player.Dispose(); _player = null; }
                        }
                        _playId = "";
                        r = true;
                    }
                }
                finally { _lock.ExitWriteLock(); }
            }

            return r;
        }

        #region IDisposable Support
        private bool disposedValue = false; // 偵測多餘的呼叫

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 處置 Managed 狀態 (Managed 物件)。
                    Stop();

                    if (_speaker != null)
                    {
                        _speaker.Dispose();
                        _speaker = null;
                    }

                    _lock.EnterWriteLock();
                    _lock.ExitWriteLock();
                    _lock.Dispose();
                    _lock = null;
                }

                // TODO: 釋放 Unmanaged 資源 (Unmanaged 物件) 並覆寫下方的完成項。
                // TODO: 將大型欄位設為 null。

                disposedValue = true;
            }
        }

        // TODO: 僅當上方的 Dispose(bool disposing) 具有會釋放 Unmanaged 資源的程式碼時，才覆寫完成項。
        // ~SoundPlayer() {
        //   // 請勿變更這個程式碼。請將清除程式碼放入上方的 Dispose(bool disposing) 中。
        //   Dispose(false);
        // }

        // 加入這個程式碼的目的在正確實作可處置的模式。
        public void Dispose()
        {
            // 請勿變更這個程式碼。請將清除程式碼放入上方的 Dispose(bool disposing) 中。
            Dispose(true);
            // TODO: 如果上方的完成項已被覆寫，即取消下行的註解狀態。
            GC.SuppressFinalize(this);
        }
        #endregion
    }

    /// <summary>
    /// Stream for looping playback
    /// </summary>
    class LoopStream : WaveStream
    {
        WaveStream sourceStream;

        /// <summary>
        /// Creates a new Loop stream
        /// </summary>
        /// <param name="sourceStream">The stream to read from. Note: the Read method of this stream should return 0 when it reaches the end
        /// or else we will not loop to the start again.</param>
        public LoopStream(WaveStream sourceStream)
        {
            this.sourceStream = sourceStream;
            this.EnableLooping = true;
        }

        /// <summary>
        /// Use this to turn looping on or off
        /// </summary>
        public bool EnableLooping { get; set; }

        /// <summary>
        /// Return source stream's wave format
        /// </summary>
        public override WaveFormat WaveFormat
        {
            get { return sourceStream.WaveFormat; }
        }

        /// <summary>
        /// LoopStream simply returns
        /// </summary>
        public override long Length
        {
            get { return sourceStream.Length; }
        }

        /// <summary>
        /// LoopStream simply passes on positioning to source stream
        /// </summary>
        public override long Position
        {
            get { return sourceStream.Position; }
            set { sourceStream.Position = value; }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytesRead = 0;

            while (totalBytesRead < count && sourceStream != null)
            {
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                if (bytesRead == 0)
                {
                    if (sourceStream.Position == 0 || !EnableLooping)
                    {
                        // something wrong with the source stream
                        break;
                    }
                    // loop
                    sourceStream.Position = 0;
                }
                totalBytesRead += bytesRead;
            }
            return totalBytesRead;
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (sourceStream != null) { sourceStream.Dispose(); sourceStream = null; }
        }
    }
}
