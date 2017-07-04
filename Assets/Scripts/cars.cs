using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cars : MonoBehaviour {

    private string company;
    private string model;
    private int year;

    public string Company{
        get{ 
            return company;
        }set{ 
            company = value;
        }
    }

    public string Model{
        get{ 
            return model;
        }
        set{
            model = value; 
        }
    }

    public int Year{
        get{ 
            return year;  
        }
        set{
            year = value;
        }
    }
}
