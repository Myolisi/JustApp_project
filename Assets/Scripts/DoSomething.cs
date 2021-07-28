using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoSomething : MonoBehaviour {

    public Text textField;
    public InputField display;
    public InputField modelInput;
    public InputField companyInput;
    public InputField yearInput;
    cars car;

    List<cars> carList;

	// Use this for initialization
	void Start () {
        carList = new List<cars>();
        car = new cars();
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    public void hello () {

        textField.text = "Welcome";
    }

    public void getCars()
    {
        car.Model = modelInput.text;
        car.Company = companyInput.text;
        car.Year = 2011;

        carList.Add(car);

        foreach (var item in carList)
        {
            display.text += "\n"+item.Company + " " + item.Model + " " + item.Year +"\n";
        }
    }

    public void displayAll(){
        
    }
}
