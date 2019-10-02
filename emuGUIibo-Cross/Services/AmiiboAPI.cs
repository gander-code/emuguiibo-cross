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
        private readonly string AMIIBO_API_URL = "https://www.amiiboapi.com/api/amiibo/";
        public List<string> Series = new List<string>();
        public List<Amiibo> AllAmiibos = new List<Amiibo>();

        public void LoadAllAmiibos()
        {
            WebClient client = new WebClient();
            try
            {
                JObject json = JObject.Parse(client.DownloadString(AMIIBO_API_URL));
                AllAmiibos.Clear();
                foreach (JToken amiibo in json["amiibo"])
                {
                    AllAmiibos.Add(new Amiibo
                    {
                        AmiiboName = amiibo["name"].ToString(),
                        SeriesName = amiibo["amiiboSeries"].ToString(),
                        CharacterName = amiibo["character"].ToString(),
                        ImageURL = amiibo["image"].ToString(),
                        AmiiboId = amiibo["head"].ToString() + amiibo["tail"].ToString()
                    });
                }

                Series = AllAmiibos.AsQueryable().Select(amiibo => amiibo.SeriesName.ToString()).Distinct().ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                client?.Dispose();
            }
        }
    }
}