using RecyclingImageRecognizerContraption.Resources.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecyclingImageRecognizerContraption.Resources.DatabaseService;

public class LaPorteService(string dbPath)
{
    private SQLiteAsyncConnection _connection;
    string _dbPath = dbPath;
    public string? StatusMessage;

    private async Task Init()
    {
        if (_connection != null)
            return;

        _connection = new SQLiteAsyncConnection(_dbPath);
        await _connection.CreateTableAsync<LaPorte>();
    }

    public async Task<List<LaPorte>> GetItemsAsync()
    {
        try
        {
            await Init();
            return await _connection.Table<LaPorte>().ToListAsync();
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to get data: {ex.Message}";
            return new List<LaPorte>();
        }
    }

    public async Task AddItemListAsync(List<LaPorte> itemList)
    {
        try
        {
            await Init();
            await _connection.InsertAllAsync(itemList);
            StatusMessage = "Item added successfully";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to add item: {ex.Message}";
        }
    }

    public async Task<List<string?>> GetUniqueCategoriesAsync()
    {
        try
        {
            await Init();
            var allItems = await _connection.Table<LaPorte>().ToListAsync();
            return allItems
                .Where(x => !string.IsNullOrEmpty(x.Category))
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x)
                .ToList();
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to get categories: {ex.Message}";
            return new List<string?>();
        }
    }



}
