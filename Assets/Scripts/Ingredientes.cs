using UnityEngine;
using static IngredientesTipos;

public class Ingredientes : MonoBehaviour
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