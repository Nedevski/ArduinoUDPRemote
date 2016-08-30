using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MjpegProcessor;

namespace ArduinoUDPRemote.StreamHelpers
{
    public class StreamCommander
    {
        private const string videoStreamUrl = "/video";
        private const string videoResolutionUrl = "/settings/video_size?set=";
        private const string photoResolutionUrl = "/settings/photo_size?set=";
        private const string qualityUrl = "/settings/quality?set=";
        private const string zoomUrl = "/settings/ptz?zoom=";
        private const string overlayUrl = "/settings/overlay?set=";
        private const string frontCameraUrl = "/settings/ffc?set=";
        private const string enableTorchUrl = "/enabletorch";
        private const string disableTorchUrl = "/disabletorch";


        private string baseUrl;
        public MjpegDecoder Decoder;

        public StreamCommander(string url)
        {
            Decoder = new MjpegDecoder();

            baseUrl = url;
        }

        public void Start()
        {
            string streamUri = string.Concat(baseUrl, videoStreamUrl);
            Decoder.ParseStream(new Uri(streamUri));

            //InitSettings();
        }

        public void Stop()
        {
            Decoder.StopStream();
        }
        
        public Image LatestFrame()
        {
            using (MemoryStream stream = new MemoryStream(Decoder.CurrentFrame))
            {
                return Image.FromStream(stream);
            }
        }

        public void SetResolution(string resolution)
        {
            ExecuteCommand(string.Concat(baseUrl, videoResolutionUrl, resolution));
        }

        public void ToggleLight(bool lightState)
        {
            if (lightState)
            {
                ExecuteCommand(string.Concat(baseUrl, enableTorchUrl));
            }
            else
            {
                ExecuteCommand(string.Concat(baseUrl, disableTorchUrl));
            }
        }

        public void ToggleFrontCamera(bool frontCameraState)
        {
            if (frontCameraState)
            {
                ExecuteCommand(string.Concat(baseUrl, frontCameraUrl, "on"));
            }
            else
            {
                ExecuteCommand(string.Concat(baseUrl, frontCameraUrl, "off"));
            }
        }

        private void InitSettings()
        {
            List<string> commands = new List<string>();

            commands.Add(string.Concat(baseUrl, videoResolutionUrl, "320x240"));
            commands.Add(string.Concat(baseUrl, qualityUrl, "50"));
            commands.Add(string.Concat(baseUrl, overlayUrl, "on"));

            foreach (var command in commands)
            {
                ExecuteCommand(command);
            }
        }

        private void ExecuteCommand(string url)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        }
    }
}
