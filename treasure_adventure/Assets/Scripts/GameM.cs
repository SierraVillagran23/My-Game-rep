using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameM : MonoBehaviour
{
    public Transform pfHealthBar;
    // Start is called before the first frame update
    void Start()
    {
       Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0,10), Quaternion.identity);
        HealthSystem healthSystem = new HealthSystem(100);
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();
        healthBar.Setup(healthSystem);


        Debug.Log("Health :" + healthSystem.GetHealthPercent());
        healthSystem.Damage(10);
        Debug.Log("Health :" + healthSystem.GetHealthPercent());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
