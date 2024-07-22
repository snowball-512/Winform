using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3

{
    private double r;
    public double bankinh { 
        get { return r}; 
        set
        {
            r = value;
            d = 2 * r;
            s = Math.PI * r * r;
        }
    }
    public double d { get; private set; }
    public double s { get; private set; }
    public hinhtron(double r)
    {
        bankinh = r;
    }
   
    internal class Program
    {
       
        static void Main(string[] args)
        {
        }
    }

}
