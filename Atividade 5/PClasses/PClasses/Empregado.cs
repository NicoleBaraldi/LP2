﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
abstract class Empregado
    {
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;


        public int Matricula
        {
         get {return matricula;}
         set { matricula = value;}
        }

        public string NomeEmpregado
        {
        get { return nomeEmpregado; }
        set { nomeEmpregado = value; }
        }

       public DateTime DataEntradaEmpresa
        {
        get { return dataEntradaEmpresa; }
        set { dataEntradaEmpresa = value; }
        }

        public virtual int TempoTrabalho()
        {
            TimeSpan SPAN = DateTime.Today.Subtract(DataEntradaEmpresa);

            return (SPAN.Days);

        }

        public abstract double SalarioBruto();




    }
}
