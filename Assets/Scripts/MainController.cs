using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public Transform Sun;
    public Transform Mercury;
    public Transform Venus;
    public Transform Earth;
    public Transform Mars;
    public Transform Jupiter;

    public float time_multipler;

    void Awake()
    {
        Sun = Instantiate<Transform>(
            Resources.Load<Transform>("Prefabs/Sun"),
            Vector3.zero, Quaternion.identity);

        Mercury = Instantiate<Transform>(
            Resources.Load<Transform>("Prefabs/Mercury"),
            new Vector3(0, 0, -579.1f), Quaternion.identity);

        Venus = Instantiate<Transform>(
            Resources.Load<Transform>("Prefabs/Venus"),
            new Vector3(0, 0, -1210.5f), Quaternion.identity);

        Earth = Instantiate<Transform>(
            Resources.Load<Transform>("Prefabs/Earth"),
            new Vector3(0, 0, -1496.0f), Quaternion.identity);

        Mars = Instantiate<Transform>(
            Resources.Load<Transform>("Prefabs/Mars"),
            new Vector3(0, 0, -2279.4f), Quaternion.identity);

        Jupiter = Instantiate<Transform>(
            Resources.Load<Transform>("Prefabs/Jupiter"),
            new Vector3(0, 0, -7783.3f), Quaternion.identity);

        time_multipler = 1.0f;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Mercury.RotateAround(Sun.position, new Vector3(0, 1, 0), 0.0414866f);
        Venus.RotateAround(Sun.position, new Vector3(0, 1, 0), 0.01082921f);
        Earth.RotateAround(Sun.position, new Vector3(0, 1, 0), 0.006666667f);
        Mars.RotateAround(Sun.position, new Vector3(0, 1, 0), 0.003542073f);
        Jupiter.RotateAround(Sun.position, new Vector3(0, 1, 0), 0.00056497175f);
    }
}
