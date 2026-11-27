using UnityEngine;

public enum IngredientType
{
    Tomate,
    Lechuga,
    Queso
}

public class Ingredient : MonoBehaviour
{
    public IngredientType tipoIngrediente;

    public void Recoger(Inventory inventario)
    {
        if (inventario != null)
        {
            inventario.AddIngredient(tipoIngrediente);

            Destroy(gameObject);
        }
    }
}