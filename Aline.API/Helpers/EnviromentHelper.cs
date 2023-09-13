using System;

namespace Aline.API.Helpers
{
    public class EnviromentHelper
    {
        public static EnviromentType GetEnviroment()
        {
            if (Environment.GetEnvironmentVariable("COD_AMBI_EXEO")?.ToUpper() == "DES")
            {
                return EnviromentType.Dev;
            }
            else if (Environment.GetEnvironmentVariable("COD_AMBI_EXEO")?.ToUpper() == "PRD")
            {
                return EnviromentType.Prod;
            }
            else
            {
                return EnviromentType.Local;
            }
        }

        public static bool IsDevelopment()
        {
            EnviromentType enviroment = GetEnviroment();
            return enviroment == EnviromentType.Local || enviroment == EnviromentType.Dev;
        }

        public static bool IsProduction()
        {
            return GetEnviroment() == EnviromentType.Prod;
        }
    }

    public enum EnviromentType
    {
        Local = 0,
        Dev = 1,
        Prod = 2
    }
}