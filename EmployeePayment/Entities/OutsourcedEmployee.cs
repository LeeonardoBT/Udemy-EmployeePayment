using System;
using System.Collections.Generic;
using System.Globalization;

namespace EmployeePayment.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }

        public static implicit operator List<object>(OutsourcedEmployee v)
        {
            throw new NotImplementedException();
        }
    }
}
