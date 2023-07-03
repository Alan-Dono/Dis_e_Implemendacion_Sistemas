
namespace CrearAnimales.EntitiesLayer.Interfaces
{
    public interface IFood
    {
        string GetName();
        IFood GetType();
        int getCalories();
    }
}
