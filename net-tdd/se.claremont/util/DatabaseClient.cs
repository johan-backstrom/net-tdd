using System.Collections.Generic;

namespace net_tdd.se.claremont.util
{
    public class DatabaseClient
    {
        private static Dictionary<string, int> theFakeDatabase = new Dictionary<string, int>();

        public static void writeToDatabase(VehiclePremium v)
        {
            theFakeDatabase.Add(v.licencePlate, v.insurancePremium);
        }

        public static VehiclePremium readFromDatabase(string licencePlate)
        {
            if (!theFakeDatabase.ContainsKey(licencePlate))
            {
                //throw new RuntimeException("Premium not found");
            }
            VehiclePremium vp = new VehiclePremium();

            vp.licencePlate = licencePlate;
            vp.insurancePremium = theFakeDatabase[licencePlate];

            return vp;



        }

    }
}
