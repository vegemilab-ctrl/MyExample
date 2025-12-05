using UnityEngine;
using UnityEngine.UI;

public class healthBarController : MonoBehaviour
{
    public Slider healthbar;
    void Start()
    {
        GameObject go = GameObject.Find("HealthBar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
