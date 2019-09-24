using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using emuGUIibo_Cross.Models;
using Newtonsoft.Json.Linq;

namespace emuGUIibo_Cross.Services
{
    public class AmiiboAPI
    {
        private static readonly string AMIIBO_API_URL = "https://www.amiiboapi.com/api/amiibo/";
        public static IEnumerable<string> Series
        {
            get { return Amiibos != null ? Amiibos.Select(a => a.SeriesName).Distinct() : new List<string>(); }
        }
        private static List<Amiibo> _amiibos = new List<Amiibo>();
        public static IEnumerable<Amiibo> Amiibos {
            get
            {
                if (_amiibos.Count == 0) _amiibos = GetAllAmiibos();
                return _amiibos;
            }
        }

        private static List<Amiibo> GetAllAmiibos()
        {
            var newAmiiboList = new List<Amiibo>();
            WebClient client = new WebClient();
            try
            {
                JObject json = JObject.Parse(client.DownloadString(AMIIBO_API_URL));
                _amiibos.Clear();
                foreach (JToken amiibo in json["amiibo"])
                {
                    newAmiiboList.Add(new Amiibo
                    {
                        AmiiboName = amiibo["name"].ToString(),
                        SeriesName = amiibo["amiiboSeries"].ToString(),
                        CharacterName = amiibo["character"].ToString(),
                        ImageURL = amiibo["image"].ToString(),
                        AmiiboId = amiibo["head"].ToString() + amiibo["tail"].ToString()
                    });
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } finally
            {
                if (client != null) client.Dispose();
            }
            return newAmiiboList;
        } 
    }
}