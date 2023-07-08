using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Comandos;
using UnityEngine.UI;

public class PlayerCommads : MonoBehaviour
{
    int Actionnumber;
     private List<Commands> playeractions = new List<Commands>();

    [SerializeField] private GameObject IconPrefab;
    [SerializeField] private Transform PlayerPanel;
  
    public void Initialize(List<Commands> actions)
    {
        playeractions = actions;
        for (int i = 0; i < playeractions.Count; i++)
        {
            GameObject go = IconPrefab;//Instanciar prefab en el tranform que toca

            Image icon = go.GetComponent<Image>();
            icon.sprite = playeractions[i].icon;
        }
    }
    private void DoAction()
    {
        playeractions[Actionnumber].Execute();
    }
    public void IncreaseIndex()
    {
        Actionnumber++;
        DoAction();
    }
}
