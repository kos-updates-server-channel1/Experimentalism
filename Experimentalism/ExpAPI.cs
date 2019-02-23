using System;

namespace Experimentalism
{
    class ExpAPI : IExpAPIs
    {
        public static string GetOSConfig()
        {
            String sProcess;
            if(Environment.Is64BitOperatingSystem == true)
            {
                sProcess = "64 Bit";
            }
            else
            {
                sProcess = "32 Bit";
            }
            return sProcess;
        }

        public void Experimentalism_Dummy()
        {
            Console.Write("");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    [Serializable]
    class ExpAPI_Version : IExpAPIs
    {
        public double ver;
        public ExpAPI_Version(double Ver)
        {
            changeVersion(Ver);
        }

        public void Experimentalism_Dummy()
        {
            Console.Write("");
        }

        private void changeVersion(double a)
        {
            ver = a;
        }
    }
}