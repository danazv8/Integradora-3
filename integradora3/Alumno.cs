using System;
using System.Collections.Generic;
using System.Text;
using integradora3;

public class Alumno : Persona

{
    public string Nombre { get; set; }
    public int Legajo { get; private set; }
    public decimal Nota1 { get; private set; }
    public decimal Nota2 { get; private set; }

    public Alumno(string nombre,int dni, int legajo) : base(nombre, dni)
    
    {
        Legajo = legajo;
    }
    
    public decimal Promedio()
    {
        decimal prom = (Nota1 + Nota2) / 2;
        return prom;

    }

    public bool EstaAprobado()
    {
        return Promedio() >= 6;
    }

    public void SubirNota()
    {
        Nota1++;
        Nota2++;

        if (Nota1 > 10)
        {
            Nota1 = 10;
        }
        if (Nota2 > 10)
        {
            Nota2 = 10;
        }

    }
    public override string ToString()
        // sin el override no reemplazas el metodo ToString() 
    {

        return $"{Legajo} - {Nombre} (promedio: {Promedio()})";

    }
    public bool CargarNotas(decimal nota1, decimal nota2)
    {
        if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            return false;
        }
        else
        {
            Nota1 = nota1;
            Nota2 = nota2;
            return true;
        }
    }
}

