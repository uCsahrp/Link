using System.Collections.Generic;

namespace ModelsLibrary.Utilities
{
    public interface IDataAccess
    {
        List<T> LoadData<T>(string sql);
        void SaveData<T>(T user, string sql);
        void UpdateData<T>(string sql);
        string LoadConnectionString(string id = "Default");
    }
}