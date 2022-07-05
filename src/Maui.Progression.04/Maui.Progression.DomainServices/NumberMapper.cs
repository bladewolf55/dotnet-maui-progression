using Maui.Progression.Domain.Models;
using Maui.Progression.DomainServices.Interfaces;
using System.Text.Json;

namespace Maui.Progression.DomainServices
{
    public class NumberMapper : INumberMapper
    {
        string numberData = @"[
{""number"":1, ""word"":""one""},
{""number"":2, ""word"":""two""},
{""number"":3, ""word"":""three""},
{""number"":4, ""word"":""four""},
{""number"":5, ""word"":""five""},
{""number"":6, ""word"":""six""},
{""number"":7, ""word"":""seven""},
{""number"":8, ""word"":""eight""},
{""number"":9, ""word"":""nine""},
{""number"":10, ""word"":""ten""}
]";

        public NumberMapper(string numberData = "")
        {
            // Normally numberData would be an injectable data service
            // like Entity Framework.
            // Here we're letting the unit test inject test data. If empty,
            // assume the data service returned values 1-10.
            if (!String.IsNullOrEmpty(numberData))
                this.numberData = numberData;
        }
        public NumberMap GetNumberMap()
        {
            // Get our data and map it to our domain model list of map items.
            var options = new System.Text.Json.JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            var items = JsonSerializer.Deserialize<List<NumberMapItem>>(numberData, options);
            // Populate the NumberMap domain model
            var map = new NumberMap() { Map = items ?? new List<NumberMapItem>() };
            // Return the domain model
            return map; ;
        }
    }
}
