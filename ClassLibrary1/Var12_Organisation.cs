using System;

namespace ClassLibrary1
{
    public class Var12_Organisation
    {
        private string name;
        private string legalAdress;
        private string actualAdress;
        private Employee employee;
        public Var12_Organisation(string name, string legalAdress, string actualAdress, string refSupervisor)
        {
            this.name = name;
            this.legalAdress = legalAdress;
            this.actualAdress = actualAdress;
            this.employee = employee;


        }
        public double Div(double n1, double n2)
        {
            // Проверка деления на "0"
            if (n2 == 0.0D)
                throw new DivideByZeroException();
            return n1 / n2;
        }
        public Var12_Organisation()
        {

        }

    }
}