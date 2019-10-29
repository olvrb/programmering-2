using NAudio.Wave;
using System;
using System.Collections.Generic;

namespace tuner
{
    public class Sound
    {
        BufferedWaveProvider bufferedWaveProvider = null;
        Dictionary<string, float> noteBaseFreqs = new Dictionary<string, float>()
            {
                { "C", 16.35f },
                { "C#", 17.32f },
                { "D", 18.35f },
                { "Eb", 19.45f },
                { "E", 20.60f },
                { "F", 21.83f },
                { "F#", 23.12f },
                { "G", 24.50f },
                { "G#", 25.96f },
                { "A", 27.50f },
                { "Bb", 29.14f },
                { "B", 30.87f },
            };

        public Dictionary<int, string> GetInputDevices()
        {
            Dictionary<int, string> devices = new Dictionary<int, string>();

            for (int i = 0; i < WaveInEvent.DeviceCount; i++)
            {
                devices.Add(i, WaveInEvent.GetCapabilities(i).ProductName);
            }
            return devices;
        }

        public int SelectInputDevice()
        {
            int inputDevice = 0;
            bool isValidChoice = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Please select input or recording device: ");

                for (int i = 0; i < WaveInEvent.DeviceCount; i++)
                {
                    Console.WriteLine(i + ". " + WaveInEvent.GetCapabilities(i).ProductName);
                }

                Console.WriteLine();

                try
                {
                    if (int.TryParse(Console.ReadLine(), out inputDevice))
                    {
                        isValidChoice = true;
                        Console.WriteLine("You have chosen " + WaveInEvent.GetCapabilities(inputDevice).ProductName + ".\n");
                    }
                    else
                    {
                        isValidChoice = false;
                    }
                }
                catch
                {
                    throw new ArgumentException("Device # chosen is out of range.");
                }

            } while (isValidChoice == false);

            return inputDevice;
        }

        

        public float GetPitch(int inputDevice)
        {
            WaveInEvent waveIn = new WaveInEvent();

            waveIn.DeviceNumber = inputDevice;
            waveIn.WaveFormat = new WaveFormat(44100, 1);
            waveIn.DataAvailable += WaveIn_DataAvailable;

            bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

            // begin record
            waveIn.StartRecording();

            IWaveProvider stream = new Wave16ToFloatProvider(bufferedWaveProvider);
            Pitch pitch = new Pitch(stream);

            byte[] buffer = new byte[8192];
            int bytesRead;


            bytesRead = stream.Read(buffer, 0, buffer.Length);

            float freq = pitch.Get(buffer);

            // stop recording
            waveIn.StopRecording();
            waveIn.Dispose();

            return freq;                   
        }

        void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (bufferedWaveProvider != null)
            {
                bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
                bufferedWaveProvider.DiscardOnBufferOverflow = true;
            }
        }

        public string GetNote(float freq)
        {
            float baseFreq;

            foreach (var note in noteBaseFreqs)
            {
                baseFreq = note.Value;

                for (int i = 0; i < 9; i++)
                {
                    if ((freq >= baseFreq - 0.5) && (freq < baseFreq + 0.485) || (freq == baseFreq))
                    {
                        return note.Key + i;
                    }

                    baseFreq *= 2;
                }
            }

            return null;
        }
    }
}
