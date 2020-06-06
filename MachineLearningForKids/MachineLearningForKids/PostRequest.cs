using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MachineLearningForKids
{
    public class PostRequest
    {

        public PostRequest()
        {

        }





        public string TitanicPredictionRequest(string data)
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\Titanic\\TitanicPredictorServer.py " + data;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        public string TitanicTrainRequest()
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\Titanic\\TitanicModelcreator.py ";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        public string RPS_Request()
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\RockPaperSic\\RPS_Predictor.py ";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }
        public string RPS_TrainRequest()
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\RockPaperSic\\createCnnUser.py ";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        internal object ZombieTrainRequest(string sensorsActive)
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\Zombie\\ZombieRoomsModelcreatorWithArgs.py " + sensorsActive;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        internal object ZombiePredictionRequest(string _predictionData)
        {

            string data = _predictionData.Replace(",", ".").Replace(";", ",");

            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\oyunlar\\MachineLearningForKids\\MachineLearningForKids\\bin\\Debug\\PythonServer\\Zombie\\ZombieRoomPredictor.py " + data;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }
    }
}
