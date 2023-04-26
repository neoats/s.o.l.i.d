using Firebase.Database;

namespace interfaceSegregation.abstracts.FireBase;

public interface IFirebaseCommand
{
    Task<FirebaseObject<T>> PushAsync<T>(string path, T data);
    Task SetAsync<T>(string path, T data);
    Task<FirebaseObject<T>> GetAsync<T>(string path);
    Task UpdateAsync<T>(string path, T data);
    Task DeleteAsync(string path);
    Task<FirebaseObject<T>> GetByQueryAsync<T>(string path, string orderBy = null, string startAt = null, string endAt = null, int limitToFirst = -1, int limitToLast = -1);

}