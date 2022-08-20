using System;

namespace ClashOfClans.Core.Utils
{
    public static class ClashExtensions
    {
        public static string GetWarFrequency(this WarFrequency? warFrequency)
        {
            string warFreq;

            switch (warFrequency)
            {
                case WarFrequency.Always:
                    warFreq = "always";
                    break;
                case WarFrequency.LessThanOncePerWeek:
                    warFreq = "lessThanOncePerWeek";
                    break;
                case WarFrequency.MoreThanOncePerWeek:
                    warFreq = "moreThanOncePerWeek";
                    break;
                case WarFrequency.OncePerWeek:
                    warFreq = "oncePerWeek";
                    break;
                case WarFrequency.Never:
                    warFreq = "never";
                    break;
                case WarFrequency.Unknown:
                    warFreq = "unknown";
                    break;
                default:
                    throw new Exception($"Invalid war frequency \"{warFrequency}\"");
            }

            return warFreq;
        }
    }
}
