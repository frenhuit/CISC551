using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WineTaste.Entities;

namespace WineTaste.Models.ModelsImpl
{
    internal class CategoryDataAccess : ICategoryRepository
    {
        public CategoryDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private string ConnectionString { get; }

        public List<Category> GetCategories()
        {
            var result = new List<Category>();
            using var connection = GetConnection();
            connection.Open();
            var command =
                new MySqlCommand(
                    "select category_id, category_name, category_description, category_image from category",
                    connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var categoryId = Convert.ToInt32(reader["category_id"]);
                var categoryName = reader["category_name"].ToString();
                var categoryDescription = reader["category_description"].ToString();
                var categoryImage = reader["category_image"].ToString();
                var category = new Category
                {
                    CategoryId = categoryId, CategoryName = categoryName,
                    CategoryDescription = categoryDescription, CategoryImage = categoryImage
                };
                result.Add(category);
            }

            return result;
        }

        public Category GetCategoryById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var command =
                new MySqlCommand(
                    $"select category_id, category_name, category_description, category_image from category where category_id = {id}",
                    connection);
            using var reader = command.ExecuteReader();
            if (!reader.Read()) return null;
            var categoryId = Convert.ToInt32(reader["category_id"]);
            var categoryName = reader["category_name"].ToString();
            var categoryDescription = reader["category_description"].ToString();
            var categoryImage = reader["category_image"].ToString();
            var category = new Category
            {
                CategoryId = categoryId, CategoryName = categoryName,
                CategoryDescription = categoryDescription, CategoryImage = categoryImage
            };
            return category;

        }

        public List<Varietal> GetVarietalsOfCategory(int categoryId)
        {
            var result = new List<Varietal>();
            using var connection = GetConnection();
            connection.Open();
            var command =
                new MySqlCommand(
                    $"select varietal_id, varietal_name from varietal where category_id = {categoryId}",
                    connection);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var varietalId = Convert.ToInt32(reader["varietal_id"]);
                var varietalName = reader["varietal_name"].ToString();
                var varietal = new Varietal {VarietalId = varietalId, VarietalName = varietalName};
                result.Add(varietal);
            }

            return result;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}