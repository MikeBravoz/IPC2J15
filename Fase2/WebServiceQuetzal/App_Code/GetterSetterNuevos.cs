using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GetterSetterNuevos
/// </summary>
public class GetterSetterNuevos
{
	public GetterSetterNuevos()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    //Declaracion de Variables
    string nombre;
    string apellido;
    int dpi;
    int nit;
    int telefono;
    string direccion;
    string email;
    char fecnac;
    int numtar;
    string tiptar;
    char fecex;
    string banco;

    //Metodos setter
    public void setNombre(string a)
    {
        nombre = a;
    }
    public void setApellido(string a)
    {
        apellido = a;
    }
    public void setDpi(int a)
    {
        dpi = a;
    }
    public void setNit(int a)
    {
        nit = a;
    }
    public void setTelefono(int a)
    {
        telefono = a;
    }
    public void setDireccion(string a)
    {
        direccion = a;
    }
    public void setEmail(string a)
    {
        email = a;
    }
    public void setFecnac(char a)
    {
        fecnac = a;
    }
    public void setNumtar(int a)
    {
        numtar = a;
    }
    public void setTiptar(string a)
    {
        tiptar = a;
    }
    public void setFecex(char a)
    {
        fecex = a;
    }
    public void setBanco(string a)
    {
        banco = a;
    }

    //Metodos getter

    public string getNombre()
    {
        return nombre;
    }
    public string getApellido()
    {
        return apellido;
    }
    public int getDpi()
    {
        return dpi;
    }
    public int getNit()
    {
        return nit;
    }
    public int getTelefono()
    {
        return telefono;
    }
    public string getDireccion()
    {
        return direccion;
    }
    public string getEmail()
    {
        return email;
    }
    public char getFecnac()
    {
        return fecnac;
    }
    public int getNumtar()
    {
        return numtar;
    }
    public string getTiptar()
    {
        return tiptar;
    }
    public char getFecex()
    {
        return fecex;
    }
    public string getBanco()
    {
        return banco;
    }

}