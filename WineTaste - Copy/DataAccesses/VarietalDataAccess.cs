using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WineTaste.Entities;

namespace WineTaste.Models.ModelsImpl
{
    public class VarietalDataAccess : IVarietalRepository
    {
        public VarietalDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private string ConnectionString { get; }

        public List<Varietal> GetVarietals()
        {
            var result = new List<Varietal>();
            using var connection = GetConnection();
            connection.Open();
            var command =
                new MySqlCommand(
                    "select varietal_id, category_id, varietal_name, varietal_description, varietal_image from varietal",
                    connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var varietalId = Convert.ToInt32(reader["varietal_id"]);
                var categoryId = Convert.ToInt32(reader["category_id"]);
                var varietalName = reader["varietal_name"].ToString();
                var varietalDescription = reader["varietal_description"].ToString();
                var varietalImage = reader["varietal_image"].ToString();
                var varietal = new Varietal()
                {
                    VarietalId = varietalId,
                    CategoryId = categoryId,
                    VarietalName = varietalName,
                    VarietalDescription = varietalDescription,
                    VarietalImage = varietalImage
                };
                result.Add(varietal);
            }

            return result;
        }

        public Varietal GetVarietalById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand($"select varietal_id, category_id, varietal_name, varietal_description, varietal_image from varietal where varietal_id = {id}", connection);
            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;
            var varietalId = Convert.ToInt32(reader["varietal_id"]);
            var categoryId = Convert.ToInt32(reader["category_id"]);
            var varietalName = reader["varietal_name"].ToString();
            var varietalDescription = reader["varietal_description"].ToString();
            var varietalImage = reader["varietal_image"].ToString();
            var varietal = new Varietal()
            {
                VarietalId = varietalId,
                CategoryId = categoryId,
                VarietalName = varietalName,
                VarietalDescription = varietalDescription,
                VarietalImage = varietalImage
            };
            return varietal;

        }

        public List<Wine> GetWinesOfVarietal(int varietalId)
        {
            var result = new List<Wine>();
            using var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand(cmdText: $"select wine_id, wine_name from wine where varietal_id = {varietalId}", connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var wineId = Convert.ToInt32(reader["wine_id"]);
                var wineName = reader["wine_name"].ToString();
                var wine = new Wine() {WineId = wineId, WineName = wineName};
                result.Add(wine);
            }

            return result;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}