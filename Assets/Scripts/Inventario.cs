using UnityEngine;

public class Invenario : MonoBehaviour
{
    // Cantidad de cada ingrediente
    public int tomates = 0;
    public int lechugas = 0;
    public int quesos = 0;

    // Añadir ingredientes
    public void AddIngredient(IngredientType tipo)
    {
        switch (tipo)
        {
            case IngredientType.Tomate:
                tomates++;
                break;

            case IngredientType.Lechuga:
                lechugas++;
                break;

            case IngredientType.Queso:
                quesos++;
                break;
        }

        Debug.Log("Inventario actualizado");
    }

    // Consultar cantidades
    public int GetIngredientCount(IngredientType tipo)
    {
        switch (tipo)
        {
            case IngredientType.Tomate:
                return tomates;

            case IngredientType.Lechuga:
                return lechugas;

            case IngredientType.Queso:
                return quesos;

            default:
                return 0;
        }
    }
}