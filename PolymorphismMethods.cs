using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_PolymorphismAndFSO
{
    class PolymorphismMethods
    {

        // Early binding, Overloaded Methods

        #region Methods
        // Add Polymorphism
        public int Add(int inputNum1, int inputNum2)
        {
            int intReturn = inputNum1 + inputNum2;
            return intReturn;
        }
        public int Add(int inputNum1, int inputNum2, int inputNum3)
        {
            int intReturn = inputNum1 + inputNum2 + inputNum3;
            return intReturn;
        }
        public string Add(string strInput1, string strInput2)
        {

            string strReturn = strInput1 + " " + strInput2;
            //string strReturn = $"{strInput1} {strInput2}";
            // return strReturn;
            return strReturn;
        }

        #endregion

    }
}
