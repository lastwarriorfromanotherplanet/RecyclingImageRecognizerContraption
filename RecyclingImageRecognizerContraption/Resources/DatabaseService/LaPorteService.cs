using RecyclingImageRecognizerContraption.Resources.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecyclingImageRecognizerContraption.Resources.Service;

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

    public async Task AddItemAsync(LaPorte item)
    {
        try
        {
            await Init();
            await _connection.InsertAsync(item);
            StatusMessage = "Item added successfully";
        }
        catch (Exception ex)
        {
            StatusMessage = $"Failed to add item: {ex.Message}";
        }
    }
}
