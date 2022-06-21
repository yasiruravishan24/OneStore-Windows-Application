using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArduinoUploader;
using System.IO.Ports;

namespace oneStore
{
    class arduinoUploadClass
    {
        public void unlockcode()
        {
            var Uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                    FileName = @"upHex.ino.hex",
                    PortName = "COM4",
                    ArduinoModel = ArduinoUploader.Hardware.ArduinoModel.UnoR3

                });
                Uploader.UploadSketch();

        }
        public void enrollcode()
        {
            var Uploader = new ArduinoSketchUploader(
                 new ArduinoSketchUploaderOptions()
                 {
                       FileName = @"enHex.ino.hex",
                       PortName = "COM4",
                       ArduinoModel = ArduinoUploader.Hardware.ArduinoModel.UnoR3

                 });
                 Uploader.UploadSketch();
        }
        public void deletecode()
        {
            var Uploader = new ArduinoSketchUploader(
                new ArduinoSketchUploaderOptions()
                {
                       FileName = @"deHex.ino.hex",
                       PortName = "COM4",
                       ArduinoModel = ArduinoUploader.Hardware.ArduinoModel.UnoR3
                });
                Uploader.UploadSketch();
        }
    }
}
