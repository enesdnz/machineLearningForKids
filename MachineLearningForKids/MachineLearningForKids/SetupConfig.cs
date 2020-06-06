using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MachineLearningForKids
{
    public class SetupConfig
    {

        public string TitanicUserDataPath { get; set; }
        public string TitanicDefaultDataPath { get; set; }
        public string TitanicUserModelPath { get; set; }
        public string TitanicDefaultModelPath { get; set; }


        public string ZombieDefaultDataPath { get; set; }
        public List<Double> ZombieMinMax { get; set; }

        public string RPSUserModelPath { get; set; }
        public string RPSDefaultDataPath { get; set; }
        public string RPSImageToPredict { get; set; }


        public SetupConfig()
        {

            TitanicUserDataPath = "PythonServer/Titanic/TitanicUserValues.csv";
            TitanicDefaultDataPath = "PythonServer/Titanic/TitanicDefaultValues.csv";
            TitanicUserModelPath = "PythonServer/Titanic/gnb.sav";
            TitanicDefaultModelPath = "PythonServer/Titanic/gnbDefault.sav";




            ZombieDefaultDataPath = "PythonServer/Zombie/RoomData.csv";
            ZombieMinMax = new List<double>(){
            38000,159000,
            800,15800,
            0,16600,
            6000,658000,
            90,6110,
            10000,2890000,
            60000,4400000,
            9871,10390,
            27200,40100,
            2200,20000,
            80000,149000,
            30000,90000
            };


            RPSDefaultDataPath = "PythonServer/RockPaperSic/gnb_RPSDefault.sav";
            RPSUserModelPath = "PythonServer/RockPaperSic/gnb_RPS.sav";
            RPSImageToPredict = @"PythonServer\RockPaperSic\dataset\single_prediction\" + "ImageToPredict.jpg";

        }
    }
}
