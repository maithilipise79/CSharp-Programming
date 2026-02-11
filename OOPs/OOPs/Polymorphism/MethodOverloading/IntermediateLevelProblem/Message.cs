using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism.MethodOverloading.IntermediateLevelProblem
{
    public class Message
    {
        //9)Create a method SendMessage() that works for: (Mobile number, Email, Mobile number with country code)

        public static string SendMessage(long mob,string email,int countryCode)=> $"{email} +{countryCode} {mob}";
        public static string SendMessage(string email, long mob,int countryCode)=> $"{email} +{countryCode} {mob}";
        public static string SendMessage(long mob,int countryCode, string email) => $"{email} +{countryCode} {mob}";
        public static string SendMessage(int countryCode, string email, long mob) => $"{email} +{countryCode} {mob}";
        public static string SendMessage(int countryCode, long mob, string email) => $"{email} +{countryCode} {mob}";
        

    }
}
