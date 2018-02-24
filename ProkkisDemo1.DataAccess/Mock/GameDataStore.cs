using ProkkisDemo1.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProkkisDemo1.Business.Mock
{
    /// <summary>
    /// Mocking data
    /// </summary>
    public class GameDataStore : IRepository<Game>
    {
        private List<Game> games;

        public List<Game> GetList()
        {
            games = new List<Game>();
            games.Add(
                new Game() { Id = 1, Name = "Monkey Island", PublishDate = new DateTime(1992, 2, 11) }
            );
            games.Add(
                new Game() { Id = 2, Name = "Diablo 3", PublishDate = new DateTime(2015, 04, 23) }
            );

            return games;
        }
    }
}
