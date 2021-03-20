using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace Database {
    public class DatabaseConnector {
        private static string url = "https://blooming-wildwood-26825.herokuapp.com";
        private static HttpClient client = new HttpClient();
        private static HttpContent httpContent = new StringContent("");

        public delegate void GetDifficultyCallback(float difficulty);
        public delegate void GetYearCallback(int currentYear, bool isEnd);

        public static async void NewScore(string username, int score) {
            HttpResponseMessage res = await client.PostAsync(url + "/newScore?userName=" + username + "&score=" + score, httpContent);
            res.EnsureSuccessStatusCode();
        }

        public static async void GetDifficulty(GetDifficultyCallback callback) {
            HttpResponseMessage res = await client.GetAsync(url + "/getDifficulty");
            res.EnsureSuccessStatusCode();
            string content = await res.Content.ReadAsStringAsync();
            DifficultyRespose difficultyRespose = JsonUtility.FromJson<DifficultyRespose>(content);
            callback(difficultyRespose.difficulty);
        }

        public static async void GetYear(GetYearCallback callback) {
            HttpResponseMessage res = await client.GetAsync(url + "/getYear");
            res.EnsureSuccessStatusCode();
            string content = await res.Content.ReadAsStringAsync();
            YearRespose yearRespose = JsonUtility.FromJson<YearRespose>(content);
            callback(yearRespose.currentYear, yearRespose.isEnd);
        }

        private class DifficultyRespose {
            public float difficulty;
        }

        private class YearRespose {
            public int currentYear;
            public bool isEnd;
        }
    }
}