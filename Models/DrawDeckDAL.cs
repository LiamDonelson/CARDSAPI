using Microsoft.AspNetCore.DataProtection.KeyManagement;
using RestSharp;

namespace CardsAPI.Models
{
    public class DrawDeckDAL
    {
        public DrawDeck GetDeck(int numb)
        {
            string url = $"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count={numb}";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync<DrawDeck>(request);
            DrawDeck sp = response.Result;
            return sp;
        }


        public Deck Deckitems(string Id)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{Id}/draw/?count=5";
            var client = new RestClient(url);
            var request = new RestRequest();
            var response = client.GetAsync<Deck>(request);
            Deck sp = response.Result;
            return sp;

        }



    }
}
