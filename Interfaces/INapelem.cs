using NapelemEditor.Models;

namespace NapelemEditor.Interfaces;

public interface INapelem
{
    public Task<List<Napelem>> GetAllNapelem();
    public void AddNapelem(Napelem napelem);
    public void UpdateNapelem(Napelem napelem);
    public void DeleteNapelem(string napelemID);
}