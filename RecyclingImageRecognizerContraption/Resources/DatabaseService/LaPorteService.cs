using RecyclingImageRecognizerContraption.Resources.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingImageRecognizerContraption.Resources.Service;

public class LaPorteService(string dbPath)
{
    private SQLiteConnection _connection;
    string _dbPath = dbPath;
    public string? StatusMessage;

    private void Init()
    {
        if (_connection != null)
        {
            return;
        }
        _connection = new SQLiteConnection(_dbPath);
        _connection.CreateTable<LaPorte>();
    }
    public List<LaPorte> GetItems()
    {
        
        try
        {
            Init();
            return _connection.Table<LaPorte>().ToList();
        }
        catch (Exception)
        {
            StatusMessage = "Failed to get data;";
        }
        return new List<LaPorte>();

    }
    
}
