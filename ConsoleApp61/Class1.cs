using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Class1
    {
        public class CommissionEmployee : object
        {
            public string FirsName { get; }
            public string LastName { get; }

            public string SocialSecurityNumber { get; }

            private decimal grossSales;
            private decimal commissionRate;

            public CommissionEmployee(string firstName, string lastName, string socialSecurityNumber, decimal grossSales, decimal commissionRate)
            {
                FirsName = firstName;
                LastName = lastName;
                SocialSecurityNumber = socialSecurityNumber;
                GrossSales = grossSales;
                CommissionRate = commissionRate;
            }

            public decimal GrossSales
            {
                get
                {
                    return grossSales;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GrossSales)}must be>=0");
                    }
                    GrossSales = value;
                }
            }

            public decimal CommissionRate
            {
                get
                {
                    return CommissionRate;
                }
                set
                {

                    if (value <= 0 || value >= 1)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(CommissionRate)} must be>0 and<1");
                    }

                    CommissionRate = value;
                }
            }

            public decimal Earnings() => CommissionRate * GrossSales;

            public override string ToString() => $"commission employee:{FirsName}{LastName}\n" + $"social security number:{SocialSecurityNumber}\n" + $"gross sales:{grossSales:C}\n" + $"commission rate :{commissionRate:F2}";
        }
            
                
            

        }
}
