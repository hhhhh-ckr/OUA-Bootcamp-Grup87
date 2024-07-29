using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class SpaceShipController : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
    }
}

public class PlanetSelector : MonoBehaviour
{
    public Transform[] planets;
    private int currentPlanetIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentPlanetIndex = (currentPlanetIndex > 0) ? currentPlanetIndex - 1 : planets.Length - 1;
            UpdatePlanetSelection();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentPlanetIndex = (currentPlanetIndex < planets.Length - 1) ? currentPlanetIndex + 1 : 0;
            UpdatePlanetSelection();
        }
    }

    void UpdatePlanetSelection()
    {
        // Logic to update the selected planet visually or functionally
        Debug.Log("Selected planet: " + planets[currentPlanetIndex].name);
    }
}

public class TimeDiscovery : MonoBehaviour
{
    public string[] timePeriods;
    private int currentPeriodIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentPeriodIndex = (currentPeriodIndex < timePeriods.Length - 1) ? currentPeriodIndex + 1 : 0;
            UpdateTimePeriod();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentPeriodIndex = (currentPeriodIndex > 0) ? currentPeriodIndex - 1 : timePeriods.Length - 1;
            UpdateTimePeriod();
        }
    }

    void UpdateTimePeriod()
    {
        // Logic to update the time period visually or functionally
        Debug.Log("Selected time period: " + timePeriods[currentPeriodIndex]);
    }
}

public class ResourceCollector : MonoBehaviour
{
    public int resourceCount = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Resource"))
        {
            resourceCount += 1;
            Destroy(other.gameObject);
            Debug.Log("Resource collected! Total: " + resourceCount);
        }
    }
}
