using UnityEngine;
using static IngredientesTipos;

public class Inventory : MonoBehaviour
{
    // Cantidad de cada ingrediente
    public int BayBolete = 0;
    public int InkCap = 0;
    public int FlyAgaric = 0;

    // Añadir ingredientes
    public void AddIngredient(IngredientType tipo)
    {
        switch (tipo)
        {
            case IngredientType.BayBolete:
                BayBolete++;
                break;

            case IngredientType.BayBolete_Group:
                BayBolete++;
                BayBolete++;
                break;

            case IngredientType.InkCap:
                InkCap++;
                break;

            case IngredientType.InkCap_Group:
                InkCap++;
                InkCap++;
                break;

            case IngredientType.FlyAgaric:
                FlyAgaric++;
                break;

            case IngredientType.FlyAgaric_Group:
                FlyAgaric++;
                FlyAgaric++;
                break;
        }
    }

    // Consultar cantidades
    public int GetIngredientCount(IngredientType tipo)
    {
        switch (tipo)
        {
            case IngredientType.BayBolete:
                return BayBolete;

            case IngredientType.InkCap:
                return InkCap;

            case IngredientType.FlyAgaric:
                return FlyAgaric;

            default:
                return 0;
        }
    }
}