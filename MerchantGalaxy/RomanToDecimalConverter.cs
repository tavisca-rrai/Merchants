using System;
using System.Collections.Generic;
namespace MerchantGalaxy
{
    public static class RomanToDecimalConverter
    {
        private static readonly Dictionary<char,int> ValueOfRomanDigit=new Dictionary<char, int>{
            {'I',1},
            {'V',5},
            {'X',10},
            {'L',50},
            {'C',100},
            {'D',500},
            {'M',1000}
        };
        public static int Convert(string romanValue){
            int decimalValue=0;
            //todo
            return decimalValue;
        }
    }
}
