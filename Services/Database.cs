using System.Collections.Generic;
using emuGUIibo_Cross.Models;

namespace emuGUIibo_Cross.Services {
    public class Database {
        public IEnumerable<Amiibo> GetItems() => new[] {
            new Amiibo {
                AmiiboName = "TestName",
                SeriesName = "TestSeries",
                CharacterName = "TestCharacter",
                ImageURL = "http://localhost/test.png",
                AmiiboId = "TestId"
            },
            new Amiibo {
                AmiiboName = "TestName2",
                SeriesName = "TestSeries",
                CharacterName = "TestCharacter2",
                ImageURL = "http://localhost/test.png",
                AmiiboId = "TestId2"
            },
            new Amiibo {
                AmiiboName = "TestName3",
                SeriesName = "TestSeries2",
                CharacterName = "TestCharacter3",
                ImageURL = "http://localhost/test3.png",
                AmiiboId = "TestId3"
            }
        };
    }
}