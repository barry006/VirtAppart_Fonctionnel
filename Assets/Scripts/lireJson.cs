using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Globalization;
using UnityEngine.UI;
using TMPro;
using System;
using System.Text;

namespace DeserializeExtra
{
    public class lireJson : MonoBehaviour
    {
        [SerializeField] PlayerInfo playerInfo = new PlayerInfo();
        //[SerializeField] MyCollection collection = new MyCollection();

        private void Start()
        {
            LoadFromJson2();
        }



        public class Root
        {
            public string name { get; set; }
            public int midi { get; set; }
            public double time { get; set; }
            public double velocity { get; set; }
            public double duration { get; set; }
        }



        public void LoadFromJson2()
        {

            string filePath = Application.dataPath + "/VisiPiano.json";   /// add nom du json = nom du script ou du parent du script.
            string classData = File.ReadAllText(filePath);


            PlayerInfo? playerInfo = JsonUtility.FromJson<PlayerInfo>(classData);
            // playerInfo = JsonUtility.FromJson<PlayerInfo>(classData);
        }



        [System.Serializable]
        public class PlayerInfo
        {

            public string name { get; set; }
            public int midi { get; set; }
            public double time { get; set; }
            public double velocity { get; set; }
            public double duration { get; set; }

            /*
            public List<string> name;
            public List<int> midi;
            public List<float> time;
            public List<float> velocity;
            public List<float> duration;*/
            /*
            public string name;
            public int midi;
            public float time;
            public float velocity;
            public float duration;
            */
        }





        void ddd()
        {

            string jsonString = "{\"playerId\":\"8484239823\",\"playerLoc\":\"Powai\",\"playerNick\":\"Random Nick\"}";
            Player player = JsonUtility.FromJson<Player>(jsonString);
            Debug.Log(player.playerLoc);
        }

        void ddd2()
        {
            string filePath2 = Application.dataPath + "/VisiPiano.json";
            string classData2 = File.ReadAllText(filePath2);

            //string jsonString = "{\"playerId\":\"8484239823\",\"playerLoc\":\"Powai\",\"playerNick\":\"Random Nick\"}";
            Player player = JsonUtility.FromJson<Player>(classData2);
            // fixJson("playerLoc");
            Debug.Log(player.playerLoc);







        }

        string fixJson(string value)
        {
            value = "{\"Items\":" + value + "}";
            return value;
        }








        public static class JsonHelper
        {
            public static T[] FromJson<T>(string json)
            {
                Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(json);
                return wrapper.Items;
            }

            public static string ToJson<T>(T[] array)
            {
                Wrapper<T> wrapper = new Wrapper<T>();
                wrapper.Items = array;
                return JsonUtility.ToJson(wrapper);
            }

            public static string ToJson<T>(T[] array, bool prettyPrint)
            {
                Wrapper<T> wrapper = new Wrapper<T>();
                wrapper.Items = array;
                return JsonUtility.ToJson(wrapper, prettyPrint);
            }

            [Serializable]
            private class Wrapper<T>
            {
                public T[] Items;
            }






        }

        [Serializable]
        public class Player
        {
            public string playerId;
            public string playerLoc;
            public string playerNick;
        }


        void abs()
        {
            Player[] playerInstance = new Player[2];

            playerInstance[0] = new Player();
            playerInstance[0].playerId = "8484239823";
            playerInstance[0].playerLoc = "Powai";
            playerInstance[0].playerNick = "Random Nick";

            playerInstance[1] = new Player();
            playerInstance[1].playerId = "512343283";
            playerInstance[1].playerLoc = "User2";
            playerInstance[1].playerNick = "Rand Nick 2";

            //Convert to JSON
            string playerToJson = JsonHelper.ToJson(playerInstance, true);
            Debug.Log(playerToJson);
        }



    }
}



  



   
