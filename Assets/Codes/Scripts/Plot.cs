using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour {

    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] Color hoverColor;
    private GameObject towerObj;
    public Turret turret;
    private Color startColor;

    private void Start() {
        startColor = sr.color;
    }

    private void OnMouseEnter() {
        sr.color = hoverColor;
    }

    private void OnMouseExit() {
        sr.color = startColor;
    }

   private void OnMouseDown() {
        // if (UIManager.main.IsHoveringUI()) return;
        if (towerObj != null)
        {
            turret.OpenUI();
            return;
        } 

        Tower towerToBuild = BuildManager.main.GetSelectedTower();

        if (towerToBuild.cost > PlayerStats.Money)
        {
            Debug.Log("Insufficient Funds");
            return;
        }

        LevelManager.main.SpendCurrency(towerToBuild.cost);
        towerObj = Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);
        turret = towerObj.GetComponent<Turret>();
        
    }

}