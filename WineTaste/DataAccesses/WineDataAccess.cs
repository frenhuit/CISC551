using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WineTaste.Entities;

namespace WineTaste.Models.ModelsImpl
{
    public class WineDataAccess : IWineRepository
    {
        public WineDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private string ConnectionString { get; }

        public List<Wine> GetWines()
        {
            var result = new List<Wine>();
            using var connection = GetConnection();
            connection.Open();
            var command =
                new MySqlCommand(
                    "select wine_id, varietal_id, wine_name, wine_region, wine_price, wine_image, wine_description, wine_year, wine_rating, wine_review from wine",
                    connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var wineId = Convert.ToInt32(reader["wine_id"]);
                var varietalId = Convert.ToInt32(reader["varietal_id"]);
                var wineName = reader["wine_name"].ToString();
                var wineRegion = reader["wine_region"].ToString();
                var winePrice = Convert.ToDouble(reader["wine_price"]);
                var wineImage = reader["wine_image"].ToString();
                var wineDescription = reader["wine_description"].ToString();
                var wineYear = Convert.ToInt32(reader["wine_year"]);
                var wineRating = Convert.ToDouble(reader["wine_rating"]);
                var wineReview = reader["wine_review"].ToString();
                var wine = new Wine
                {
                    WineId = wineId,
                    VarietalId = varietalId,
                    WineName = wineName,
                    WineRegion = wineRegion,
                    WinePrice = winePrice,
                    WineImage = wineImage,
                    WineDescription = wineDescription,
                    WineYear = wineYear,
                    WineRating = wineRating,
                    WineReview = wineReview
                };
                result.Add(wine);
            }

            return result;
        }

        public Wine GetWineById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand(
                $"select wine_id, varietal_id, wine_name, wine_region, wine_price, wine_image, wine_description, wine_year, wine_rating, wine_review from wine where wine_id = {id}",
                connection);
            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;
            var wineId = Convert.ToInt32(reader["wine_id"]);
            var varietalId = Convert.ToInt32(reader["varietal_id"]);
            var wineName = reader["wine_name"].ToString();
            var wineRegion = reader["wine_region"].ToString();
            var winePrice = Convert.ToDouble(reader["wine_price"]);
            var wineImage = reader["wine_image"].ToString();
            var wineDescription = reader["wine_description"].ToString();
            var wineYear = Convert.ToInt32(reader["wine_year"]);
            var wineRating = Convert.ToDouble(reader["wine_rating"]);
            var wineReview = reader["wine_review"].ToString();
            var wine = new Wine
            {
                WineId = wineId,
                VarietalId = varietalId,
                WineName = wineName,
                WineRegion = wineRegion,
                WinePrice = winePrice,
                WineImage = wineImage,
                WineDescription = wineDescription,
                WineYear = wineYear,
                WineRating = wineRating,
                WineReview = wineReview
            };
            return wine;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}