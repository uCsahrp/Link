using System.Collections.Generic;

namespace ModelsLibrary.Utilities
{
    public interface IDataAccess
    {
        string LoadConnectionString(string id = "Default");
        List<T> LoadData<T>(string sql);
        void SaveData<T>(T user, string sql);
        void UpdateData<T>(T user, string sql);
    }
}