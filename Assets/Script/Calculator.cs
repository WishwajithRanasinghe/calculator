using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{

    [SerializeField] private Text _resulttext;
    [SerializeField] private float _num1 = 0f;
    [SerializeField] private float _num2 = 0f;
    [SerializeField] private string _operation;

    
 

    public void iAddition()
    {
       _num1 = float.Parse(_resulttext.text);
       _operation = ("+");
       _resulttext.text = "";
        
    }


    public void iDivition()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("/");
        _resulttext.text = "";        
        
    }
    public void iSubtraction()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("-");
        _resulttext.text = "";        
        
    }
    public void iMultiplication()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("*");
        _resulttext.text = "";        
        
    }
    public void iSquare()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("SQUR");
        _resulttext.text = "";        
        
    }
    public void iSquareRoot()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("SQRT");
        _resulttext.text = "";        
        
    }
    public void iPresentage()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("%");
        _resulttext.text = "";        
        
    }
    public void i1DivX()
    {
        _num1 = float.Parse(_resulttext.text);
        _operation = ("1/X");
        _resulttext.text = "";        
        
    }
    public void btndigt7()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "7";
        }
        else
        {
            _resulttext.text = _resulttext.text + "7";
        }
    }
    public void btndigt8()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "8";
        }
        else
        {
            _resulttext.text = _resulttext.text + "8";
        }
    }
    public void btndigt9()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "9";
        }
        else
        {
            _resulttext.text = _resulttext.text + "9";
        }
    }
    public void btndigt6()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "6";
        }
        else
        {
            _resulttext.text = _resulttext.text + "6";
        }
    }
    public void btndigt5()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "5";
        }
        else
        {
            _resulttext.text = _resulttext.text + "5";
        }
    }
    public void btndigt4()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "4";
        }
        else
        {
            _resulttext.text = _resulttext.text + "4";
        }
    }
    public void btndigt3()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "3";
        }
        else
        {
            _resulttext.text = _resulttext.text + "3";
        }
    }
    public void btndigt2()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "2";
        }
        else
        {
            _resulttext.text = _resulttext.text + "2";
        }
    }
    public void btndigt1()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "1";
        }
        else
        {
            _resulttext.text = _resulttext.text + "1";
        }
    }
    public void btndigt0()
    {
        if(_resulttext.text ==  Convert.ToString(0))
        {
            _resulttext.text = "0";
        }
        else
        {
            _resulttext.text = _resulttext.text + "0";
        }
    }
    public void EqualOper()
    {
        float _answer = 0f;
        _num2 = float.Parse(_resulttext.text);

        if(_operation == "+")
        {
            _answer = _num1 + _num2;
            _resulttext.text = _answer.ToString();
        }
        if(_operation == "-")
        {
            _answer = _num1 - _num2;
            _resulttext.text = _answer.ToString();
        }
        if(_operation == "*")
        {
            _answer = _num1 * _num2;
            _resulttext.text = _answer.ToString();
        }
        if(_operation == "/")
        {
            _answer = _num1 / _num2;
            _resulttext.text = _answer.ToString();
        }
        
        

    }
    public void btnClear()
    {
        _resulttext.text = "0";
    }
    public void btnEClear()
    {
        _resulttext.text = "0";
        string f, s;
        f = Convert.ToString(_num1);
        s = Convert.ToString(_num2);

        f = "";
        s = "";
    }
    public void btnBackSpace()
    {
        if(_resulttext.text.Length > 0 )
        {
            _resulttext.text = _resulttext.text.Remove(_resulttext.text.Length -1,1);
        }
        if(_resulttext.text ==  "")
        {
            _resulttext.text = "0";
        }
    }
    public void plusMinus()
    {
        float q = float.Parse(_resulttext.text);
        _resulttext.text = Convert.ToString(-1 * q);
    }
    public void btnDec()
    {
        if(!_resulttext.text.Contains("."))
        {
            _resulttext.text = _resulttext.text + ".";
        }
    }
    



}//Class
