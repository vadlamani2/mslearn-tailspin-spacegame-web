using Newtonsoft.Json;

namespace TailSpin.SpaceGame.Web.Models
{
    public class Score : Model
    {
        // The ID of the player profile associated with this score.
        // New comment added by subbarao vadlamani
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }

        // The score value.
        [JsonProperty(PropertyName = "score")]
        public int HighScore { get; set; }

        // The game mode the score is associated with.
        [JsonProperty(PropertyName = "gameMode")]
        public string GameMode { get; set; }

        // The game region (map) the score is associated with.
        [JsonProperty(PropertyName = "gameRegion")]
        public string GameRegion { get; set; }
    }
}